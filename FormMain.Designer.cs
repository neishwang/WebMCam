namespace WebMCam
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonToggle = new System.Windows.Forms.Button();
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.checkBoxDrawCursor = new System.Windows.Forms.CheckBox();
            this.numericUpDownFramerate = new System.Windows.Forms.NumericUpDown();
            this.labelFPS = new System.Windows.Forms.Label();
            this.buttonOptions = new System.Windows.Forms.Button();
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.linkGithub = new System.Windows.Forms.LinkLabel();
            this.timerRecord = new System.Windows.Forms.Timer(this.components);
            this.checkBoxCaptureAudio = new System.Windows.Forms.CheckBox();
            this.linkLabelFFmpeg = new System.Windows.Forms.LinkLabel();
            this.timerTracker = new System.Windows.Forms.Timer(this.components);
            this.buttonPause = new System.Windows.Forms.Button();
            this.checkBoxFollow = new System.Windows.Forms.CheckBox();
            this.timerFollow = new System.Windows.Forms.Timer(this.components);
            this.checkBoxAttach = new System.Windows.Forms.CheckBox();
            this.timerAttach = new System.Windows.Forms.Timer(this.components);
            this.linkHelp = new System.Windows.Forms.LinkLabel();
            this.buttonSizeSet = new System.Windows.Forms.Button();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.labelFollowHint = new System.Windows.Forms.Label();
            this.tableSidebar = new System.Windows.Forms.TableLayoutPanel();
            this.tableFramerate = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFramerate)).BeginInit();
            this.tableSidebar.SuspendLayout();
            this.tableFramerate.SuspendLayout();
            this.SuspendLayout();
            //
            // checkBoxTopMost
            //
            this.checkBoxTopMost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Checked = true;
            this.checkBoxTopMost.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTopMost.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxTopMost.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.TabIndex = 1;
            this.checkBoxTopMost.Text = "Always on Top";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            //
            // checkBoxDrawCursor
            //
            this.checkBoxDrawCursor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxDrawCursor.AutoSize = true;
            this.checkBoxDrawCursor.Checked = true;
            this.checkBoxDrawCursor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDrawCursor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxDrawCursor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBoxDrawCursor.Name = "checkBoxDrawCursor";
            this.checkBoxDrawCursor.TabIndex = 2;
            this.checkBoxDrawCursor.Text = "Draw Cursor";
            this.checkBoxDrawCursor.UseVisualStyleBackColor = true;
            //
            // checkBoxFollow
            //
            this.checkBoxFollow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxFollow.AutoSize = true;
            this.checkBoxFollow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFollow.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBoxFollow.Name = "checkBoxFollow";
            this.checkBoxFollow.TabIndex = 3;
            this.checkBoxFollow.Text = "Follow Cursor";
            this.checkBoxFollow.UseVisualStyleBackColor = true;
            this.checkBoxFollow.CheckedChanged += new System.EventHandler(this.checkBoxFollow_CheckedChanged);
            //
            // checkBoxCaptureAudio
            //
            this.checkBoxCaptureAudio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxCaptureAudio.AutoSize = true;
            this.checkBoxCaptureAudio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxCaptureAudio.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBoxCaptureAudio.Name = "checkBoxCaptureAudio";
            this.checkBoxCaptureAudio.TabIndex = 4;
            this.checkBoxCaptureAudio.Text = "Capture Audio";
            this.checkBoxCaptureAudio.UseVisualStyleBackColor = true;
            //
            // checkBoxAttach
            //
            this.checkBoxAttach.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxAttach.AutoSize = true;
            this.checkBoxAttach.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxAttach.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.checkBoxAttach.Name = "checkBoxAttach";
            this.checkBoxAttach.TabIndex = 5;
            this.checkBoxAttach.Text = "Attach Window";
            this.checkBoxAttach.UseVisualStyleBackColor = true;
            this.checkBoxAttach.CheckedChanged += new System.EventHandler(this.checkBoxAttach_CheckedChanged);
            //
            // labelFPS
            //
            this.labelFPS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelFPS.AutoSize = true;
            this.labelFPS.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.TabIndex = 6;
            this.labelFPS.Text = "FPS";
            //
            // numericUpDownFramerate
            //
            this.numericUpDownFramerate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownFramerate.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownFramerate.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFramerate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFramerate.Name = "numericUpDownFramerate";
            this.numericUpDownFramerate.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownFramerate.TabIndex = 7;
            this.numericUpDownFramerate.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            //
            // tableFramerate
            //
            this.tableFramerate.AutoSize = true;
            this.tableFramerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableFramerate.ColumnCount = 2;
            this.tableFramerate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableFramerate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableFramerate.Controls.Add(this.labelFPS, 0, 0);
            this.tableFramerate.Controls.Add(this.numericUpDownFramerate, 1, 0);
            this.tableFramerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFramerate.Margin = new System.Windows.Forms.Padding(0, 9, 0, 12);
            this.tableFramerate.Name = "tableFramerate";
            this.tableFramerate.RowCount = 1;
            this.tableFramerate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableFramerate.TabIndex = 6;
            //
            // buttonToggle
            //
            this.buttonToggle.AutoSize = true;
            this.buttonToggle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonToggle.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.buttonToggle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonToggle.FlatAppearance.BorderSize = 0;
            this.buttonToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.buttonToggle.TabIndex = 8;
            this.buttonToggle.Text = "Record";
            this.buttonToggle.UseVisualStyleBackColor = false;
            this.buttonToggle.Click += new System.EventHandler(this.buttonToggle_Click);
            //
            // buttonPause
            //
            this.buttonPause.AutoSize = true;
            this.buttonPause.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPause.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPause.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 205);
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.buttonPause.TabIndex = 9;
            this.buttonPause.Text = "Pause";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            //
            // buttonOptions
            //
            this.buttonOptions.AutoSize = true;
            this.buttonOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOptions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 200, 205);
            this.buttonOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.buttonOptions.TabIndex = 10;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            //
            // buttonWarning
            //
            this.buttonWarning.AutoSize = true;
            this.buttonWarning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonWarning.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonWarning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonWarning.FlatAppearance.BorderSize = 0;
            this.buttonWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWarning.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonWarning.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.buttonWarning.TabIndex = 11;
            this.buttonWarning.Text = "Warning!";
            this.buttonWarning.UseVisualStyleBackColor = false;
            this.buttonWarning.Visible = false;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            //
            // labelFollowHint
            //
            this.labelFollowHint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFollowHint.AutoSize = true;
            this.labelFollowHint.ForeColor = System.Drawing.Color.FromArgb(110, 110, 115);
            this.labelFollowHint.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.labelFollowHint.Name = "labelFollowHint";
            this.labelFollowHint.TabIndex = 12;
            this.labelFollowHint.Text = "Ctrl+F10\r\nto stop following";
            this.labelFollowHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelFollowHint.Visible = false;
            //
            // linkHelp
            //
            this.linkHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkHelp.AutoSize = true;
            this.linkHelp.Margin = new System.Windows.Forms.Padding(0, 8, 0, 4);
            this.linkHelp.Name = "linkHelp";
            this.linkHelp.TabIndex = 13;
            this.linkHelp.TabStop = true;
            this.linkHelp.Text = "Help";
            this.linkHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkHelp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkHelp_LinkClicked);
            //
            // linkLabelFFmpeg
            //
            this.linkLabelFFmpeg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelFFmpeg.AutoSize = true;
            this.linkLabelFFmpeg.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.linkLabelFFmpeg.Name = "linkLabelFFmpeg";
            this.linkLabelFFmpeg.TabIndex = 14;
            this.linkLabelFFmpeg.TabStop = true;
            this.linkLabelFFmpeg.Text = "FFmpeg";
            this.linkLabelFFmpeg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelFFmpeg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFFmpeg_LinkClicked);
            //
            // linkGithub
            //
            // Top, not None: the TableLayoutPanel hands its leftover vertical space to
            // the last row, and an unanchored control would float in the middle of it,
            // detached from the two links above.
            this.linkGithub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkGithub.AutoSize = true;
            this.linkGithub.Margin = new System.Windows.Forms.Padding(0);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.TabIndex = 15;
            this.linkGithub.TabStop = true;
            this.linkGithub.Text = "2.4.1";
            this.linkGithub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGithub_LinkClicked);
            //
            // tableSidebar
            //
            this.tableSidebar.AutoSize = true;
            this.tableSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableSidebar.ColumnCount = 1;
            this.tableSidebar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableSidebar.Controls.Add(this.checkBoxTopMost, 0, 0);
            this.tableSidebar.Controls.Add(this.checkBoxDrawCursor, 0, 1);
            this.tableSidebar.Controls.Add(this.checkBoxFollow, 0, 2);
            this.tableSidebar.Controls.Add(this.checkBoxCaptureAudio, 0, 3);
            this.tableSidebar.Controls.Add(this.checkBoxAttach, 0, 4);
            this.tableSidebar.Controls.Add(this.tableFramerate, 0, 5);
            this.tableSidebar.Controls.Add(this.buttonToggle, 0, 6);
            this.tableSidebar.Controls.Add(this.buttonPause, 0, 7);
            this.tableSidebar.Controls.Add(this.buttonOptions, 0, 8);
            this.tableSidebar.Controls.Add(this.buttonWarning, 0, 9);
            this.tableSidebar.Controls.Add(this.labelFollowHint, 0, 10);
            this.tableSidebar.Controls.Add(this.linkHelp, 0, 11);
            this.tableSidebar.Controls.Add(this.linkLabelFFmpeg, 0, 12);
            this.tableSidebar.Controls.Add(this.linkGithub, 0, 13);
            this.tableSidebar.BackColor = System.Drawing.Color.FromArgb(238, 240, 243);
            this.tableSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableSidebar.Margin = new System.Windows.Forms.Padding(0);
            this.tableSidebar.Name = "tableSidebar";
            this.tableSidebar.Padding = new System.Windows.Forms.Padding(14, 12, 14, 12);
            this.tableSidebar.RowCount = 14;
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tableSidebar.TabIndex = 0;
            //
            // displayBox
            //
            this.displayBox.BackColor = System.Drawing.Color.Fuchsia;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.displayBox.Name = "displayBox";
            this.displayBox.TabIndex = 0;
            this.displayBox.TabStop = false;
            //
            // buttonSizeSet
            //
            this.buttonSizeSet.AutoSize = true;
            this.buttonSizeSet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSizeSet.Name = "buttonSizeSet";
            this.buttonSizeSet.Padding = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.buttonSizeSet.TabIndex = 17;
            this.buttonSizeSet.Text = "Set";
            this.buttonSizeSet.UseVisualStyleBackColor = true;
            this.buttonSizeSet.Visible = false;
            this.buttonSizeSet.Click += new System.EventHandler(this.buttonSizeSet_Click);
            //
            // textBoxSize
            //
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(118, 20);
            this.textBoxSize.TabIndex = 16;
            this.textBoxSize.Visible = false;
            //
            // timerRecord
            //
            this.timerRecord.Tick += new System.EventHandler(this.timerRecord_Tick);
            //
            // timerTracker
            //
            this.timerTracker.Interval = 10;
            this.timerTracker.Tick += new System.EventHandler(this.FormMain_Move);
            //
            // timerFollow
            //
            this.timerFollow.Interval = 25;
            this.timerFollow.Tick += new System.EventHandler(this.timerFollow_Tick);
            //
            // timerAttach
            //
            this.timerAttach.Interval = 10;
            this.timerAttach.Tick += new System.EventHandler(this.timerAttach_Tick);
            //
            // FormMain
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(238, 240, 243);
            this.ClientSize = new System.Drawing.Size(525, 380);
            // Z-order matters here. Docking is resolved from the last control in the
            // collection backwards, so the sidebar (added last) claims the right edge
            // first and displayBox fills whatever is left. The floating sizer controls
            // are added first so they paint on top of the preview.
            this.Controls.Add(this.buttonSizeSet);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.tableSidebar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebMCam";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseClick);
            this.Move += new System.EventHandler(this.FormMain_Move);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFramerate)).EndInit();
            this.tableFramerate.ResumeLayout(false);
            this.tableFramerate.PerformLayout();
            this.tableSidebar.ResumeLayout(false);
            this.tableSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToggle;
        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.CheckBox checkBoxDrawCursor;
        private System.Windows.Forms.NumericUpDown numericUpDownFramerate;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
        private System.Windows.Forms.LinkLabel linkGithub;
        private System.Windows.Forms.Timer timerRecord;
        private System.Windows.Forms.CheckBox checkBoxCaptureAudio;
        private System.Windows.Forms.LinkLabel linkLabelFFmpeg;
        private System.Windows.Forms.Timer timerTracker;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.CheckBox checkBoxFollow;
        private System.Windows.Forms.Timer timerFollow;
        private System.Windows.Forms.CheckBox checkBoxAttach;
        private System.Windows.Forms.Timer timerAttach;
        private System.Windows.Forms.LinkLabel linkHelp;
        private System.Windows.Forms.Button buttonSizeSet;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.Button buttonWarning;
        private System.Windows.Forms.Label labelFollowHint;
        private System.Windows.Forms.TableLayoutPanel tableSidebar;
        private System.Windows.Forms.TableLayoutPanel tableFramerate;
    }
}
