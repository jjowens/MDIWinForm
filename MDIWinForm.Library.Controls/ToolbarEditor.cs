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
    public partial class ToolbarEditor : ToolStrip
    {
        public ToolbarEditor()
        {
            InitializeComponent();
            init();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void init()
        {
            this.Dock = DockStyle.Top;
            this.Items.Add(new ToolStripButton("Design"));
            this.Items.Add(new ToolStripButton("Manage"));
            this.Items.Add(new ToolStripButton("Export"));

            this.Items.Add(addMoreOptions());

        }

        private ToolStripDropDownButton addMoreOptions()
        {
            ToolStripDropDownButton tsdb = new ToolStripDropDownButton();
            tsdb.Text = "...";

            tsdb.DropDownItems.Add("Option 1");
            tsdb.DropDownItems.Add("Option 2");
            tsdb.DropDownItems.Add("Option 3");
            tsdb.DropDownItems.Add("Option 4");

            return tsdb;
        }

    }
}
