namespace MDIWinForm.Library.Controls
{
    partial class frmImageViewer
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
            this.picImageFile = new System.Windows.Forms.PictureBox();
            this.lblImageFile = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblImageDetails = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImageFile)).BeginInit();
            this.SuspendLayout();
            // 
            // picImageFile
            // 
            this.picImageFile.Location = new System.Drawing.Point(12, 25);
            this.picImageFile.Name = "picImageFile";
            this.picImageFile.Size = new System.Drawing.Size(348, 413);
            this.picImageFile.TabIndex = 0;
            this.picImageFile.TabStop = false;
            // 
            // lblImageFile
            // 
            this.lblImageFile.AutoSize = true;
            this.lblImageFile.Location = new System.Drawing.Point(12, 9);
            this.lblImageFile.Name = "lblImageFile";
            this.lblImageFile.Size = new System.Drawing.Size(83, 13);
            this.lblImageFile.TabIndex = 1;
            this.lblImageFile.Text = "Image File Path:";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(392, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(382, 413);
            this.treeView1.TabIndex = 2;
            // 
            // lblImageDetails
            // 
            this.lblImageDetails.AutoSize = true;
            this.lblImageDetails.Location = new System.Drawing.Point(389, 9);
            this.lblImageDetails.Name = "lblImageDetails";
            this.lblImageDetails.Size = new System.Drawing.Size(74, 13);
            this.lblImageDetails.TabIndex = 3;
            this.lblImageDetails.Text = "Image Details:";
            this.lblImageDetails.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImageDetails);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.lblImageFile);
            this.Controls.Add(this.picImageFile);
            this.Name = "frmImageViewer";
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.picImageFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picImageFile;
        private System.Windows.Forms.Label lblImageFile;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblImageDetails;
    }
}