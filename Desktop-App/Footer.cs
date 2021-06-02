﻿using System;
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
        public Footer(string text)
        {
            Text = text;
        }
        public Footer(string title, string text, string horario, string correo, string telefono, string web, string linkTw, string linkLk, string linkIn, string linkFb)
        {
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
        }
        public string Elemento => elemento;
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
    }
}
