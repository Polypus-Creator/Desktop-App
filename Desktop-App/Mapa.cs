using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class Mapa
    {
        private string elemento = "Mapa";
        private string iframe;
        private string title;
        private string correo;
        private string phone;
        private string hora;
        private string web;

        public Mapa(string elemento, string iframe, string title, string correo, string phone, string hora, string web)
        {
            Elemento = elemento;
            Iframe = iframe;
            Title = title;
            Correo = correo;
            Phone = phone;
            Hora = hora;
            Web = web;
        }
        
        public string Elemento { get => elemento; set => elemento = value; }
        public string Iframe { get => iframe; set => iframe = value; }
        public string Title { get => title; set => title = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Hora { get => hora; set => hora = value; }
        public string Web { get => web; set => web = value; }
    }
}
