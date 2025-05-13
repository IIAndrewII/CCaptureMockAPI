﻿using CCaptureWinForm.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using CCaptureWinForm.Core.DbEntities;

namespace CCaptureWinForm
{
    public partial class ResponsesHistoryForm : Form
    {
        private readonly IDatabaseService _databaseService;
        private readonly IConfiguration _configuration;
        private List<VerificationResponse> _verificationResponses;

        public ResponsesHistoryForm(IDatabaseService databaseService, IConfiguration configuration)
        {
            InitializeComponent();
            _databaseService = databaseService;
            _configuration = configuration;
            _verificationResponses = new List<VerificationResponse>();

            ConfigureDataGridViewResponses();
            ConfigureTreeView();
            AttachEventHandlers();
            LoadVerificationResponsesAsync();
        }

        private void ConfigureDataGridViewResponses()
        {
            dataGridViewResponses.AllowUserToAddRows = false;
            dataGridViewResponses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResponses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigureTreeView()
        {
            VerificationStatusTree.Nodes.Clear();
            VerificationStatusTree.Font = new Font("Segoe UI", 12F);
            VerificationStatusTree.ShowLines = true;
            VerificationStatusTree.ShowPlusMinus = true;
            VerificationStatusTree.CollapseAll();
        }

        private void AttachEventHandlers()
        {
            btnExpandAll.Click += btnExpandAll_Click;
            btnCollapseAll.Click += btnCollapseAll_Click;
            btnRefresh.Click += btnRefresh_Click;
            dataGridViewResponses.SelectionChanged += DataGridViewResponses_SelectionChanged;
        }

        private async void LoadVerificationResponsesAsync()
        {
            try
            {
                statusLabel.Text = "Loading verification responses...";
                statusLabel.ForeColor = Color.Blue;

                _verificationResponses = (await _databaseService.GetAllVerificationResponses()).ToList();
                dataGridViewResponses.DataSource = _verificationResponses.Select(r => new
                {
                    r.InteractionDateTime,
                    r.RequestGuid,
                    r.Status,
                    r.SourceSystem,
                    r.Channel,
                    r.SessionId,
                    r.MessageId,
                    r.UserId
                }).ToList();

                statusLabel.Text = "Verification responses loaded.";
                statusLabel.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"Error loading responses: {ex.Message}";
                statusLabel.ForeColor = Color.Red;
            }
        }

        private void btnExpandAll_Click(object sender, EventArgs e)
        {
            VerificationStatusTree.ExpandAll();
        }

        private void btnCollapseAll_Click(object sender, EventArgs e)
        {
            VerificationStatusTree.CollapseAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadVerificationResponsesAsync();
        }

        private void DataGridViewResponses_SelectionChanged(object sender, EventArgs e)
        {
            VerificationStatusTree.Nodes.Clear();

            if (dataGridViewResponses.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewResponses.SelectedRows[0];
                var requestGuid = selectedRow.Cells["RequestGuid"].Value?.ToString();

                if (!string.IsNullOrWhiteSpace(requestGuid))
                {
                    try
                    {
                        var response = _verificationResponses.FirstOrDefault(r => r.RequestGuid == requestGuid);

                        if (response != null && !string.IsNullOrEmpty(response.ResponseJson))
                        {
                            var deserializedResponse = JsonSerializer.Deserialize<VerificationResponse>(response.ResponseJson, new JsonSerializerOptions
                            {
                                PropertyNameCaseInsensitive = true
                            });

                            PopulateTreeView(deserializedResponse, requestGuid);
                        }
                        else
                        {
                            var requestNode = VerificationStatusTree.Nodes.Add($"Request Guid: {requestGuid}");
                            requestNode.ForeColor = Color.Black;
                            var errorNode = requestNode.Nodes.Add("Error: No JSON response available");
                            errorNode.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        var requestNode = VerificationStatusTree.Nodes.Add($"Request Guid: {requestGuid}");
                        requestNode.ForeColor = Color.Black;
                        var errorNode = requestNode.Nodes.Add($"Error: {ex.Message}");
                        errorNode.ForeColor = Color.Red;
                    }
                }
            }

            VerificationStatusTree.CollapseAll();
        }

        private void PopulateTreeView(VerificationResponse response, string requestGuid)
        {
            var requestNode = VerificationStatusTree.Nodes.Add($"Request Guid: {requestGuid}");
            requestNode.ForeColor = Color.Black;

            var statusNode = requestNode.Nodes.Add($"Status: {response.Status}");
            statusNode.ForeColor = response.Status == 0 ? Color.Green : Color.Red;

            var executionDateNode = requestNode.Nodes.Add($"Execution Date: {response.ExecutionDate:yyyy-MM-dd HH:mm:ss}");
            executionDateNode.ForeColor = Color.Black;

            if (!string.IsNullOrEmpty(response.ErrorMessage))
            {
                var errorNode = requestNode.Nodes.Add($"Error Message: {response.ErrorMessage}");
                errorNode.ForeColor = Color.Red;
            }

            if (response.Batch != null)
            {
                var batchNode = requestNode.Nodes.Add("Batch");
                batchNode.ForeColor = Color.Black;

                batchNode.Nodes.Add($"Id: {response.Batch.BatchId}").ForeColor = Color.Black;
                batchNode.Nodes.Add($"Name: {response.Batch.Name}").ForeColor = Color.Black;
                batchNode.Nodes.Add($"Creation Date: {response.Batch.CreationDate:yyyy-MM-dd HH:mm:ss}").ForeColor = Color.Black;
                batchNode.Nodes.Add($"Close Date: {response.Batch.CloseDate:yyyy-MM-dd HH:mm:ss}").ForeColor = Color.Black;

                if (response.Batch.BatchClass != null)
                {
                    var batchClassNode = batchNode.Nodes.Add($"Batch Class: {response.Batch.BatchClass.Name}");
                    batchClassNode.ForeColor = Color.Black;
                }

                if (response.Batch.BatchFields?.Any() == true)
                {
                    var fieldsNode = batchNode.Nodes.Add("Batch Fields");
                    fieldsNode.ForeColor = Color.Black;
                    foreach (var field in response.Batch.BatchFields)
                    {
                        var fieldNode = fieldsNode.Nodes.Add($"Field: {field.Name}");
                        fieldNode.ForeColor = Color.Black;
                        fieldNode.Nodes.Add($"Value: {field.Value}").ForeColor = Color.Black;
                        fieldNode.Nodes.Add($"Confidence: {field.Confidence}").ForeColor = Color.Black;
                    }
                }

                if (response.Batch.VerificationDocuments?.Any() == true)
                {
                    var docsNode = batchNode.Nodes.Add("Documents");
                    docsNode.ForeColor = Color.Black;
                    foreach (var doc in response.Batch.VerificationDocuments)
                    {
                        var docNode = docsNode.Nodes.Add($"Document: {doc.Name}");
                        docNode.ForeColor = Color.Black;

                        if (doc.DocumentClass != null)
                        {
                            docNode.Nodes.Add($"Document Class: {doc.DocumentClass.Name}").ForeColor = Color.Black;
                        }

                        if (doc.Pages?.Any() == true)
                        {
                            var pagesNode = docNode.Nodes.Add("Pages");
                            pagesNode.ForeColor = Color.Black;
                            foreach (var page in doc.Pages)
                            {
                                var pageNode = pagesNode.Nodes.Add($"Page: {page.FileName}");
                                pageNode.ForeColor = Color.Black;

                                if (page.PageTypes?.Any() == true)
                                {
                                    var pageTypesNode = pageNode.Nodes.Add("Page Types");
                                    pageTypesNode.ForeColor = Color.Black;
                                    foreach (var pageType in page.PageTypes)
                                    {
                                        var pageTypeNode = pageTypesNode.Nodes.Add($"Type: {pageType.Name}");
                                        pageTypeNode.ForeColor = Color.Black;
                                        pageTypeNode.Nodes.Add($"Confidence: {pageType.Confidence}").ForeColor = Color.Black;
                                    }
                                }
                            }
                        }
                    }
                }

                if (response.Batch.BatchStates?.Any() == true)
                {
                    var statesNode = batchNode.Nodes.Add("Batch States");
                    statesNode.ForeColor = Color.Black;
                    foreach (var state in response.Batch.BatchStates)
                    {
                        var stateNode = statesNode.Nodes.Add($"State: {state.Value}");
                        stateNode.ForeColor = Color.Black;
                        stateNode.Nodes.Add($"Track Date: {state.TrackDate:yyyy-MM-dd HH:mm:ss}").ForeColor = Color.Black;
                        stateNode.Nodes.Add($"Workstation: {state.Workstation}").ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}