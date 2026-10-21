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
    public partial class frmImageViewer : Form
    {
        private string _imageFilePath = string.Empty;
        public string ImageFilePath { get { return _imageFilePath; } }

        public frmImageViewer()
        {
            preinit();
        }

        public frmImageViewer(string imageFilePath)
        {
            _imageFilePath = imageFilePath;
            preinit();
        }

        private void preinit()
        {
            InitializeComponent();
            openImage();
        }


        private void openImage()
        {
            if (File.Exists(ImageFilePath))
            {
                lblImageFile.Text = Path.GetFileName(ImageFilePath);
                picImageFile.ImageLocation = ImageFilePath;

                Utils.ImageDetailsService service = new Utils.ImageDetailsService(ImageFilePath);

                treeView1.Nodes.Add(service.getImageDetails());

                treeView1.ExpandAll();
            }
        }
    }
}
