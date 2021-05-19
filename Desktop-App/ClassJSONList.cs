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
        private List<JObject> listaJSON = new List<JObject>();

        public ClassJSONList() { }

        public List<JObject> ListaJSON { get => listaJSON; set => listaJSON = value; }
    }
}
