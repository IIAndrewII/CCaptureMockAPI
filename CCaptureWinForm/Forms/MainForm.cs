using CCaptureWinForm.Core.Interfaces;
using CCaptureWinForm.Infrastructure.Services;
using CCaptureWinForm.Presentation.ViewModels;
using Microsoft.Extensions.Configuration;
using System;
using System.Windows.Forms;

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

            // Open child forms on startup
            OpenSubmitForm();
            OpenCheckStatusForm();

            // Attach menu event handlers
            submitDocumentToolStripMenuItem.Click += (s, e) => OpenSubmitForm();
            checkStatusToolStripMenuItem.Click += (s, e) => OpenCheckStatusForm();
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
    }
}