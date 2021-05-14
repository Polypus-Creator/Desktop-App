using System;
using System.Collections.Generic;
using System.Text;

namespace Desktop_App
{
    class CallToAction
    {
        private string title;
        private string text;
        private string backColor;
        private string titleColor;
        private string textColor;
        private string buttonText;
        private string buttonUrl;
        private string orientation;

        public CallToAction(string title, string text, string backColor, string titleColor,string  textColor, string buttonText, string buttonUrl, string orientation)
        {
            Title = title;
            Text = text;
            BackColor = backColor;
            TitleColor = titleColor;
            TextColor = textColor;
            ButtonText = buttonText;
            ButtonUrl = buttonUrl;
            Orientation = orientation;
        }

        public string Title { get => title; set => title = value; }
        public string Text { get => text; set => text = value; }
        public string BackColor { get => backColor; set => backColor = value; }
        public string TitleColor { get => titleColor; set => titleColor = value; }
        public string TextColor { get => textColor; set => textColor = value; }
        public string ButtonText { get => buttonText; set => buttonText = value; }
        public string ButtonUrl { get => buttonUrl; set => buttonUrl = value; }
        public string Orientation { get => orientation; set => orientation = value; }
    }
}
