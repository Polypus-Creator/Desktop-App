using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Desktop_App
{
    class Separator
    {
        private string elemento = "Separator";
        private string color;
        public Separator (string color)
        {
            Color = color;
        }

        public string Elemento => elemento;
        public string Color { get => color; set => color = value; }

    }
}
