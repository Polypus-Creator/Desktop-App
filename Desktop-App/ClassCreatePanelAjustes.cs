using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    class ClassCreatePanelAjustes
    {
        private int _maxH, _maxW;
        private Panel _panelGlo = new Panel();
        private string _title;
        private Label _labelTitle = new Label();
        private Panel _panelSeparador = new Panel();
        private Panel _panelTextos = new Panel();
        private Label labelItem = new Label();
        private List<string> _listItems = new List<string>();
        private List<TextBox> _listText = new List<TextBox>();
        private Panel _panelSave = new Panel();
        private Label _labelSave = new Label();
        private PictureBox _save = new PictureBox();

        public ClassCreatePanelAjustes(int maxW, int maxH, string title, List<string> items)
        {
            this.MaxH = maxH;
            this.MaxW = maxW;
            this.Title = title;
            this.ListItems = items;
            createView();
        }


        public int MaxH { get => _maxH; set => _maxH = value; }
        public int MaxW { get => _maxW; set => _maxW = value; }
        public Panel PanelGlo { get => _panelGlo; set => _panelGlo = value; }
        public string Title { get => _title; set => _title = value; }
        public Label LabelTitle { get => _labelTitle; set => _labelTitle = value; }
        public Label LabelSave { get => _labelSave; set => _labelSave = value; }
        public Panel PanelSeparador { get => _panelSeparador; set => _panelSeparador = value; }
        public Panel PanelTextos { get => _panelTextos; set => _panelTextos = value; }
        public Panel PanelSave { get => _panelSave; set => _panelSave = value; }
        public List<string> ListItems { get => _listItems; set => _listItems = value; }
        public List<TextBox> ListText { get => _listText; set => _listText = value; }
        public PictureBox Save { get => _save; set => _save = value; }

        private void createView()
        {
            PanelGlo.Location = new Point(23, 42);
            PanelGlo.Size = new Size(MaxW, MaxH);
            PanelGlo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelGlo.BackColor = Color.FromArgb(96, 71, 71);
            PanelGlo.Visible = false;

            LabelTitle.Size = new Size(100, 25);
            LabelTitle.Location = new Point(15, 13);
            LabelTitle.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold);
            LabelTitle.ForeColor = Color.White;
            LabelTitle.Text = Title;
            LabelTitle.Visible = true;
            PanelGlo.Controls.Add(LabelTitle);

            PanelSeparador.Location = new Point(20, 44);
            PanelSeparador.Size = new Size(366, 3);
            PanelSeparador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelSeparador.BackColor = Color.White;
            PanelSeparador.Visible = true;
            PanelGlo.Controls.Add(PanelSeparador);

            PanelTextos.Location = new Point(20, 69);
            PanelTextos.Size = new Size(366, 184);
            PanelTextos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelTextos.BackColor = Color.FromArgb(96, 71, 71);
            PanelTextos.Visible = true;
            PanelGlo.Controls.Add(PanelTextos);

            labelItem.Size = new Size(45, 20);
            labelItem.Location = new Point(17, 17);
            labelItem.Font = new Font("Segoe UI Semibold", 11.25f, FontStyle.Bold);
            labelItem.Text = "Items";
            labelItem.ForeColor = Color.White;
            PanelTextos.Controls.Add(labelItem);
            crearItems();

            PanelSave.Location = new Point(237, 247);
            PanelSave.Size = new Size(143, 45);
            PanelSave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelSave.BackColor = Color.FromArgb(96, 71, 71);
            PanelSave.Visible = true;
            PanelSave.Cursor = Cursors.Hand;
            PanelGlo.Controls.Add(PanelSave);

            Save.Location = new Point(13, 8);
            Save.Size = new Size(30, 30);
            Save.BackColor = Color.Transparent;
            Save.BorderStyle = System.Windows.Forms.BorderStyle.None;
            Save.Cursor = Cursors.Hand;
            Save.Image = Desktop_App.Properties.Resources.saveIconLight;
            Save.Visible = true;
            Save.SizeMode = PictureBoxSizeMode.StretchImage;
            PanelSave.Controls.Add(Save);

            LabelSave.Size = new Size(81, 25);
            LabelSave.Location = new Point(47, 11);
            LabelSave.Font = new Font("Segoe UI Semibold", 14.25f, FontStyle.Bold);
            LabelSave.Text = "Guardar";
            LabelSave.Cursor = Cursors.Hand;
            LabelSave.ForeColor = Color.White;
            PanelSave.Controls.Add(LabelSave);
        }

        private void crearItems()
        {
            int x1 = 21, x2 = 193;
            int y1 = 57;
            int fila = 0;
            int countId =0;
            Boolean derecha = true;
            ListItems.ForEach(delegate (String item)
            {
                if (derecha)
                {
                    TextBox text = new TextBox();
                    text.Name = ""+countId;
                    text.Text = item;
                    text.Size = new Size(149, 20);
                    text.Location = new Point(x1, y1+44*fila);
                    text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    derecha = false;
                    ListText.Add(text);
                    PanelTextos.Controls.Add(text);
                    countId++;
                }
                else
                {
                    TextBox text = new TextBox();
                    text.Name = "" + countId;
                    text.Text = item;
                    text.Size = new Size(149, 20);
                    text.Location = new Point(x2, y1+44*fila);
                    text.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    derecha = true;
                    fila++;
                    ListText.Add(text);
                    PanelTextos.Controls.Add(text);
                    countId++;
                }
            });
        }
    }
}
