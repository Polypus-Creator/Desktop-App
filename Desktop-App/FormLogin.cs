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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            initConfig();
        }

        private void initConfig()
        {
            this.CenterToScreen();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabelContasenaOlvidada_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormContrasenaOlvidada formContrasenaOlvidada = new FormContrasenaOlvidada();
            this.Hide();
            formContrasenaOlvidada.Show();
        }
    }
}
