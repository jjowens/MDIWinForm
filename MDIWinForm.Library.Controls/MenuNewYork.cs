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
    public partial class MenuNewYork : MenuStrip
    {
        public MenuNewYork()
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
            this.AutoSize = true;
            this.Name = "mnuNewYork";
            this.Text = "menuNewYork";
            this.TabIndex = 0;
            this.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Size = new System.Drawing.Size(800, 24);
            this.Location = new System.Drawing.Point(0, 0);
            this.Items.Add(createMenu_File());
            this.Items.Add(createMenu_About());
        }

        private ToolStripMenuItem createMenu_File()
        {
            ToolStripMenuItem menu = new ToolStripMenuItem("File");

            menu.DropDownItems.Add(new ToolStripMenuItem("Open", null, open_ClickEvent));
            menu.DropDownItems.Add(new ToolStripMenuItem("Save", null, do_nothing_ClickedEvent));
            menu.DropDownItems.Add(new ToolStripSeparator());
            menu.DropDownItems.Add(new ToolStripMenuItem("Exit", null, do_nothing_ClickedEvent));

            return menu;
        }

        private ToolStripMenuItem createMenu_About()
        {
            ToolStripMenuItem menu = new ToolStripMenuItem("About");

            menu.DropDownItems.Add(new ToolStripMenuItem("Help", null, do_nothing_ClickedEvent));
            menu.DropDownItems.Add(new ToolStripMenuItem("About MDI WinForm", null, do_nothing_ClickedEvent));

            return menu;
        }

        private void do_nothing_ClickedEvent(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0} event has not been set up", sender.ToString()));
        }

        private void open_ClickEvent(object sender, EventArgs e)
        {
            Form frm = (this.Parent as Form);

            

        }

    }
}
