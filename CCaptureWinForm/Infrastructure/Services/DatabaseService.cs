﻿using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Data;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CCaptureWinForm.Infrastructure.Services
{
    public class DatabaseService : IDatabaseService
    {
        private readonly IConfiguration _configuration;

        public DatabaseService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private CCaptureDbContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CCaptureDbContext>();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
            return new CCaptureDbContext(optionsBuilder.Options);
        }

        public async Task<int> SaveGroupAsync(string groupName, bool isSubmitted)
        {
            using (var context = CreateContext())
            {
                var group = new Group
                {
                    GroupName = groupName,
                    IsSubmitted = isSubmitted,
                    CreatedAt = DateTime.Now
                };
                context.Groups.Add(group);
                await context.SaveChangesAsync();
                return group.GroupId;
            }
        }

        public async Task<int> SaveSubmissionAsync(int groupId, string batchClassName, string sourceSystem, string channel, string sessionId, string messageId, string userCode, string interactionDateTime, string requestGuid, string authToken)
        {
            using (var context = CreateContext())
            {
                var submission = new Submission
                {
                    GroupId = groupId,
                    BatchClassName = batchClassName,
                    SourceSystem = sourceSystem,
                    Channel = channel,
                    SessionId = sessionId,
                    MessageId = messageId,
                    UserCode = userCode,
                    InteractionDateTime = DateTime.Parse(interactionDateTime),
                    RequestGuid = requestGuid,
                    AuthToken = authToken,
                    SubmittedAt = DateTime.Now
                };
                context.Submissions.Add(submission);
                await context.SaveChangesAsync();
                return submission.SubmissionId;
            }
        }

        public async Task SaveDocumentAsync(int submissionId, string filePath, string pageType, string fileName)
        {
            using (var context = CreateContext())
            {
                var document = new Document
                {
                    SubmissionId = submissionId,
                    FilePath = filePath,
                    PageType = pageType,
                    FileName = fileName,
                    CreatedAt = DateTime.Now
                };
                context.Documents.Add(document);
                await context.SaveChangesAsync();
            }
        }

        public async Task SaveFieldAsync(int submissionId, string fieldName, string fieldValue, string fieldType)
        {
            using (var context = CreateContext())
            {
                var field = new Field
                {
                    SubmissionId = submissionId,
                    FieldName = fieldName,
                    FieldValue = fieldValue,
                    FieldType = fieldType,
                    CreatedAt = DateTime.Now
                };
                context.Fields.Add(field);
                await context.SaveChangesAsync();
            }
        }

        public async Task<SubmissionDetails> GetSubmissionDetailsAsync(string requestGuid)
        {
            using (var context = CreateContext())
            {
                var submission = await context.Submissions
                    .Include(s => s.Group)
                    .Include(s => s.Documents)
                    .Include(s => s.Fields)
                    .FirstOrDefaultAsync(s => s.RequestGuid == requestGuid);

                if (submission == null)
                    return null;

                return new SubmissionDetails
                {
                    Submission = submission,
                    GroupName = submission.Group?.GroupName,
                    Documents = submission.Documents.ToList(),
                    Fields = submission.Fields.ToList()
                };
            }
        }

        public async Task<int> SaveVerificationResponseAsync(Core.Entities.VerificationResponse verificationResponse, string requestGuid)
        {
            using (var context = CreateContext())
            {
                // Map VerificationResponse
                var efVerificationResponse = new Data.VerificationResponse
                {
                    Status = verificationResponse.Status,
                    ExecutionDate = verificationResponse.ExecutionDate,
                    ErrorMessage = verificationResponse.ErrorMessage
                };

                // Map Batch
                if (verificationResponse.Batch != null)
                {
                    var efBatch = new Batch
                    {
                        Name = verificationResponse.Batch.Name,
                        CreationDate = verificationResponse.Batch.CreationDate,
                        CloseDate = verificationResponse.Batch.CloseDate
                    };

                    // Map BatchClass
                    if (verificationResponse.Batch.BatchClass != null)
                    {
                        var existingBatchClass = await context.BatchClasses
                            .FirstOrDefaultAsync(bc => bc.Name == verificationResponse.Batch.BatchClass.Name);
                        if (existingBatchClass == null)
                        {
                            efBatch.BatchClass = new BatchClass { Name = verificationResponse.Batch.BatchClass.Name };
                        }
                        else
                        {
                            efBatch.BatchClassId = existingBatchClass.BatchClassId;
                        }
                    }

                    // Map BatchFields
                    efBatch.BatchFields = verificationResponse.Batch.BatchFields?.Select(bf => new BatchField
                    {
                        Name = bf.Name,
                        Value = bf.Value,
                        Confidence = bf.Confidence
                    }).ToList() ?? new List<BatchField>();

                    // Map BatchStates
                    efBatch.BatchStates = verificationResponse.Batch.BatchStates?.Select(bs => new BatchState
                    {
                        Value = bs.Value,
                        TrackDate = bs.TrackDate,
                        Workstation = bs.Workstation
                    }).ToList() ?? new List<BatchState>();

                    // Map Documents
                    efBatch.VerificationDocuments = verificationResponse.Batch.Documents?.Select(doc => new VerificationDocument
                    {
                        Name = doc.Name,
                        // Map DocumentClass
                        DocumentClass = doc.DocumentClass != null ? new VerificationDocumentClass { Name = doc.DocumentClass.Name } : null,
                        // Map Pages
                        Pages = doc.Pages?.Select(p => new Page
                        {
                            FileName = p.FileName,
                            Sections = p.Sections != null ? JsonSerializer.Serialize(p.Sections) : null,
                            PageTypes = p.PageTypes?.Select(pt => new PageType
                            {
                                Name = pt.Name,
                                Confidence = pt.Confidence
                            }).ToList() ?? new List<PageType>()
                        }).ToList() ?? new List<Page>(),
                        // Map DocumentFields
                        DocumentFields = doc.DocumentFields?.Select(df =>
                        {
                            try
                            {
                                var field = df as dynamic;
                                return new DocumentField
                                {
                                    Name = field?.Name?.ToString() ?? "Unknown",
                                    Value = field?.Value?.ToString(),
                                    Confidence = field?.Confidence 
                                };
                            }
                            catch
                            {
                                // Fallback for malformed fields
                                return new DocumentField
                                {
                                    Name = "Unknown",
                                    Value = JsonSerializer.Serialize(df),
                                    Confidence = null
                                };
                            }
                        }).ToList() ?? new List<DocumentField>(),
                        // Map Signatures
                        Signatures = doc.Signatures?.Select(s => new Signature
                        {
                            SignatureData = JsonSerializer.Serialize(s)
                        }).ToList() ?? new List<Signature>()
                    }).ToList() ?? new List<VerificationDocument>();

                    efVerificationResponse.Batch = efBatch;
                }

                context.VerificationResponses.Add(efVerificationResponse);
                await context.SaveChangesAsync();
                return efVerificationResponse.VerificationResponseId;
            }
        }

        public async Task<bool> UpdateCheckedGuidAsync(string requestGuid)
        {
            using (var context = CreateContext())
            {
                var submission = await context.Submissions
                    .FirstOrDefaultAsync(s => s.RequestGuid == requestGuid);

                if (submission == null)
                {
                    return false; // Submission not found
                }

                submission.CheckedGuid = true;
                await context.SaveChangesAsync();
                return true; // Update successful
            }
        }

        public async Task<List<string>> GetUncheckedRequestGuidsAsync()
        {
            using (var context = CreateContext())
            {
                return await context.Submissions
                    .Where(s => !s.CheckedGuid)
                    .Select(s => s.RequestGuid)
                    .ToListAsync();
            }
        }

        public async Task<List<VerificationResponse>> GetAllVerificationResponses()
        {
            using (var context = CreateContext())
            {
                var efVerificationResponses = await context.VerificationResponses
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.BatchClass)
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.BatchFields)
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.BatchStates)
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.VerificationDocuments)
                    //        .ThenInclude(vd => vd.DocumentClass)
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.VerificationDocuments)
                    //        .ThenInclude(vd => vd.DocumentFields)
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.VerificationDocuments)
                    //        .ThenInclude(vd => vd.Signatures)
                    //.Include(vr => vr.Batch)
                    //    .ThenInclude(b => b.VerificationDocuments)
                    //        .ThenInclude(vd => vd.Pages)
                    //            .ThenInclude(p => p.PageTypes)
                    .ToListAsync();

                return efVerificationResponses;
                //return efVerificationResponses.Select(efVerificationResponse => new VerificationResponse
                //{
                //    Status = efVerificationResponse.Status,
                //    ExecutionDate = efVerificationResponse.ExecutionDate,
                //    ErrorMessage = efVerificationResponse.ErrorMessage,
                //    Batch = efVerificationResponse.Batch != null ? new Batch
                //    {
                //        BatchId = efVerificationResponse.Batch.BatchId,
                //        Name = efVerificationResponse.Batch.Name,
                //        CreationDate = efVerificationResponse.Batch.CreationDate,
                //        CloseDate = efVerificationResponse.Batch.CloseDate,
                //        BatchClass = efVerificationResponse.Batch.BatchClass != null
                //            ? new BatchClass { Name = efVerificationResponse.Batch.BatchClass.Name }
                //            : null,
                //        BatchFields = efVerificationResponse.Batch.BatchFields?.Select(bf => new BatchField
                //        {
                //            Name = bf.Name,
                //            Value = bf.Value,
                //            Confidence = (float)bf.Confidence
                //        }).ToList(),
                //        BatchStates = efVerificationResponse.Batch.BatchStates?.Select(bs => new BatchState
                //        {
                //            Value = bs.Value,
                //            TrackDate = bs.TrackDate,
                //            Workstation = bs.Workstation
                //        }).ToList(),
                //        VerificationDocuments = efVerificationResponse.Batch.VerificationDocuments?.Select(vd => new VerificationDocument
                //        {
                //            Name = vd.Name,
                //            DocumentClass = vd.DocumentClass != null
                //                ? new VerificationDocumentClass { Name = vd.DocumentClass.Name }
                //                : null,
                //            DocumentFields = (ICollection<DocumentField>)(vd.DocumentFields?.Select(df => (object)new
                //            {
                //                Name = df.Name,
                //                Value = df.Value,
                //                Confidence = df.Confidence
                //            }).ToList()),
                //            Signatures = (ICollection<Signature>)(vd.Signatures?.Select(s => JsonSerializer.Deserialize<object>(s.SignatureData)).ToList()),
                //            Pages = vd.Pages?.Select(p => new Page
                //            {
                //                FileName = p.FileName,
                //                Sections = (string)(p.Sections != null ? JsonSerializer.Deserialize<object>(p.Sections) : null),
                //                PageTypes = p.PageTypes?.Select(pt => new PageType
                //                {
                //                    Name = pt.Name,
                //                    Confidence = (float)pt.Confidence
                //                }).ToList()
                //            }).ToList()
                //        }).ToList()
                //    } : null
                //}).ToList();
            }
        }
    }
}