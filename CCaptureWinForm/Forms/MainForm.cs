using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;
using VerificationResponseViewer;
using System.Linq;
using CCaptureWinForm.Core.ApiEntities;

namespace CCaptureWinForm
{
    public partial class MainForm : Form
    {
        private readonly IConfiguration _configuration;
        private readonly IApiDatabaseService _apiDatabaseService;
        private readonly IDatabaseService _databaseService;
        private readonly MainViewModel _viewModel;

        public MainForm(IApiDatabaseService apiDatabaseService, IDatabaseService databaseService, IConfiguration configuration)
        {
            _apiDatabaseService = apiDatabaseService;
            _databaseService = databaseService;
            _configuration = configuration;

            // Set the form to maximized state before initializing components
            this.WindowState = FormWindowState.Maximized;

            InitializeComponent();

            // Initialize MainViewModel
            var fileService = new FileService();
            var apiUrl = _configuration["ApiUrl"];
            if (string.IsNullOrEmpty(apiUrl))
            {
                throw new InvalidOperationException("ApiUrl is not configured in appsettings.json");
            }
            var apiService = new ApiService(apiUrl);
            _viewModel = new MainViewModel(apiService, fileService, _apiDatabaseService, _databaseService, _configuration);

            // Set up MDI
            this.IsMdiContainer = true;

            //// Open child forms on startup
            //OpenSubmitForm();
            //OpenCheckStatusForm();

            // Attach menu event handlers
            submitDocumentToolStripMenuItem.Click += (s, e) => OpenSubmitForm();
            checkStatusToolStripMenuItem.Click += (s, e) => OpenCheckStatusForm();
            viewVerificationResponsesToolStripMenuItem.Click += (s, e) => OpenVerificationResponseForm();
        }

        private void OpenSubmitForm()
        {
            var existingForm = this.MdiChildren.OfType<SubmitForm>().FirstOrDefault();
            if (existingForm == null)
            {
                var submitForm = new SubmitForm(_apiDatabaseService, _databaseService, _configuration, _viewModel)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                submitForm.Show();
            }
            else
            {
                existingForm.Activate();
            }
        }

        private void OpenCheckStatusForm()
        {
            var existingForm = this.MdiChildren.OfType<CheckStatusForm>().FirstOrDefault();
            if (existingForm == null)
            {
                var checkStatusForm = new CheckStatusForm(_apiDatabaseService, _databaseService, _configuration, _viewModel)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                checkStatusForm.Show();
            }
            else
            {
                existingForm.Activate();
            }
        }





        private static class VerificationResponseGenerator
        {
            public static List<VerificationResponse> GenerateDummyVerificationResponses(int count)
            {
                var responses = new List<VerificationResponse>();
                var random = new Random();

                for (int i = 0; i < count; i++)
                {
                    var batchId = 1000 + i;
                    var creationDate = DateTime.Now.AddMinutes(-random.Next(10, 100));
                    var closeDate = creationDate.AddMinutes(random.Next(1, 5));

                    var verificationResponse = new VerificationResponse
                    {
                        Status = 0,
                        ExecutionDate = closeDate.AddSeconds(random.Next(1, 60)),
                        ErrorMessage = random.Next(0, 10) < 2 ? "Sample Error " + i : null,
                        Batch = new Batch
                        {
                            Id = batchId,
                            Name = Guid.NewGuid().ToString(),
                            CreationDate = creationDate,
                            CloseDate = closeDate,
                            BatchClass = new BatchClass
                            {
                                Name = "ALLIANZ"
                            },
                            BatchFields = new List<BatchField>
                        {
                            new BatchField { Name = "NAME_IN", Value = "ALESSANDRO", Confidence = 0 },
                            new BatchField { Name = "SURNAME_IN", Value = "GAIA", Confidence = 0 },
                            new BatchField { Name = "CF_IN", Value = "GAILSN70P09E463H", Confidence = 0 },
                            new BatchField { Name = "NAME_OUT", Value = "ALESSANDRO", Confidence = 1 },
                            new BatchField { Name = "SURNAME_OUT", Value = "GAIA", Confidence = 1 },
                            new BatchField { Name = "EXP_DATE_OUT", Value = "2028/11/28", Confidence = 0 }
                        },
                            Documents = new List<VerificationDocument>
                        {
                            new VerificationDocument
                            {
                                Name = "pag1.png",
                                DocumentClass = new VerificationDocumentClass { Name = "CIE" },
                                Pages = new List<Page>
                                {
                                    new Page
                                    {
                                        FileName = "000001.png",
                                        PageTypes = new List<PageType>
                                        {
                                            new PageType { Name = "CIE Fronte", Confidence = 0.95180047f + (float)(random.NextDouble() * 0.01) }
                                        },
                                        Sections = null
                                    }
                                },
                                DocumentFields = new List<object>(),
                                Signatures = new List<object>()
                            },
                            new VerificationDocument
                            {
                                Name = "pag2.png",
                                DocumentClass = new VerificationDocumentClass { Name = "CIE" },
                                Pages = new List<Page>
                                {
                                    new Page
                                    {
                                        FileName = "000002.png",
                                        PageTypes = new List<PageType>
                                        {
                                            new PageType { Name = "CIE Retro", Confidence = 0.9265266f + (float)(random.NextDouble() * 0.01) }
                                        },
                                        Sections = null
                                    }
                                },
                                DocumentFields = new List<object>(),
                                Signatures = new List<object>()
                            }
                        },
                            BatchStates = new List<BatchState>
                        {
                            new BatchState { Value = "Start", TrackDate = creationDate, Workstation = "SPW-MSXIWEBSVB" },
                            new BatchState { Value = "Create", TrackDate = creationDate.AddSeconds(1), Workstation = "SPW-MSXIWEBSVB" },
                            new BatchState { Value = "OCR", TrackDate = creationDate.AddSeconds(2), Workstation = "SPW-MSXIWEBSVB" },
                            new BatchState { Value = "Expression Match", TrackDate = creationDate.AddSeconds(3), Workstation = "SPW-MSXIWEBSVB" },
                            new BatchState { Value = "Classification Page Types", TrackDate = creationDate.AddSeconds(4), Workstation = "SPW-MSXIWEBSVB" },
                            new BatchState { Value = "Fields Assignment", TrackDate = creationDate.AddSeconds(5), Workstation = "SPW-MSXIWEBSVB" },
                            new BatchState { Value = "Close", TrackDate = closeDate, Workstation = "SPW-MSXIWEBSVB" }
                        }
                        }
                    };

                    responses.Add(verificationResponse);
                }

                return responses;
            }
        }

        private void OpenVerificationResponseForm()
        {
            var existingForm = this.MdiChildren.OfType<VerificationResponseForm>().FirstOrDefault();
            if (existingForm == null)
            {
                var dummyResponses = VerificationResponseGenerator.GenerateDummyVerificationResponses(5); // Generate 5 dummy responses
                var verificationResponseForm = new VerificationResponseForm(dummyResponses)
                {
                    MdiParent = this,
                    WindowState = FormWindowState.Maximized
                };
                verificationResponseForm.Show();
            }
            else
            {
                existingForm.Activate();
            }
        }
    }
}