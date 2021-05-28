using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class ClassJSONList
    {
        private string webName = "test";
        private string font;
        private List<JObject> listaJSON = new List<JObject>();
        
        public ClassJSONList() { }

        public string WebName { get => webName; set => webName = value; }
        public List<JObject> ListaJSON { get => listaJSON; set => listaJSON = value; }
        public string Font { get => font; set => font = value; }
    }
}
