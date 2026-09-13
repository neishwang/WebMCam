namespace WebMCam
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            this.labelFFmpegPath = new System.Windows.Forms.Label();
            this.textBoxFFmpegPath = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.tablePath = new System.Windows.Forms.TableLayoutPanel();
            this.labelFFmpegArguments = new System.Windows.Forms.Label();
            this.textBoxFFmpegArguments = new System.Windows.Forms.TextBox();
            this.labelImageFormat = new System.Windows.Forms.Label();
            this.comboBoxImageFormat = new System.Windows.Forms.ComboBox();
            this.checkBoxAltWindowTracking = new System.Windows.Forms.CheckBox();
            this.checkBoxRememberSize = new System.Windows.Forms.CheckBox();
            this.buttonResetArguments = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tableOptions = new System.Windows.Forms.TableLayoutPanel();
            this.tablePath.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableOptions.SuspendLayout();
            this.SuspendLayout();
            //
            // labelFFmpegPath
            //
            this.labelFFmpegPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFFmpegPath.AutoSize = true;
            this.labelFFmpegPath.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.labelFFmpegPath.Name = "labelFFmpegPath";
            this.labelFFmpegPath.TabIndex = 0;
            this.labelFFmpegPath.Text = "FFmpeg Path:";
            //
            // textBoxFFmpegPath
            //
            this.textBoxFFmpegPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFFmpegPath.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFFmpegPath.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.textBoxFFmpegPath.Name = "textBoxFFmpegPath";
            this.textBoxFFmpegPath.TabIndex = 1;
            this.textBoxFFmpegPath.WordWrap = false;
            //
            // buttonBrowse
            //
            this.buttonBrowse.AutoSize = true;
            this.buttonBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Padding = new System.Windows.Forms.Padding(12, 2, 12, 2);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            //
            // tablePath
            //
            this.tablePath.AutoSize = true;
            this.tablePath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tablePath.ColumnCount = 2;
            this.tablePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePath.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tablePath.Controls.Add(this.textBoxFFmpegPath, 0, 0);
            this.tablePath.Controls.Add(this.buttonBrowse, 1, 0);
            this.tablePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePath.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tablePath.Name = "tablePath";
            this.tablePath.RowCount = 1;
            this.tablePath.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tablePath.TabIndex = 1;
            //
            // labelFFmpegArguments
            //
            this.labelFFmpegArguments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFFmpegArguments.AutoSize = true;
            this.labelFFmpegArguments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.labelFFmpegArguments.Name = "labelFFmpegArguments";
            this.labelFFmpegArguments.TabIndex = 2;
            this.labelFFmpegArguments.Text = "FFmpeg Arguments:";
            //
            // textBoxFFmpegArguments
            //
            this.textBoxFFmpegArguments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFFmpegArguments.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFFmpegArguments.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.textBoxFFmpegArguments.Multiline = true;
            this.textBoxFFmpegArguments.Name = "textBoxFFmpegArguments";
            this.textBoxFFmpegArguments.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxFFmpegArguments.Size = new System.Drawing.Size(100, 52);
            this.textBoxFFmpegArguments.TabIndex = 3;
            this.textBoxFFmpegArguments.WordWrap = false;
            //
            // labelImageFormat
            //
            this.labelImageFormat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelImageFormat.AutoSize = true;
            this.labelImageFormat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.labelImageFormat.Name = "labelImageFormat";
            this.labelImageFormat.TabIndex = 4;
            this.labelImageFormat.Text = "Image Format:";
            //
            // comboBoxImageFormat
            //
            this.comboBoxImageFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImageFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxImageFormat.FormattingEnabled = true;
            this.comboBoxImageFormat.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "JPG",
            "GIF"});
            this.comboBoxImageFormat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.comboBoxImageFormat.Name = "comboBoxImageFormat";
            this.comboBoxImageFormat.TabIndex = 5;
            //
            // checkBoxAltWindowTracking
            //
            this.checkBoxAltWindowTracking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAltWindowTracking.AutoSize = true;
            this.checkBoxAltWindowTracking.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.checkBoxAltWindowTracking.Name = "checkBoxAltWindowTracking";
            this.checkBoxAltWindowTracking.TabIndex = 6;
            this.checkBoxAltWindowTracking.Text = "Alternative window tracking method";
            this.checkBoxAltWindowTracking.UseVisualStyleBackColor = true;
            //
            // checkBoxRememberSize
            //
            this.checkBoxRememberSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxRememberSize.AutoSize = true;
            this.checkBoxRememberSize.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxRememberSize.Name = "checkBoxRememberSize";
            this.checkBoxRememberSize.TabIndex = 7;
            this.checkBoxRememberSize.Text = "Remember window size";
            this.checkBoxRememberSize.UseVisualStyleBackColor = true;
            //
            // buttonResetArguments
            //
            this.buttonResetArguments.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonResetArguments.AutoSize = true;
            this.buttonResetArguments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonResetArguments.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonResetArguments.Margin = new System.Windows.Forms.Padding(0);
            this.buttonResetArguments.Name = "buttonResetArguments";
            this.buttonResetArguments.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.buttonResetArguments.TabIndex = 8;
            this.buttonResetArguments.Text = "Reset Arguments";
            this.buttonResetArguments.UseVisualStyleBackColor = true;
            this.buttonResetArguments.Click += new System.EventHandler(this.buttonResetArguments_Click);
            //
            // buttonSave
            //
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSave.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.buttonSave.MinimumSize = new System.Drawing.Size(100, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            //
            // panelButtons
            //
            // Docked to the bottom and auto-sizing, so the buttons are placed from the
            // bottom edge outwards and cannot be displaced by a rescale.
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.ColumnCount = 2;
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelButtons.Controls.Add(this.buttonResetArguments, 0, 0);
            this.panelButtons.Controls.Add(this.buttonSave, 1, 0);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(12, 10, 12, 12);
            this.panelButtons.RowCount = 1;
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.panelButtons.TabIndex = 1;
            //
            // tableOptions
            //
            this.tableOptions.AutoSize = true;
            this.tableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableOptions.ColumnCount = 1;
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOptions.Controls.Add(this.labelFFmpegPath, 0, 0);
            this.tableOptions.Controls.Add(this.tablePath, 0, 1);
            this.tableOptions.Controls.Add(this.labelFFmpegArguments, 0, 2);
            this.tableOptions.Controls.Add(this.textBoxFFmpegArguments, 0, 3);
            this.tableOptions.Controls.Add(this.labelImageFormat, 0, 4);
            this.tableOptions.Controls.Add(this.comboBoxImageFormat, 0, 5);
            this.tableOptions.Controls.Add(this.checkBoxAltWindowTracking, 0, 6);
            this.tableOptions.Controls.Add(this.checkBoxRememberSize, 0, 7);
            this.tableOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOptions.Name = "tableOptions";
            this.tableOptions.Padding = new System.Windows.Forms.Padding(12, 12, 12, 0);
            this.tableOptions.RowCount = 8;
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableOptions.TabIndex = 0;
            //
            // FormOptions
            //
            this.AcceptButton = this.buttonSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 320);
            // Fill first so it receives what the bottom button strip leaves over.
            this.Controls.Add(this.tableOptions);
            this.Controls.Add(this.panelButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WebMCam Options";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.tablePath.ResumeLayout(false);
            this.tablePath.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.tableOptions.ResumeLayout(false);
            this.tableOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFFmpegArguments;
        private System.Windows.Forms.Label labelFFmpegArguments;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelFFmpegPath;
        private System.Windows.Forms.TextBox textBoxFFmpegPath;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelImageFormat;
        private System.Windows.Forms.ComboBox comboBoxImageFormat;
        private System.Windows.Forms.Button buttonResetArguments;
        private System.Windows.Forms.CheckBox checkBoxAltWindowTracking;
        private System.Windows.Forms.CheckBox checkBoxRememberSize;
        private System.Windows.Forms.TableLayoutPanel tableOptions;
        private System.Windows.Forms.TableLayoutPanel tablePath;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
    }
}
