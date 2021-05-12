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
    public partial class FormSoporte : Form
    {
        public FormSoporte()
        {
            InitializeComponent();
            initConfig();
        }

        private void initConfig()
        {
            webBrowserMapaContacto.Navigate("https://www.bing.com/maps?osid=60230508-1202-4a62-972e-2a050a8527d6&cp=41.423082~2.190576&lvl=16&imgid=03de3704-c06a-4688-9374-875734f49080&v=2&sV=2&form=S00027");
            generarCaptcha();
            this.CenterToScreen();
        }

        private void generarCaptcha()
        {
            Random rand = new Random();
            int num = rand.Next(6, 8);
            string captcha = "";
            int totl = 0;
            do
            {
                int chr = rand.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    captcha = captcha + (char)chr;
                    totl++;
                    if (totl == num)
                    {
                        break;
                    }
                }

            } while (true);
            labelCaptcha.Text = captcha;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnviar_Click(object sender, EventArgs e)
        {
            if(labelCaptcha.Text == textBoxCaptcha.Text)
            {
                // CODIGO DE INSERT A TABLA INCIDENCIAS
                MessageBox.Show("Mensaje Enviado. Te contestaremos lo antes posible.");
            } else
            {
                MessageBox.Show("Error en captcha. Vuelve a intentarlo.");
                this.OnLoad(e);
            }

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
