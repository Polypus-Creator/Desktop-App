using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    class ClassCreatePanelElement
    {
        private string _id;
        private ClassCreatePanelAjustes _createAjustes;
        private int _maxW;
        private int _maxOp = 6;
        private string _title;
        private Label _labelTitle = new Label();
        private Panel _panelAdd = new Panel();
        private Panel _panelGol = new Panel();
        private Panel _panelOption = new Panel();
        private Panel _panelEd = new Panel();
        private Panel _panelDe = new Panel();
        private PictureBox _pbEd = new PictureBox();
        private PictureBox _pbDe = new PictureBox();
        private List<string> _options = new List<string>();
        private List<Label> _labelOptions = new List<Label>();
        private List<PictureBox> _butonsOptions = new List<PictureBox>();
        private List<Panel> _panelColors = new List<Panel>();



        public ClassCreatePanelElement(int maxW, int maxOp, string title, List<string> options)
        {
            this.MaxW = maxW;
            this.MaxOp = maxOp;
            this.Title = title;
            this.Id = title;
            this.Options = options;
            createView();
        }


        public string Id { get => _id; set => _id = value; }
        public int MaxW { get => _maxW; set => _maxW = value; }
        public int MaxOp { get => _maxOp; set => _maxOp = value; }
        public string Title { get => _title; set => _title = value; }
        public Label LabelTitle { get => _labelTitle; set => _labelTitle = value; }
        public Panel PanelAdd { get => _panelAdd; set => _panelAdd = value; }
        public Panel PanelGol { get => _panelGol; set => _panelGol = value; }
        public Panel PanelOption { get => _panelOption; set => _panelOption = value; }
        public Panel PanelEd { get => _panelEd; set => _panelEd = value; }
        public Panel PanelDe { get => _panelDe; set => _panelDe = value; }
        public PictureBox PbEd { get => _pbEd; set => _pbEd = value; }
        public PictureBox PbDe { get => _pbDe; set => _pbDe = value; }
        public List<string> Options { get => _options; set => _options = value; }
        public List<Label> LabelOptions { get => _labelOptions; set => _labelOptions = value; }
        public List<PictureBox> ButonsOptions { get => _butonsOptions; set => _butonsOptions = value; }
        internal ClassCreatePanelAjustes CreateAjustes { get => _createAjustes; set => _createAjustes = value; }
        public List<Panel> PanelColors { get => _panelColors; set => _panelColors = value; }

        private void createView()
        {

            PanelGol.Location = new Point(0,3);
            PanelGol.Size = new Size(MaxW, 130);
            PanelGol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelGol.BackColor = Color.FromArgb(240,240,240);
            PanelGol.Visible = true;

            LabelTitle.Size = new Size(70, 21);
            LabelTitle.Location = new Point(5, 6);
            LabelTitle.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
            LabelTitle.Text = Title;
            LabelTitle.Visible = true;
            PanelGol.Controls.Add(LabelTitle);


            PanelOption.Location = new Point(395, 0);
            PanelOption.Size = new Size(88, 45);
            PanelOption.BackColor = Color.FromArgb(96, 71, 71);
            PanelOption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelOption.Visible = true;
            PanelGol.Controls.Add(PanelOption);

            PanelEd.Location = new Point(0, 0);
            PanelEd.Size = new Size(43, 45);
            PanelEd.BackColor = Color.FromArgb(96, 71, 71);
            PanelEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelEd.Visible = true;
            PanelEd.Cursor = Cursors.Hand;
            PanelOption.Controls.Add(PanelEd);

            PanelDe.Location = new Point(43, 0);
            PanelDe.Size = new Size(43, 45);
            PanelDe.BackColor = Color.FromArgb(96, 71, 71);
            PanelDe.Cursor = Cursors.Hand;
            PanelDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PanelDe.Visible = true;
            PanelOption.Controls.Add(PanelDe);

            PbEd.Location = new Point(11, 11);
            PbEd.Size = new Size(23, 23);
            PbEd.BackColor = Color.FromArgb(96, 71, 71);
            PbEd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PbEd.Cursor = Cursors.Hand;
            PbEd.Image = Desktop_App.Properties.Resources.editar;
            PbEd.Visible = true;
            PbEd.SizeMode = PictureBoxSizeMode.StretchImage;
            PanelEd.Controls.Add(PbEd);

            PbDe.Location = new Point(11, 11);
            PbDe.Size = new Size(23, 23);
            PbDe.BackColor = Color.FromArgb(96, 71, 71);
            PbDe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            PbDe.Cursor = Cursors.Hand;
            PbDe.SizeMode = PictureBoxSizeMode.StretchImage;
            PbDe.Image = Desktop_App.Properties.Resources.trash;
            PbDe.Visible = true;
            PanelDe.Controls.Add(PbDe);

            createOption();
        }

        private void createOption()
        {
            int x1l = 37;
            int y1l = 59;
            int y2l = 99;
            
            int count = 0;
            int countId = 0;
            Boolean filaOne = true;
            Boolean filaTwo = true;
            Boolean filaThree = true;
            Boolean filaFour = true;
            if (MaxOp<=6&&MaxOp>0) {
                Options.ForEach(delegate (String option)
                {
                    if (filaOne) {
                        Label lbOption = new Label();
                        lbOption.Size = new Size(75, 21);
                        lbOption.Location = new Point(x1l + 128 * count, y1l);
                        lbOption.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        lbOption.Text = option;
                        lbOption.Name = "label" + countId;
                        lbOption.Visible = false;
                        _labelOptions.Add(lbOption);
                        PanelGol.Controls.Add(lbOption);

                        count++;
                        countId++;
                        if (count == 3)
                        {
                            filaOne = false;
                            count = 0;
                        }
                    }
                    else
                    {
                        Label lbOption = new Label();
                        lbOption.Size = new Size(70, 21);
                        lbOption.Location = new Point(x1l + 128 * count, y2l);
                        lbOption.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        lbOption.Text = option;
                        lbOption.Name = "label" + count;
                        lbOption.Visible = false;
                        _labelOptions.Add(lbOption);
                        PanelGol.Controls.Add(lbOption);
                        count++;
                        countId++;
                    }
                });
            }
            else
            {
                y1l = 40;
                y2l = 66;
                int y3l = 88;
                int y4l = 110;
                Options.ForEach(delegate (String option)
                {
                    if (filaOne)
                    {
                        Label lbOption = new Label();
                        lbOption.Size = new Size(75, 21);
                        lbOption.Location = new Point(x1l + 128 * count, y1l);
                        lbOption.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        lbOption.Text = option;
                        lbOption.Name = "label" + countId;
                        lbOption.Visible = false;
                        _labelOptions.Add(lbOption);
                        PanelGol.Controls.Add(lbOption);

                        count++;
                        countId++;
                        if (count == 3)
                        {
                            filaOne = false;
                            count = 0;
                        }
                    }
                    else if(filaTwo)
                    {
                        Label lbOption = new Label();
                        lbOption.Size = new Size(70, 21);
                        lbOption.Location = new Point(x1l + 128 * count, y2l);
                        lbOption.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        lbOption.Text = option;
                        lbOption.Name = "label" + count;
                        lbOption.Visible = false;
                        _labelOptions.Add(lbOption);
                        PanelGol.Controls.Add(lbOption);
                        count++;
                        countId++;
                        if (count == 3)
                        {
                            filaTwo = false;
                            count = 0;
                        }
                    }
                    else if(filaThree)
                    {
                        Label lbOption = new Label();
                        lbOption.Size = new Size(70, 21);
                        lbOption.Location = new Point(x1l + 128 * count, y3l);
                        lbOption.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        lbOption.Text = option;
                        lbOption.Name = "label" + count;
                        lbOption.Visible = false;
                        _labelOptions.Add(lbOption);
                        PanelGol.Controls.Add(lbOption);
                        count++;
                        countId++;
                        if (count == 3)
                        {
                            filaThree = false;
                            count = 0;
                        }
                    }
                    else
                    {
                        Label lbOption = new Label();
                        lbOption.Size = new Size(70, 21);
                        lbOption.Location = new Point(x1l + 128 * count, y4l);
                        lbOption.Font = new Font("Segoe UI Semibold", 12, FontStyle.Bold);
                        lbOption.Text = option;
                        lbOption.Name = "label" + count;
                        lbOption.Visible = false;
                        _labelOptions.Add(lbOption);
                        PanelGol.Controls.Add(lbOption);
                        count++;
                        countId++;
                    }

                });
            }
        }
    }
}
