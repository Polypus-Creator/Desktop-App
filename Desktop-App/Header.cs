using System;
using System.Collections.Generic;
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

        public Header(string[,] navItems, string backColor, string textColor)
        {
            NavItems = navItems;
            BackColor = backColor;
            TextColor = textColor;
        }
        public Header(string[,] navItems, string backColor, string textColor, string logoUrl, string webName)
        {
            NavItems = navItems;
            BackColor = backColor;
            TextColor = textColor;
            LogoUrl = logoUrl;
            WebName = webName;
        }  


        public string[,] NavItems { get => navItems; set => navItems = value; }
        public string BackColor { get => backColor; set => backColor = value; }
        public string TextColor { get => textColor; set => textColor = value; }
        public string LogoUrl { get => logoUrl; set => logoUrl = value; }
        public string WebName { get => webName; set => webName = value; }
    }
}
