using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class Footer
    {
        private string elemento = "Footer";
        private string text;
        private string title;
        private string horari;
        private string correo;
        private string telefono;
        private string web;
        private string linkTw;
        private string linkLk;
        private string linkIn;
        private string linkFb;
        private string logoUrl;

        public Footer(string elemento, string text, string logoUrl)
        {
            Elemento = elemento;
            Text = text;
            LogoUrl = logoUrl;
        }
        public Footer(string elemento, string title, string text, string horario, string correo, string telefono, string web, string linkTw, string linkLk, string linkIn, string linkFb, string logoUrl)
        {
            Elemento = elemento;
            Text = text;
            Title = title;
            Horari = horario;
            Correo = correo;
            Telefono = telefono;
            Web = web;
            LinkTw = linkTw;
            LinkLk = linkLk;
            LinkIn = linkIn;
            LinkFb = linkFb;
            LogoUrl = logoUrl;
        }
        public string Elemento { get => elemento; set => elemento = value; }
        public string Text { get => text; set => text = value; }
        public string Title { get => title; set => title = value; }
        public string Horari { get => horari; set => horari = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Web { get => web; set => web = value; }
        public string LinkTw { get => linkTw; set => linkTw = value; }
        public string LinkLk { get => linkLk; set => linkLk = value; }
        public string LinkIn { get => linkIn; set => linkIn = value; }
        public string LinkFb { get => linkFb; set => linkFb = value; }
        public string LogoUrl { get => logoUrl; set => logoUrl = value; }
    }
}
