using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

        private string getPropertyNameByID(int id)
        {
            string result = string.Empty;
            switch (id)
            {
                case 0:
                    result = "Image Title";
                    break;
                case 1:
                    result = "Equipment manufacturer";
                    break;
                case 2:
                    result = "Equipment model";
                    break;
                case 3:
                    result = "ExifDTOOriginal";
                    break;
                case 4:
                    result = "Exif exposure time";
                    break;
                case 5:
                    result = "Luminance table";
                    break;
                case 6:
                    result = "Chrominance table";
                    break;
                default: 
                    result = "Not known";
                    break;
            }

            return result;
        }

        public TreeNode getImageDetails()
        {
            TreeNode treeNode = new TreeNode();
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            using (Image img = new Bitmap(_imageFilePath))
            {
                treeNode.Nodes.Add("Dimensions");
                treeNode.Nodes[0].Nodes.Add("Dimensions.Width", string.Format("Width: {0}", img.Width.ToString()));
                treeNode.Nodes[0].Nodes.Add("Dimensions.Height", string.Format("Height: {0}", img.Height.ToString()));

                treeNode.Nodes.Add("Misc");
                treeNode.Nodes[1].Nodes.Add("Misc.PixelFormat", string.Format("PixelFormat: {0}", img.PixelFormat.ToString()));

                treeNode.Nodes.Add("PropertyItems");
                treeNode.Nodes[2].Nodes.Add(string.Format("{0}: {1}", "Camera Make", encoding.GetString(img.GetPropertyItem(0x010F).Value)));
                treeNode.Nodes[2].Nodes.Add(string.Format("{0}: {1}", "Camera Model", encoding.GetString(img.GetPropertyItem(0x110).Value)));

            }

            return treeNode;
        }


    }
}
