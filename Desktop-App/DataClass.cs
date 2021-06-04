using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class DataClass
    {
        public static Color backOne = Color.Black;
        public static Color backTwo = Color.White;
        public static Header header;
        public static List<object> listasElementos = new List<object>();
        public static ClassJSONList classListaJSON = new ClassJSONList();
        public static string websiteName="";
        public static string websiteDesc = "";
        public static string logoPath = "";
        public static string websiteCategory = "";
        public static string yourLocalWebsitePath = "";
        public static string yourLocalWebsiteImagesFolderPath = "";
        public static string accesToken = "";
    }
}
