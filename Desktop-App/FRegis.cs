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
    public partial class FRegis : Form
    {
        private int time = 0;
        public FRegis()
        {
            InitializeComponent();
            initConfig();
        }

        private void initConfig()
        {
            this.CenterToScreen();
            int fullWidth = Screen.PrimaryScreen.Bounds.Width;
            int fullHeight = Screen.PrimaryScreen.Bounds.Height;
            this.Width = fullWidth / 2;
            this.Height = fullHeight / 2;
        }

        private void timerOjo_Tick(object sender, EventArgs e)
        {
            time++;
            if (time == 5)
            {
                time = 0;
                pictureBoxOjo1.Image = Desktop_App.Properties.Resources.eyeCl;
                pictureBoxOjo2.Image = Desktop_App.Properties.Resources.eyeCl;
                textBoxPass.UseSystemPasswordChar = true;
                textBoxConfPass.UseSystemPasswordChar = true;
                timerOjo.Stop();
            }
        }

        private void pictureBoxOjo1_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
            pictureBoxOjo1.Image = Desktop_App.Properties.Resources.eyeOp;
            timerOjo.Start();
        }

        private void pictureBoxOjo2_Click(object sender, EventArgs e)
        {
            textBoxConfPass.UseSystemPasswordChar = false;
            pictureBoxOjo2.Image = Desktop_App.Properties.Resources.eyeOp;
            timerOjo.Start();
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
