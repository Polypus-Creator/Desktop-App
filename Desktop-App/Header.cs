using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Desktop_App
{
    class Header
    {
        private string elemento = "Logo&ItemsNav";
        private string[,] navItems;
        private string backColor;
        private string textColor;
        private string logoUrl;

        public Header(string[,] navItems, Color backColor, Color textColor)
        {
            NavItems = navItems;
            BackColor = ClassString.HexConverter(backColor);
            TextColor = ClassString.HexConverter(textColor);
        }
        public Header(string[,] navItems, Color backColor, Color textColor, string logoUrl)
        {
            NavItems = navItems;
            BackColor = ClassString.HexConverter(backColor);
            TextColor = ClassString.HexConverter(textColor);
            LogoUrl = logoUrl;
        }  


        public string Elemento => elemento;
        public string[,] NavItems { get => navItems; set => navItems = value; }
        public string BackColor { 
            get => backColor; 
            set => backColor = value; 
        }
        public string TextColor { get => textColor; set => textColor = value; }
        public string LogoUrl { get => logoUrl; set => logoUrl = value; }

    }
}
