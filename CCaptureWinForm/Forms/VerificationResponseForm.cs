using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CCaptureWinForm.Core.Entities;

namespace VerificationResponseViewer
{
    public partial class VerificationResponseForm : Form
    {
        private object _selectedObject;
        private List<VerificationResponse> _verificationResponses;
        private ComboBox comboBoxResponses;
        private TextBox searchBox;
        private TextBox filterTextBox;

        public VerificationResponseForm(List<VerificationResponse> verificationResponses)
        {
            _verificationResponses = verificationResponses.OrderByDescending(vr => vr.ExecutionDate).ToList();
            InitializeComponent();
            InitializeComboBox();
            InitializeFilter();
            InitializeSearch();
            if (_verificationResponses.Any())
            {
                InitializeTreeView(_verificationResponses.First());
                InitializeDocumentsGrid(_verificationResponses.First());
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

            UpdateComboBoxItems(_verificationResponses);

            splitContainer.Panel1.Controls.Add(comboBoxResponses);
        }

        private void InitializeFilter()
        {
            filterTextBox = new TextBox
            {
                Dock = DockStyle.Top,
                PlaceholderText = "Filter by batch name or status"
            };
            filterTextBox.TextChanged += (s, e) =>
            {
                var filter = filterTextBox.Text.ToLower();
                var filteredResponses = _verificationResponses
                    //.Where(vr => vr.Batch.Name.ToLower().Contains(filter) || vr.Status.ToLower().Contains(filter))
                    .Where(vr => vr.Batch.Name.ToLower().Contains(filter))
                    .ToList();
                comboBoxResponses.Items.Clear();
                UpdateComboBoxItems(filteredResponses);
                if (filteredResponses.Any())
                {
                    comboBoxResponses.SelectedIndex = 0;
                    InitializeTreeView(filteredResponses.First());
                    InitializeDocumentsGrid(filteredResponses.First());
                }
            };
            splitContainer.Panel1.Controls.Add(filterTextBox);
        }

        private void InitializeSearch()
        {
            searchBox = new TextBox
            {
                Dock = DockStyle.Top,
                PlaceholderText = "Search tree view"
            };
            searchBox.TextChanged += (s, e) =>
            {
                var searchText = searchBox.Text.ToLower();
                foreach (TreeNode node in treeView.Nodes)
                {
                    SearchNodes(node, searchText);
                }
            };
            splitContainer.Panel1.Controls.Add(searchBox);
        }

        private void UpdateComboBoxItems(List<VerificationResponse> responses)
        {
            comboBoxResponses.Items.Clear();
            for (int i = 0; i < responses.Count; i++)
            {
                comboBoxResponses.Items.Add($"Response {i + 1} - Batch: {responses[i].Batch.Name} ({responses[i].ExecutionDate})");
            }
        }

        private void ComboBoxResponses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxResponses.SelectedIndex >= 0)
            {
                var verificationResponse = _verificationResponses[comboBoxResponses.SelectedIndex];
                InitializeTreeView(verificationResponse);
                InitializeDocumentsGrid(verificationResponse);
            }
        }

        private void InitializeTreeView(VerificationResponse verificationResponse)
        {
            treeView.Nodes.Clear();
            var rootNode = treeView.Nodes.Add($"VerificationResponse (Date: {verificationResponse.ExecutionDate})");
            rootNode.Tag = verificationResponse;
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;

            // Add basic verification response properties
            rootNode.Nodes.Add($"Status: {verificationResponse.Status}");
            rootNode.Nodes.Add($"Execution Date: {verificationResponse.ExecutionDate}");
            if (!string.IsNullOrEmpty(verificationResponse.ErrorMessage))
            {
                var errorNode = rootNode.Nodes.Add($"Error: {verificationResponse.ErrorMessage}");
                errorNode.ForeColor = Color.Red;
            }

            // Add Batch information
            if (verificationResponse.Batch != null)
            {
                var batchNode = rootNode.Nodes.Add($"Batch: {verificationResponse.Batch.Name}");
                batchNode.Tag = verificationResponse.Batch;
                batchNode.ImageIndex = 1;
                batchNode.SelectedImageIndex = 1;

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
            }

            treeView.ExpandAll();
        }

        private void InitializeDocumentsGrid(VerificationResponse verificationResponse)
        {
            documentsGrid.Rows.Clear();
            documentsGrid.Columns.Clear();

            documentsGrid.Columns.Add("Name", "Document Name");
            documentsGrid.Columns.Add("Class", "Document Class");
            documentsGrid.Columns.Add("FieldCount", "Field Count");
            documentsGrid.Columns.Add("SignatureCount", "Signature Count");
            documentsGrid.Columns.Add("PageCount", "Page Count");

            foreach (var doc in verificationResponse.Batch?.Documents ?? new List<VerificationDocument>())
            {
                documentsGrid.Rows.Add(
                    doc.Name,
                    doc.DocumentClass?.Name ?? "N/A",
                    doc.DocumentFields?.Count ?? 0,
                    doc.Signatures?.Count ?? 0,
                    doc.Pages?.Count ?? 0
                );
            }
        }

        private void SearchNodes(TreeNode node, string searchText)
        {
            node.BackColor = node.Text.ToLower().Contains(searchText) ? Color.Yellow : Color.White;
            foreach (TreeNode child in node.Nodes)
            {
                SearchNodes(child, searchText);
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            _selectedObject = e.Node.Tag;
            propertyGrid.SelectedObject = _selectedObject;
        }

        private void treeView_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            //if (e.Node.Tag is VerificationResponse vr)
            //{
            //    e.Node.ToolTipText = $"ID: {vr.VerificationResponseId}\nStatus: {vr.Status}\nDate: {vr.ExecutionDate}";
            //}
            //else 
            if (e.Node.Tag is Batch batch)
            {
                e.Node.ToolTipText = $"Name: {batch.Name}\nCreated: {batch.CreationDate}";
            }
        }

        private void propertyGrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            treeView.Refresh();
            documentsGrid.Refresh();
        }
    }
}