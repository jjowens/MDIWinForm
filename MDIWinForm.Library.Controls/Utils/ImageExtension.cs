using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;


namespace MDIWinForm.Library.Controls.Utils
{
    public static class ImageExtension
    {

        public enum ImagePropertyName
        {
            EquipModel = 0x110,
            EquipMake =  0x010F
        }

        public static PropertyItem GetPropertyItemByName(this Image img, ImagePropertyName propertyName)
        {
            if (!img.PropertyIdList.Contains((int)propertyName))
            {
                return null;
            }

            return img.GetPropertyItem((int)propertyName);
        }

        public static string GetPropertyItemValueByName(this Image img, ImagePropertyName propertyName)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            if (!img.PropertyIdList.Contains((int)propertyName))
            {
                return string.Empty;
            }

            return encoding.GetString(img.GetPropertyItem((int)propertyName).Value);
        }

    }
}
