namespace Figure;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TransformationTable = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddTransformation = new System.Windows.Forms.ToolStripButton();
            this.RemoveTransformation = new System.Windows.Forms.ToolStripButton();
            this.Step = new System.Windows.Forms.ToolStripButton();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.textEditBox = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.MainMenuStart = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openTransformationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTransformationListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveTransformationListAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.MainMenuStep = new System.Windows.Forms.ToolStripButton();
            this.Typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Applied = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransformationTable)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textEditBox);
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 502);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TransformationTable, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 498);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // TransformationTable
            // 
            this.TransformationTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransformationTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Typename,
            this.Pattern,
            this.Replacement,
            this.Applied});
            this.tableLayoutPanel1.SetColumnSpan(this.TransformationTable, 2);
            this.TransformationTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransformationTable.Location = new System.Drawing.Point(3, 3);
            this.TransformationTable.Name = "TransformationTable";
            this.TransformationTable.RowTemplate.Height = 25;
            this.TransformationTable.Size = new System.Drawing.Size(377, 467);
            this.TransformationTable.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTransformation,
            this.RemoveTransformation,
            this.Step,
            this.Start});
            this.toolStrip1.Location = new System.Drawing.Point(0, 473);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(383, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddTransformation
            // 
            this.AddTransformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTransformation.Image = ((System.Drawing.Image)(resources.GetObject("AddTransformation.Image")));
            this.AddTransformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTransformation.Name = "AddTransformation";
            this.AddTransformation.Size = new System.Drawing.Size(23, 22);
            this.AddTransformation.Text = "Add";
            this.AddTransformation.Click += new System.EventHandler(this.AddTransformation_Click);
            // 
            // RemoveTransformation
            // 
            this.RemoveTransformation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveTransformation.Image = ((System.Drawing.Image)(resources.GetObject("RemoveTransformation.Image")));
            this.RemoveTransformation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveTransformation.Name = "RemoveTransformation";
            this.RemoveTransformation.Size = new System.Drawing.Size(23, 22);
            this.RemoveTransformation.Text = "Remove";
            this.RemoveTransformation.Click += new System.EventHandler(this.RemoveTransformation_Click);
            // 
            // Step
            // 
            this.Step.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Step.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Step.Image = ((System.Drawing.Image)(resources.GetObject("Step.Image")));
            this.Step.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(23, 22);
            this.Step.Text = "Step";
            this.Step.Click += new System.EventHandler(this.Step_Click);
            // 
            // Start
            // 
            this.Start.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(23, 22);
            this.Start.Text = "Start";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textEditBox
            // 
            this.textEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditBox.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textEditBox.Location = new System.Drawing.Point(0, 0);
            this.textEditBox.Multiline = true;
            this.textEditBox.Name = "textEditBox";
            this.textEditBox.Size = new System.Drawing.Size(766, 476);
            this.textEditBox.TabIndex = 0;
            this.textEditBox.TextChanged += new System.EventHandler(this.textEditBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Progress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 476);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Progress
            // 
            this.Progress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(200, 16);
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainMenuStart,
            this.MainMenuStep});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1161, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // MainMenuStart
            // 
            this.MainMenuStart.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuStart.Image")));
            this.MainMenuStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainMenuStart.Name = "MainMenuStart";
            this.MainMenuStart.Size = new System.Drawing.Size(51, 22);
            this.MainMenuStart.Text = "Start";
            this.MainMenuStart.Click += new System.EventHandler(this.Start_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1161, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.openTransformationListToolStripMenuItem,
            this.saveTransformationListToolStripMenuItem,
            this.saveTransformationListAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.openToolStripMenuItem.Text = "&Open Text File...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveToolStripMenuItem.Text = "&Save Text File";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveAsToolStripMenuItem.Text = "Save Text File &As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // openTransformationListToolStripMenuItem
            // 
            this.openTransformationListToolStripMenuItem.Name = "openTransformationListToolStripMenuItem";
            this.openTransformationListToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.openTransformationListToolStripMenuItem.Text = "Open &Transformation List...";
            // 
            // saveTransformationListToolStripMenuItem
            // 
            this.saveTransformationListToolStripMenuItem.Name = "saveTransformationListToolStripMenuItem";
            this.saveTransformationListToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveTransformationListToolStripMenuItem.Text = "Save Transformation List";
            // 
            // saveTransformationListAsToolStripMenuItem
            // 
            this.saveTransformationListAsToolStripMenuItem.Name = "saveTransformationListAsToolStripMenuItem";
            this.saveTransformationListAsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveTransformationListAsToolStripMenuItem.Text = "Save Transformation List As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(237, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // MainMenuStep
            // 
            this.MainMenuStep.Image = ((System.Drawing.Image)(resources.GetObject("MainMenuStep.Image")));
            this.MainMenuStep.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MainMenuStep.Name = "MainMenuStep";
            this.MainMenuStep.Size = new System.Drawing.Size(98, 22);
            this.MainMenuStep.Text = "Step Through";
            this.MainMenuStep.Click += new System.EventHandler(this.Step_Click);
            // 
            // Typename
            // 
            this.Typename.DataPropertyName = "TypeName";
            this.Typename.HeaderText = "";
            this.Typename.Name = "Typename";
            // 
            // Pattern
            // 
            this.Pattern.DataPropertyName = "Pattern";
            this.Pattern.HeaderText = "Pattern";
            this.Pattern.Name = "Pattern";
            // 
            // Replacement
            // 
            this.Replacement.DataPropertyName = "Replacement";
            this.Replacement.HeaderText = "Replacement";
            this.Replacement.Name = "Replacement";
            // 
            // Applied
            // 
            this.Applied.HeaderText = "Applied";
            this.Applied.Name = "Applied";
            this.Applied.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Figure";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransformationTable)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private SplitContainer splitContainer1;
    private TextBox textEditBox;
    private DataGridView TransformationTable;
    private TableLayoutPanel tableLayoutPanel1;
    private ToolStrip toolStrip1;
    private ToolStripButton AddTransformation;
    private ToolStripButton RemoveTransformation;
    private ToolStripButton Step;
    private ToolStripButton Start;
    private ToolStrip toolStrip2;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem newToolStripMenuItem;
    private ToolStripMenuItem openToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripMenuItem openTransformationListToolStripMenuItem;
    private ToolStripMenuItem saveTransformationListToolStripMenuItem;
    private ToolStripMenuItem saveTransformationListAsToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem exitToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripButton MainMenuStart;
    private StatusStrip statusStrip1;
    private ToolStripProgressBar Progress;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private ToolStripButton MainMenuStep;
    private DataGridViewTextBoxColumn Typename;
    private DataGridViewTextBoxColumn Pattern;
    private DataGridViewTextBoxColumn Replacement;
    private DataGridViewCheckBoxColumn Applied;
}
