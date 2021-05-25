using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class Text
    {
        private string elemento = "Text";
        private string vText;

        public Text(string elemento, string vText)
        {
            Elemento = elemento;
            VText = vText;
        }

        public string Elemento { get => elemento; set => elemento = value; }
        public string VText { get => vText; set => vText = value; }
    }
}
