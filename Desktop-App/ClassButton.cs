using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class ClassButton
    {
        private string elemento = "button";
        private string text;
        private string link;

        public ClassButton(string elemento, string text, string link)
        {
            Elemento = elemento;
            Text = text;
            Link = link;
        }
        public string Elemento { get => elemento; set => elemento = value; }
        public string Text { get => text; set => text = value; }
        public string Link { get => link; set => link = value; }
    }
}
