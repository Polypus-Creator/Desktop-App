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
        private string columnas;
        private string vText1;
        private string vText2;
        private string vText3;

        public Text(string elemento, string columnas, string vText )
        {
            Elemento = elemento;
            Columnas = columnas;
            VText1 = vText;
           
        }
        public Text(string elemento, string columnas,string vText, string vText2)
        {
            Elemento = elemento;
            Columnas = columnas;
            VText1 = vText;
            VText2 = vText2;

        }
        public Text(string elemento, string columnas, string vText, string vText2, string vText3)
        {
            Elemento = elemento;
            Columnas = columnas;
            VText1 = vText;
            VText2 = vText2;
            VText3 = vText3;

        }
        public string Elemento { get => elemento; set => elemento = value; }
        public string Columnas { get => columnas; set => columnas = value; }
        public string VText1 { get => vText1; set => vText1 = value; }
        public string VText2 { get => vText2; set => vText2 = value; }
        public string VText3 { get => vText3; set => vText3 = value; }
    }
}
