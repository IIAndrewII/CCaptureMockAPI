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
    }
}