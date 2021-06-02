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
        private string columnas;

        public Text(string elemento, string vText, string columnas)
        {
            Elemento = elemento;
            VText = vText;
            Columnas = columnas;
        }
        public string Elemento { get => elemento; set => elemento = value; }
        public string VText { get => vText; set => vText = value; }
        public string Columnas { get => columnas; set => columnas = value; }
    }
}
