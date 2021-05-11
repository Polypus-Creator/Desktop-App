using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    public partial class FAboutUs : Form
    {
        public FAboutUs()
        {
            InitializeComponent();
        }

        private void initConfig()
        {
            int fullWidth = Screen.PrimaryScreen.Bounds.Width;
            int fullHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Width = fullWidth;
            this.Height = fullHeight;
            panelHeader.Width = fullWidth;
            panelClose.Location = new Point(fullWidth - 50, 3);
            panelMin.Location = new Point(fullWidth - 80, 3);
            webBrowserWeb.Size = new Size(fullWidth - 20, fullHeight - 80);
        }

        private void panelMin_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
