using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
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
            //ClassConfig.FormLogin = this;
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

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {

            
            string username = textBoxUsuario.Text;
            string password = textBoxContrasena.Text;

            if (username.Equals("") || password.Equals(""))
            {

            }
            else //ALL COMPLETED
            {
                
                //_= verificarAsync(username, password);
            }


        }

        private async Task verificarAsync(string username, string password)
        {
            try
            {
                HttpClient cliente = new HttpClient();
                User user = new User(username, password);
                string obstring = JsonConvert.SerializeObject(user);
                JObject objectJSON = JObject.Parse(obstring);
                HttpResponseMessage responsPost = await cliente.PostAsync("http://localhost/filename", new StringContent(
                objectJSON.ToString(),
                Encoding.UTF8,
                "application/json"));
                string responsebody = await responsPost.Content.ReadAsStringAsync();
                if (responsebody.Equals("logeado"))
                {
                    
                }
                else
                {
                    MessageBox.Show("Usuario no registrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
