using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class ClassImage
    {
        private string element = "Image";
        private List<string> rutasImages = new List<string>();
        public ClassImage(string element)
        {
            Element = element;
        }
        public ClassImage(string element, List<string> rutas)
        {
            Element = element;
            RutasImages = rutas;
        }
        public string Element { get => element; set => element = value; }
        public List<string> RutasImages { get => rutasImages; set => rutasImages = value; }
        

        
    }
}
