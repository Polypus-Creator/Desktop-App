using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop_App
{
    class ImageText
    {
        private string elemento = "Image Text";
        private string title;
        private string text;
        private string image;
        private string orientaton;

        public ImageText(string text, string image, string left)
        {
            Text = text;
            Image = image;
            Orientaton = left;
        }

        public ImageText(string title, string text, string image, string left)
        {
            Title = title;
            Text = text;
            Image = image;
            Orientaton = left;
        }

        public string Elemento => elemento;
        public string Title { get => title; set => title = value; }
        public string Text { get => text; set => text = value; }
        public string Image { get => image; set => image = value; }
        public string Orientaton { get => orientaton; set => orientaton = value; }
    }
}
