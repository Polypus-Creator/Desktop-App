using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Desktop_App
{
    class Header
    {
        private string[,] navItems;
        private string backColor;
        private string textColor;
        private string logoUrl;
        private string webName;

        public Header(string[,] navItems, Color backColor, Color textColor)
        {
            NavItems = navItems;
            BackColor = HexConverter(backColor);
            TextColor = HexConverter(textColor);
        }
        public Header(string[,] navItems, Color backColor, Color textColor, string logoUrl, string webName)
        {
            NavItems = navItems;
            BackColor = HexConverter(backColor);
            TextColor = HexConverter(textColor);
            LogoUrl = logoUrl;
            WebName = webName;
        }  


        public string[,] NavItems { get => navItems; set => navItems = value; }
        public string BackColor { 
            get => backColor; 

            set => backColor = value; 
        }
        public string TextColor { get => textColor; set => textColor = value; }
        public string LogoUrl { get => logoUrl; set => logoUrl = value; }
        public string WebName { get => webName; set => webName = value; }


        private String HexConverter(System.Drawing.Color c) 
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
