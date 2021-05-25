using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class Title
    {
        private string elemento = "Title";
        private string vtitle;

        public Title(string elemento, string vtitle)
        {
            Elemento = elemento;
            VTitle = vtitle;
        }

        public string Elemento { get => elemento; set => elemento = value; }
        public string VTitle { get => vtitle; set => vtitle = value; }
    }
}
