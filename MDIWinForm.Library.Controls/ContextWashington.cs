using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIWinForm.Library.Controls
{
    public partial class ContextWashington : ContextMenuStrip
    {
        public ContextWashington()
        {
            InitializeComponent();
            init();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        public void init()
        {
            this.Items.Add(new ToolStripMenuItem("Do Something 1"));
            this.Items.Add(new ToolStripMenuItem("Do Something 2"));
            this.Items.Add(new ToolStripMenuItem("Do Something 3"));
        }

    }
}
