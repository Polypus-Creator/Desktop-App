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
        private Header header;
        private Footer footer;
        private List<JObject> listaJSON = new List<JObject>();
        
        public ClassJSONList() { }

        public Header Header { get => header; set => header = value; }
        public Footer Footer { get => footer; set => footer = value; }
        public List<JObject> ListaJSON { get => listaJSON; set => listaJSON = value; }
        
    }
}
