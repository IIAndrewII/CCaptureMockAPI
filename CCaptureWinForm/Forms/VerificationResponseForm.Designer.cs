namespace VerificationResponseViewer
{
    partial class VerificationResponseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.treeView = new System.Windows.Forms.TreeView();
            this.propertyGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.documentsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentsGrid)).BeginInit();
            this.SuspendLayout();

            // treeView
            this.treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView.Location = new System.Drawing.Point(0, 90);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(400, 510);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView_NodeMouseHover);

            // ImageList for treeView icons
            this.treeView.ImageList = new ImageList(this.components);
            this.treeView.ImageList.Images.Add("Root", System.Drawing.SystemIcons.Information.ToBitmap());
            this.treeView.ImageList.Images.Add("Batch", System.Drawing.SystemIcons.Application.ToBitmap());

            // propertyGrid
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.Size = new System.Drawing.Size(400, 600);
            this.propertyGrid.TabIndex = 1;
            this.propertyGrid.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.propertyGrid_PropertyValueChanged);

            // documentsGrid
            this.documentsGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.documentsGrid.Location = new System.Drawing.Point(0, 0);
            this.documentsGrid.Name = "documentsGrid";
            this.documentsGrid.Size = new System.Drawing.Size(400, 200);
            this.documentsGrid.TabIndex = 2;
            this.documentsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.documentsGrid.ReadOnly = true;

            // splitContainer
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Panel1.Controls.Add(this.treeView);
            this.splitContainer.Panel1.Controls.Add(this.documentsGrid);
            this.splitContainer.Panel2.Controls.Add(this.propertyGrid);
            this.splitContainer.Size = new System.Drawing.Size(800, 600);
            this.splitContainer.SplitterDistance = 400;
            this.splitContainer.TabIndex = 3;

            // VerificationResponseForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.splitContainer);
            this.Name = "VerificationResponseForm";
            this.Text = "Verification Response Viewer";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.PropertyGrid propertyGrid;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.DataGridView documentsGrid;
    }
}