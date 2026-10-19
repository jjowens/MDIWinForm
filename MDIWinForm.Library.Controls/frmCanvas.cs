using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIWinForm.Library.Controls
{
    public partial class frmCanvas : Form
    {
        public frmCanvas()
        {
            preinit();
        }

        public frmCanvas(string filePath)
        {
            preinit();
            this.FilePath = filePath;
            openFile();
            countCharacters();
        }

        private void preinit()
        {
            InitializeComponent();
            this.Text = "Blank";
            IsSaved = false;
            countCharacters();
        }

        public string FilePath { get; set; }

        private Boolean _isSaved = false;
        public Boolean IsSaved 
        {
            get{ return _isSaved; }
            set
            {
                _isSaved = value;
                UpdateStatus();
            } 
        }

        private void countCharacters()
        {
            tssLabelCounter.Text = String.Format("{0} characters", richTextBox1.Text.Length.ToString());
            IsSaved = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            countCharacters();
        }

        private void UpdateStatus()
        {
            if (_isSaved)
            {
                tssLabelSavedStatus.Text = "Saved";
                tssLabelSavedStatus.ForeColor = Color.Green;
            } else {
                tssLabelSavedStatus.Text = "Unsaved";
                tssLabelSavedStatus.ForeColor = Color.Red;
            }
        }

        private void openFile()
        {
            if (File.Exists(FilePath)) 
            { 
                richTextBox1.Text = File.ReadAllText(FilePath);
                this.Text = Path.GetFileName(FilePath);
            }
        }

        public void SaveFile()
        {
            if (!File.Exists(FilePath) || FilePath == string.Empty) 
            { 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Text|*.txt";
                saveFileDialog.Title = "Save File";

                var result = saveFileDialog.ShowDialog();

                if (result == DialogResult.OK) { 
                    FilePath = saveFileDialog.FileName;
                    this.Text = Path.GetFileName(FilePath);
                } else
                {
                    return;
                }
            }

            File.WriteAllText(FilePath, richTextBox1.Text);

            this.IsSaved = true;
        }

    }
}
