﻿namespace SimpleTextRedactor
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.fldFilePath = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnOpenFile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.numFont = new System.Windows.Forms.NumericUpDown();
			this.fldContent = new System.Windows.Forms.TextBox();
			this.btnSaveFile = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblSymbolCount = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Choise file";
			// 
			// fldFilePath
			// 
			this.fldFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fldFilePath.Location = new System.Drawing.Point(75, 13);
			this.fldFilePath.Name = "fldFilePath";
			this.fldFilePath.Size = new System.Drawing.Size(643, 20);
			this.fldFilePath.TabIndex = 1;
			// 
			// btnSelect
			// 
			this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelect.Location = new System.Drawing.Point(736, 13);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			// 
			// btnOpenFile
			// 
			this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenFile.Location = new System.Drawing.Point(817, 13);
			this.btnOpenFile.Name = "btnOpenFile";
			this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
			this.btnOpenFile.TabIndex = 3;
			this.btnOpenFile.Text = "Open";
			this.btnOpenFile.UseVisualStyleBackColor = true;
			this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(28, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Font";
			// 
			// numFont
			// 
			this.numFont.Location = new System.Drawing.Point(75, 45);
			this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
			this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
			this.numFont.Name = "numFont";
			this.numFont.Size = new System.Drawing.Size(120, 20);
			this.numFont.TabIndex = 5;
			this.numFont.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
			// 
			// fldContent
			// 
			this.fldContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fldContent.Location = new System.Drawing.Point(16, 76);
			this.fldContent.Multiline = true;
			this.fldContent.Name = "fldContent";
			this.fldContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.fldContent.Size = new System.Drawing.Size(876, 476);
			this.fldContent.TabIndex = 6;
			// 
			// btnSaveFile
			// 
			this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSaveFile.Location = new System.Drawing.Point(817, 559);
			this.btnSaveFile.Name = "btnSaveFile";
			this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
			this.btnSaveFile.TabIndex = 7;
			this.btnSaveFile.Text = "Save";
			this.btnSaveFile.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblSymbolCount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 589);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(903, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
			this.toolStripStatusLabel1.Text = "Count Symbol";
			// 
			// lblSymbolCount
			// 
			this.lblSymbolCount.Name = "lblSymbolCount";
			this.lblSymbolCount.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(903, 611);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnSaveFile);
			this.Controls.Add(this.fldContent);
			this.Controls.Add(this.numFont);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnOpenFile);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.fldFilePath);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Text Editor";
			((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox fldFilePath;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnOpenFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numFont;
		private System.Windows.Forms.TextBox fldContent;
		private System.Windows.Forms.Button btnSaveFile;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lblSymbolCount;
	}
}

