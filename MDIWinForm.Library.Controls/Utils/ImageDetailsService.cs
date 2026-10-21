using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIWinForm.Library.Controls.Utils
{
    public class ImageDetailsService
    {
        private string _imageFilePath = string.Empty;

        public ImageDetailsService(string imageFilePath) 
        { 
            _imageFilePath = imageFilePath;
        }

        public TreeNode getImageDetails()
        {
            TreeNode treeNode = new TreeNode();

            using (Image img = new Bitmap(_imageFilePath))
            {
                treeNode.Nodes.Add("Size");
                treeNode.Nodes.Add("Width", img.Width.ToString());
                treeNode.Nodes.Add("Height", img.Height.ToString());
                treeNode.Nodes.Add("PixelFormat", img.PixelFormat.ToString());
                treeNode.Nodes.Add("Dummy1");
                treeNode.Nodes.Add("Dummy2", "DummtValue2");
                treeNode.Nodes.Add("Dummy3", "DummtValue3", 0, 0);
            }

            return treeNode;
        }


    }
}
