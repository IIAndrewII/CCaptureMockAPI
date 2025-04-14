using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace CCaptureWinForm.Presentation
{
    public class VerificationStatusViewer : UserControl
    {
        private TreeView _treeView;
        private Button _btnCollapseAll;
        private Button _btnExpandAll;
        private Button _btnExportJson;
        private string _jsonResponse;

        public VerificationStatusViewer()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            _treeView = new TreeView
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10F),
                BorderStyle = BorderStyle.FixedSingle,
                ItemHeight = 25
            };
            _treeView.NodeMouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                    _treeView.SelectedNode = e.Node;
                    var menu = new ContextMenuStrip();
                    menu.Items.Add("Copy Text", null, (s2, e2) => Clipboard.SetText(e.Node.Text));
                    menu.Show(_treeView, e.Location);
                }
            };

            var buttonPanel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            _btnCollapseAll = new Button
            {
                Text = "Collapse All",
                Width = 100,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                Dock = DockStyle.Left
            };
            _btnCollapseAll.Click += (s, e) => CollapseAllNodes();

            _btnExpandAll = new Button
            {
                Text = "Expand All",
                Width = 100,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                Dock = DockStyle.Left
            };
            _btnExpandAll.Click += (s, e) => ExpandAllNodes();

            _btnExportJson = new Button
            {
                Text = "Export JSON",
                Width = 100,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                Dock = DockStyle.Right
            };
            _btnExportJson.Click += (s, e) => ExportToJson();

            buttonPanel.Controls.AddRange(new Control[] { _btnCollapseAll, _btnExpandAll, _btnExportJson });
            Controls.AddRange(new Control[] { _treeView, buttonPanel });
        }

        public void DisplayResults(string jsonResponse)
        {
            _jsonResponse = jsonResponse;
            _treeView.Nodes.Clear();

            try
            {
                var jsonDocument = JsonDocument.Parse(jsonResponse);
                var rootNode = _treeView.Nodes.Add("Verification Results");

                var batchNode = rootNode.Nodes.Add("Batch Information");
                AddBatchDetails(batchNode, jsonDocument.RootElement.GetProperty("Batch"));

                rootNode.Nodes.Add($"Status: {jsonDocument.RootElement.GetProperty("Status").GetInt32()}");
                rootNode.Nodes.Add($"Execution Date: {jsonDocument.RootElement.GetProperty("ExecutionDate").GetString()}");

                rootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error parsing response: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddBatchDetails(TreeNode parentNode, JsonElement batchElement)
        {
            parentNode.Nodes.Add($"ID: {batchElement.GetProperty("Id").GetInt32()}");
            parentNode.Nodes.Add($"Name: {batchElement.GetProperty("Name").GetString()}");
            parentNode.Nodes.Add($"Creation Date: {batchElement.GetProperty("CreationDate").GetString()}");
            parentNode.Nodes.Add($"Close Date: {batchElement.GetProperty("CloseDate").GetString()}");

            var batchClassNode = parentNode.Nodes.Add("Batch Class");
            batchClassNode.Nodes.Add($"Name: {batchElement.GetProperty("BatchClass").GetProperty("Name").GetString()}");

            var fieldsNode = parentNode.Nodes.Add("Batch Fields");
            foreach (var field in batchElement.GetProperty("BatchFields").EnumerateArray())
            {
                fieldsNode.Nodes.Add($"{field.GetProperty("Name").GetString()}: {field.GetProperty("Value").GetString()} (Confidence: {field.GetProperty("Confidence").GetDouble():P0})");
            }

            var documentsNode = parentNode.Nodes.Add("Documents");
            foreach (var doc in batchElement.GetProperty("Documents").EnumerateArray())
            {
                var docNode = documentsNode.Nodes.Add($"Document: {doc.GetProperty("Name").GetString()}");
                docNode.Nodes.Add($"Class: {doc.GetProperty("DocumentClass").GetProperty("Name").GetString()}");

                var pagesNode = docNode.Nodes.Add("Pages");
                foreach (var page in doc.GetProperty("Pages").EnumerateArray())
                {
                    var pageNode = pagesNode.Nodes.Add($"Page: {page.GetProperty("FileName").GetString()}");
                    var typesNode = pageNode.Nodes.Add("Page Types");
                    foreach (var type in page.GetProperty("PageTypes").EnumerateArray())
                    {
                        typesNode.Nodes.Add($"{type.GetProperty("Name").GetString()} (Confidence: {type.GetProperty("Confidence").GetDouble():P1})");
                    }
                }
            }

            var statesNode = parentNode.Nodes.Add("Processing States");
            foreach (var state in batchElement.GetProperty("BatchStates").EnumerateArray())
            {
                statesNode.Nodes.Add($"{state.GetProperty("Value").GetString()} at {state.GetProperty("TrackDate").GetString()} (Workstation: {state.GetProperty("Workstation").GetString()})");
            }
        }

        private void CollapseAllNodes()
        {
            foreach (TreeNode node in _treeView.Nodes)
            {
                node.Collapse();
            }
        }

        private void ExpandAllNodes()
        {
            foreach (TreeNode node in _treeView.Nodes)
            {
                node.ExpandAll();
            }
        }

        private void ExportToJson()
        {
            using var saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                Title = "Save verification results"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (!string.IsNullOrWhiteSpace(_jsonResponse))
                    {
                        File.WriteAllText(saveFileDialog.FileName, _jsonResponse);
                        MessageBox.Show("Results exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No data available to export.", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error exporting JSON: {ex.Message}", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}