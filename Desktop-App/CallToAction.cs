using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Desktop_App
{
    class CallToAction
    {
        private string elemento;
        private string title;
        private string text;
        private string backColor;
        private string buttonColor;
        private string buttonText;
        private string buttonUrl;
        private string orientation;
        private string rutaImage;

        public CallToAction(string title, string text, Color backColor, Color buttonColor, string buttonText, string buttonUrl, string orientation, string rutaImage)
        {
            Elemento = "CallToAction";
            Title = title;
            Text = text;
            BackColor = ClassString.HexConverter(backColor);
            ButtonColor = ClassString.HexConverter(buttonColor);
            ButtonText = buttonText;
            ButtonUrl = buttonUrl;
            Orientation = orientation;
            RutaImage = rutaImage;
        }

        public string Elemento { get => elemento; set => elemento = value; }
        public string Title { get => title; set => title = value; }
        public string Text { get => text; set => text = value; }
        public string BackColor { get => backColor; set => backColor = value; }
        public string ButtonColor { get => buttonColor; set => buttonColor = value; }
        public string ButtonText { get => buttonText; set => buttonText = value; }
        public string ButtonUrl { get => buttonUrl; set => buttonUrl = value; }
        public string Orientation { get => orientation; set => orientation = value; }
        public string RutaImage { get => rutaImage; set => rutaImage = value; }

    }
}
