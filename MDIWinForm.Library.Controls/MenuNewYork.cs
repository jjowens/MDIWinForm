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

            menu.DropDownItems.Add(new ToolStripMenuItem("New", null, new_ClickedEvent));
            menu.DropDownItems.Add(new ToolStripMenuItem("Open", null, open_ClickedEvent));
            menu.DropDownItems.Add(new ToolStripMenuItem("Save", null, save_ClickedEvent));
            menu.DropDownItems.Add(new ToolStripSeparator());
            menu.DropDownItems.Add(new ToolStripMenuItem("Exit", null, exit_ClickedEvent));

            return menu;
        }

        private ToolStripMenuItem createMenu_About()
        {
            ToolStripMenuItem menu = new ToolStripMenuItem("About");

            menu.DropDownItems.Add(new ToolStripMenuItem("Help", null, help_ClickedEvent));
            menu.DropDownItems.Add(new ToolStripMenuItem("About MDI WinForm", null, about_ClickedEvent));

            return menu;
        }

        private void do_nothing_ClickedEvent(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0} event has not been set up", sender.ToString()));
        }


        // FILE MENY EVENT HANDLERS
        private void new_ClickedEvent(object sender, EventArgs e)
        {
            Form frm = (this.Parent as Form);
            frmCanvas frmCanvas = new frmCanvas();
            frmCanvas.MdiParent = frm;
            frmCanvas.Show();
        }

        private void open_ClickedEvent(object sender, EventArgs e)
        {
            //Form frm = (this.Parent as Form);
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text|*.txt";
            openFileDialog.Multiselect = false;

            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Form frm = (this.Parent as Form);
                frmCanvas frmCanvas = new frmCanvas(openFileDialog.FileName);
                frmCanvas.MdiParent = frm;
                frmCanvas.Show();
            }

        }

        private void save_ClickedEvent(object sender, EventArgs e)
        {
            Form frm = (this.Parent as Form);


            if (frm.MdiChildren.Count() > 0)
            {
                //frmCanvas myCanvas = frm.MdiChildren.OfType<frmCanvas>().FirstOrDefault();
                frmCanvas myCanvas = frm.ActiveMdiChild as frmCanvas;

                if (myCanvas != null)
                {
                    myCanvas.IsSaved = true;
                }
            }
        }

        private void exit_ClickedEvent(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // ABOUT MENU EVENT HANDLERS
        private void about_ClickedEvent(object sender, EventArgs e)
        {
            string appName = Application.ProductName;
            string appVersion = Application.ProductVersion;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Name: {0}", appName));
            sb.AppendLine(String.Format("Version: {0}", appVersion));

            MessageBox.Show(sb.ToString(), "About Application", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void help_ClickedEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Help? What help?", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

    }
}
