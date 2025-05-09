using System;
using System.Windows.Forms;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using CCaptureWinForm.Core.Entities;
using Microsoft.IdentityModel.Tokens;

namespace VerificationResponseViewer
{
    public partial class VerificationResponseForm : Form
    {
        private object _selectedObject;
        private List<VerificationResponse> _verificationResponses;
        private ComboBox comboBoxResponses;

        public VerificationResponseForm(List<VerificationResponse> verificationResponses)
        {
            _verificationResponses = verificationResponses;
            InitializeComponent();
            InitializeComboBox();
            if (verificationResponses.Any())
            {
                InitializeTreeView(verificationResponses.First());
                comboBoxResponses.SelectedIndex = 0;
            }
        }

        private void InitializeComboBox()
        {
            comboBoxResponses = new ComboBox
            {
                Dock = DockStyle.Top,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            comboBoxResponses.SelectedIndexChanged += ComboBoxResponses_SelectedIndexChanged;

            for (int i = 0; i < _verificationResponses.Count; i++)
            {
                comboBoxResponses.Items.Add($"Verification Response {i + 1} (Batch: {_verificationResponses[i].Batch.Name})");
            }

            splitContainer.Panel1.Controls.Add(comboBoxResponses);
            treeView.Top = comboBoxResponses.Height;
            treeView.Height -= comboBoxResponses.Height;
        }

        private void ComboBoxResponses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxResponses.SelectedIndex >= 0)
            {
                InitializeTreeView(_verificationResponses[comboBoxResponses.SelectedIndex]);
            }
        }

        private void InitializeTreeView(VerificationResponse verificationResponse)
        {
            treeView.Nodes.Clear();
            //var rootNode = treeView.Nodes.Add($"VerificationResponse (ID: {verificationResponse.VerificationResponseId})");
            var rootNode = treeView.Nodes.Add($"VerificationResponse (Date:  {verificationResponse.ExecutionDate})");
            rootNode.Tag = verificationResponse;

            // Add basic verification response properties
            rootNode.Nodes.Add($"Status: {verificationResponse.Status}");
            rootNode.Nodes.Add($"Execution Date: {verificationResponse.ExecutionDate}");
            if (!string.IsNullOrEmpty(verificationResponse.ErrorMessage))
                rootNode.Nodes.Add($"Error: {verificationResponse.ErrorMessage}");

            // Add Batch information
            if (verificationResponse.Batch != null)
            {
                var batchNode = rootNode.Nodes.Add($"Batch: {verificationResponse.Batch.Name}");
                batchNode.Tag = verificationResponse.Batch;

                batchNode.Nodes.Add($"Creation Date: {verificationResponse.Batch.CreationDate}");
                    batchNode.Nodes.Add($"Close Date: {verificationResponse.Batch.CloseDate}");

                // Batch Class
                if (verificationResponse.Batch.BatchClass != null)
                {
                    batchNode.Nodes.Add($"Batch Class: {verificationResponse.Batch.BatchClass.Name}");
                }

                // Batch Fields
                if (verificationResponse.Batch.BatchFields?.Count > 0)
                {
                    var fieldsNode = batchNode.Nodes.Add("Batch Fields");
                    foreach (var field in verificationResponse.Batch.BatchFields)
                    {
                        var fieldNode = fieldsNode.Nodes.Add($"{field.Name}: {field.Value} (Confidence: {field.Confidence})");
                        fieldNode.Tag = field;
                    }
                }

                // Batch States
                if (verificationResponse.Batch.BatchStates?.Count > 0)
                {
                    var statesNode = batchNode.Nodes.Add("Batch States");
                    foreach (var state in verificationResponse.Batch.BatchStates)
                    {
                        var stateNode = statesNode.Nodes.Add($"{state.Value} at {state.TrackDate} (Workstation: {state.Workstation})");
                        stateNode.Tag = state;
                    }
                }

                // Documents
                if (verificationResponse.Batch.Documents?.Count > 0)
                {
                    var docsNode = batchNode.Nodes.Add("Documents");
                    foreach (var doc in verificationResponse.Batch.Documents)
                    {
                        var docNode = docsNode.Nodes.Add($"Document: {doc.Name}");
                        docNode.Tag = doc;

                        if (doc.DocumentClass != null)
                            docNode.Nodes.Add($"Document Class: {doc.DocumentClass.Name}");

                        // Document Fields
                        if (doc.DocumentFields?.Count > 0)
                        {
                            var fieldsNode = docNode.Nodes.Add("Document Fields");
                            foreach (var field in doc.DocumentFields)
                            {
                                var fieldNode = fieldsNode.Nodes.Add($"{field}");
                                fieldNode.Tag = field;
                            }
                        }

                        // Signatures
                        if (doc.Signatures?.Count > 0)
                        {
                            var sigNode = docNode.Nodes.Add("Signatures");
                            foreach (var sig in doc.Signatures)
                            {
                                var sigNodeItem = sigNode.Nodes.Add("Signature");
                                sigNodeItem.Tag = sig;
                            }
                        }

                        // Pages
                        if (doc.Pages?.Count > 0)
                        {
                            var pagesNode = docNode.Nodes.Add("Pages");
                            foreach (var page in doc.Pages)
                            {
                                var pageNode = pagesNode.Nodes.Add($"Page: {page.FileName}");
                                pageNode.Tag = page;

                                if (page.Sections is string sections && !string.IsNullOrEmpty(sections))
                                {
                                    pageNode.Nodes.Add("Sections: JSON Data");
                                }

                                if (page.PageTypes?.Count > 0)
                                {
                                    var typesNode = pageNode.Nodes.Add("Page Types");
                                    foreach (var type in page.PageTypes)
                                    {
                                        var typeNode = typesNode.Nodes.Add($"{type.Name} (Confidence: {type.Confidence})");
                                        typeNode.Tag = type;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            treeView.ExpandAll();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedObject = e.Node.Tag;
            propertyGrid.SelectedObject = _selectedObject;
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            treeView.Refresh();
        }
    }
}