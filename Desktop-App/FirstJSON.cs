using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class FirstJSON
    {

        private string website_name;
        private string description;
        private string category;
        private string primary_colour;
        private string secondary_colour;
        private string font;

        public FirstJSON()
        {
        }

        public FirstJSON(string website_name, string description, string category, string primary_colour, string secondary_colour, string font)
        {
            Website_name = website_name;
            Description = description;
            Category = category;
            Primary_colour = primary_colour;
            Secondary_colour = secondary_colour;
            Font = font;
        }

        public string Website_name { get => website_name; set => website_name = value; }
        public string Description { get => description; set => description = value; }
        public string Category { get => category; set => category = value; }
        public string Primary_colour { get => primary_colour; set => primary_colour = value; }
        public string Secondary_colour { get => secondary_colour; set => secondary_colour = value; }
        public string Font { get => font; set => font = value; }
    }
}
