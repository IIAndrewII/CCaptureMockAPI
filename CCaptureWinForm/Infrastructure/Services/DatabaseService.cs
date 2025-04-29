using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Data;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
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

        // public async Task<int> SaveVerificationResponseAsync(VerificationResponse verificationResponse, string requestGuid)
        //{
        //    using (var context = CreateContext())
        //    {
        //        // Map VerificationResponse
        //        var efVerificationResponse = new Data.VerificationResponse
        //        {
        //            Status = verificationResponse.Status,
        //            ExecutionDate = verificationResponse.ExecutionDate,
        //            ErrorMessage = verificationResponse.ErrorMessage
        //        };

        //        // Map Batch
        //        if (verificationResponse.Batch != null)
        //        {
        //            var efBatch = new Batch
        //            {
        //                Name = verificationResponse.Batch.Name,
        //                CreationDate = verificationResponse.Batch.CreationDate,
        //                CloseDate = verificationResponse.Batch.CloseDate
        //            };

        //            // Map BatchClass
        //            if (verificationResponse.Batch.BatchClass != null)
        //            {
        //                var existingBatchClass = await context.BatchClasses
        //                    .FirstOrDefaultAsync(bc => bc.Name == verificationResponse.Batch.BatchClass.Name);
        //                if (existingBatchClass == null)
        //                {
        //                    efBatch.BatchClass = new BatchClass { Name = verificationResponse.Batch.BatchClass.Name };
        //                }
        //                else
        //                {
        //                    efBatch.BatchClassId = existingBatchClass.BatchClassId;
        //                }
        //            }

        //            // Map BatchFields
        //            efBatch.BatchFields = verificationResponse.Batch.BatchFields?.Select(bf => new BatchField
        //            {
        //                Name = bf.Name,
        //                Value = bf.Value,
        //                Confidence = bf.Confidence
        //            }).ToList() ?? new List<BatchField>();

        //            // Map BatchStates
        //            efBatch.BatchStates = verificationResponse.Batch.BatchStates?.Select(bs => new BatchState
        //            {
        //                Value = bs.Value,
        //                TrackDate = bs.TrackDate,
        //                Workstation = bs.Workstation
        //            }).ToList() ?? new List<BatchState>();

        //            // Map Documents
        //            efBatch.Documents = verificationResponse.Batch.Documents?.Select(doc => new VerificationDocument
        //            {
        //                Name = doc.Name,
        //                // Map DocumentClass
        //                DocumentClass = doc.DocumentClass != null ? new VerificationDocumentClass { Name = doc.DocumentClass.Name } : null,
        //                // Map Pages
        //                Pages = doc.Pages?.Select(p => new Page
        //                {
        //                    FileName = p.FileName,
        //                    Sections = p.Sections != null ? JsonSerializer.Serialize(p.Sections) : null,
        //                    PageTypes = p.PageTypes?.Select(pt => new PageType
        //                    {
        //                        Name = pt.Name,
        //                        Confidence = pt.Confidence
        //                    }).ToList() ?? new List<PageType>()
        //                }).ToList() ?? new List<Page>(),
        //                // Map DocumentFields (assuming objects are key-value pairs with confidence)
        //                DocumentFields = doc.DocumentFields?.Select(df => 
        //                {
        //                    var dict = df as Dictionary<string, object>;
        //                    return new DocumentField
        //                    {
        //                        Name = dict?.ContainsKey("Name") == true ? dict["Name"].ToString() : "Unknown",
        //                        Value = dict?.ContainsKey("Value") == true ? dict["Value"].ToString() : null,
        //                        Confidence = dict?.ContainsKey("Confidence") == true && float.TryParse(dict["Confidence"].ToString(), out var conf) ? conf : null
        //                    };
        //                }).ToList() ?? new List<DocumentField>(),
        //                // Map Signatures (assuming objects are JSON-serializable)
        //                Signatures = doc.Signatures?.Select(s => new Signature
        //                {
        //                    SignatureData = JsonSerializer.Serialize(s)
        //                }).ToList() ?? new List<Signature>()
        //            }).ToList() ?? new List<VerificationDocument>();

        //            efVerificationResponse.Batch = efBatch;
        //        }

        //        context.VerificationResponses.Add(efVerificationResponse);
        //        await context.SaveChangesAsync();
        //        return efVerificationResponse.VerificationResponseId;
        //    }
        //}


    }
}