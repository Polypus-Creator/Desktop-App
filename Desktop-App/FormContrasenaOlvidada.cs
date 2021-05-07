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
    public partial class FormContrasenaOlvidada : Form
    {
        public FormContrasenaOlvidada()
        {
            InitializeComponent();
            initConfig();
        }

        private void initConfig()
        {
            this.CenterToScreen();
            int fullWidth = Screen.PrimaryScreen.Bounds.Width;
            int fullHeight = Screen.PrimaryScreen.Bounds.Height;
            //this.Size = new Size(fullWidth.Screen.PrimaryScreen.WorkingArea.Size.Height);
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonVolverIniciarSesion_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
