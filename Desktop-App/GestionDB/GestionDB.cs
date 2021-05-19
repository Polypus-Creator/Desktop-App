using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Desktop_App.GestionDB
{
    class GestionDB
    {
        #region Properties
        private string server = "polypuscreator-server.database.windows.net";
        private string user = "polypusadmin";
        private string password = "PolypusCreator2021";
        private int port = 1433;
        private string cs;
        private string dbName = "polypuscreatordb";
        private MySqlConnection conn = null;
        private MySqlCommand cmd;
        #endregion

        public GestionDB()
        {

        }



        public void insertarDatos(String userName, String pass, String email, String pregunta_seguridad, String respuesta_seguridad, bool firstLogin, bool stayLoggedIn)
        {
            cs = "server=" + server + ";user=" + user + ";port=" + port + ";password=" + password + ";";
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();

                String passwordEncrypted = encryptPassword(pass);

                string s0 = "INSERT INTO " + "`" + dbName + "`.`" + "USUARIOS" + "` (`nombre`, `password`, `email`, `pregunta_seguridad`, `respuesta_seguridad`, `fecha_registro`, `fecha_ultimo_login`, `first_login`, `stay_logged_in`) VALUES ('" + userName + "', '" + passwordEncrypted + "', '" + email + "', '" + pregunta_seguridad + "', '" + respuesta_seguridad + "', '"+DateTime.Now + "', '" + DateTime.Now + "', '"+firstLogin+"', '"+stayLoggedIn+"');";
                cmd = new MySqlCommand(s0, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private String encryptPassword(String passwordUnencrypted)
        {
            String passwordEncrypted = "";

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(passwordUnencrypted));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            passwordEncrypted = hash.ToString();

            return passwordEncrypted;
        }
    }
}
