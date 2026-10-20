namespace MDIWinForm.Library.Controls
{
    partial class frmTextEditor
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
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.editorStatus = new System.Windows.Forms.StatusStrip();
            this.tssLabelCounter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssLabelSavedStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.editorStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.Location = new System.Drawing.Point(12, 12);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(613, 301);
            this.txtNotes.TabIndex = 0;
            this.txtNotes.Text = "";
            this.txtNotes.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // editorStatus
            // 
            this.editorStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssLabelCounter,
            this.tssLabelSavedStatus});
            this.editorStatus.Location = new System.Drawing.Point(0, 324);
            this.editorStatus.Name = "editorStatus";
            this.editorStatus.Size = new System.Drawing.Size(637, 22);
            this.editorStatus.TabIndex = 1;
            this.editorStatus.Text = "statusStrip1";
            // 
            // tssLabelCounter
            // 
            this.tssLabelCounter.Name = "tssLabelCounter";
            this.tssLabelCounter.Size = new System.Drawing.Size(70, 17);
            this.tssLabelCounter.Text = "0 characters";
            // 
            // tssLabelSavedStatus
            // 
            this.tssLabelSavedStatus.Name = "tssLabelSavedStatus";
            this.tssLabelSavedStatus.Size = new System.Drawing.Size(118, 17);
            this.tssLabelSavedStatus.Text = "toolStripStatusLabel1";
            // 
            // frmTextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 346);
            this.Controls.Add(this.editorStatus);
            this.Controls.Add(this.txtNotes);
            this.Name = "frmTextEditor";
            this.Text = "Editor";
            this.editorStatus.ResumeLayout(false);
            this.editorStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtNotes;
        private System.Windows.Forms.StatusStrip editorStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelCounter;
        private System.Windows.Forms.ToolStripStatusLabel tssLabelSavedStatus;
    }
}