using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class User
    {
        private string username, password;
        private string email, preguntaSeguridad, respuestaSeguridad;
        private Boolean stayLogged = false;

        public User(string username, string password, string email, string preguntaSeguridad, string respuestaSeguridad, bool stayLogged) : this(username, password, email)
        {
            PreguntaSeguridad = preguntaSeguridad;
            RespuestaSeguridad = respuestaSeguridad;
            StayLogged = stayLogged;
        }

        public User(string username, string password, string respuestaSeguridad)
        {
            Username = username;
            Password = password;
            RespuestaSeguridad = respuestaSeguridad;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public string PreguntaSeguridad { get => preguntaSeguridad; set => preguntaSeguridad = value; }
        public string RespuestaSeguridad { get => respuestaSeguridad; set => respuestaSeguridad = value; }
        public bool StayLogged { get => stayLogged; set => stayLogged = value; }
    }

    
}
