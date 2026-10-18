using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MDIWinForm.Library.Controls;

namespace MDIWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new ToolbarEditor());
            this.Controls.Add(new MenuNewYork());

            this.ContextMenuStrip = new ContextWashington();

            this.Refresh();
        }
    }
}
