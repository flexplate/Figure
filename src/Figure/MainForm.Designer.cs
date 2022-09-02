﻿namespace Figure;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Typename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pattern = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Replacement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddTransformation = new System.Windows.Forms.ToolStripButton();
            this.RemoveTransformation = new System.Windows.Forms.ToolStripButton();
            this.Step = new System.Windows.Forms.ToolStripButton();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.textEditBox = new System.Windows.Forms.TextBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(1161, 502);
            this.splitContainer1.SplitterDistance = 387;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Typename,
            this.Pattern,
            this.Replacement});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(377, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // Typename
            // 
            this.Typename.HeaderText = "";
            this.Typename.Name = "Typename";
            // 
            // Pattern
            // 
            this.Pattern.HeaderText = "Pattern";
            this.Pattern.Name = "Pattern";
            // 
            // Replacement
            // 
            this.Replacement.HeaderText = "Replacement";
            this.Replacement.Name = "Replacement";
            // 
            // toolStrip1
            // 
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
            // 
            // textEditBox
            // 
            this.textEditBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEditBox.Location = new System.Drawing.Point(0, 0);
            this.textEditBox.Multiline = true;
            this.textEditBox.Name = "textEditBox";
            this.textEditBox.Size = new System.Drawing.Size(766, 498);
            this.textEditBox.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1161, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
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
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveToolStripMenuItem.Text = "&Save Text File";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.saveAsToolStripMenuItem.Text = "Save Text File &As...";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private SplitContainer splitContainer1;
    private TextBox textEditBox;
    private DataGridView dataGridView1;
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
    private DataGridViewTextBoxColumn Typename;
    private DataGridViewTextBoxColumn Pattern;
    private DataGridViewTextBoxColumn Replacement;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem aboutToolStripMenuItem;
}