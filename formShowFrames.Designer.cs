namespace WebMCam
{
    partial class FormShowFrames
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowFrames));
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.listBoxFrames = new System.Windows.Forms.ListBox();
            this.contextMenuStripFrames = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.contextMenuStripFrames.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            this.SuspendLayout();
            //
            // buttonCancel
            //
            this.buttonCancel.AutoSize = true;
            this.buttonCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.buttonCancel.MinimumSize = new System.Drawing.Size(88, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            //
            // buttonDone
            //
            this.buttonDone.AutoSize = true;
            this.buttonDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDone.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.buttonDone.MinimumSize = new System.Drawing.Size(88, 0);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.buttonDone.TabIndex = 0;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            //
            // panelButtons
            //
            // Docked and auto-sizing: the buttons are laid out from the bottom edge
            // outwards, so no amount of DPI rescaling can push them off the form the
            // way the old fixed coordinates plus a Bottom anchor did.
            this.panelButtons.AutoSize = true;
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Controls.Add(this.buttonDone);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(8);
            this.panelButtons.TabIndex = 1;
            this.panelButtons.WrapContents = false;
            //
            // listBoxFrames
            //
            this.listBoxFrames.ContextMenuStrip = this.contextMenuStripFrames;
            this.listBoxFrames.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxFrames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFrames.FormattingEnabled = true;
            this.listBoxFrames.IntegralHeight = false;
            this.listBoxFrames.Name = "listBoxFrames";
            this.listBoxFrames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxFrames.Size = new System.Drawing.Size(130, 100);
            this.listBoxFrames.TabIndex = 2;
            this.listBoxFrames.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFrames_DrawItem);
            this.listBoxFrames.SelectedIndexChanged += new System.EventHandler(this.listBoxFrames_SelectedIndexChanged);
            this.listBoxFrames.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxFrames_KeyDown);
            //
            // contextMenuStripFrames
            //
            this.contextMenuStripFrames.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.markToolStripMenuItem});
            this.contextMenuStripFrames.Name = "contextMenuStripFrames";
            this.contextMenuStripFrames.Size = new System.Drawing.Size(108, 48);
            //
            // deleteToolStripMenuItem
            //
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            //
            // markToolStripMenuItem
            //
            this.markToolStripMenuItem.Name = "markToolStripMenuItem";
            this.markToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.markToolStripMenuItem.Text = "Mark";
            this.markToolStripMenuItem.Click += new System.EventHandler(this.markToolStripMenuItem_Click);
            //
            // pictureBoxFrame
            //
            this.pictureBoxFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxFrame.Name = "pictureBoxFrame";
            this.pictureBoxFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFrame.TabIndex = 3;
            this.pictureBoxFrame.TabStop = false;
            //
            // FormShowFrames
            //
            this.AcceptButton = this.buttonDone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(640, 420);
            // Docking is resolved from the last control backwards: the button strip
            // claims the bottom, the list the left, and the preview fills the rest.
            this.Controls.Add(this.pictureBoxFrame);
            this.Controls.Add(this.listBoxFrames);
            this.Controls.Add(this.panelButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 300);
            this.Name = "FormShowFrames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WebMCam Frames";
            this.Load += new System.EventHandler(this.formShowFrames_Load);
            this.contextMenuStripFrames.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.FlowLayoutPanel panelButtons;
        private System.Windows.Forms.ListBox listBoxFrames;
        private System.Windows.Forms.PictureBox pictureBoxFrame;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFrames;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markToolStripMenuItem;
    }
}
