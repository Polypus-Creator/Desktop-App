using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class ClassImage
    {
        private string elemento = "Image";
        private List<string> rutasImages = new List<string>();
        public ClassImage(string elemento)
        {
            Elemento = elemento;
        }
        public ClassImage(string elemento, List<string> rutas)
        {
            Elemento = elemento;
            RutasImages = rutas;
        }
        public string Elemento { get => elemento; set => elemento = value; }
        public List<string> RutasImages { get => rutasImages; set => rutasImages = value; }
        

        
    }
}
