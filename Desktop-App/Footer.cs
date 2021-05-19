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
        public Footer(string text)
        {
            Text = text;
        }

        public string Elemento => elemento;
        public string Text { get => text; set => text = value; }
    }
}
