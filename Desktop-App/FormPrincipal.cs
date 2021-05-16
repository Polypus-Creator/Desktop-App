
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace Desktop_App
{
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        Boolean extendedLeftBar = true;
        Boolean displayFaqs = false;
        Boolean stayLogged = false;
        int fullWidth = Screen.PrimaryScreen.Bounds.Width;
        int fullHeight = Screen.PrimaryScreen.Bounds.Height;
        List<String> listFiles = new List<String>();
        List<ClassCreatePanelElement> panelesFlow = new List<ClassCreatePanelElement>();
        List<ClassCreatePanelAjustes> panelesAjustes = new List<ClassCreatePanelAjustes>();
        Boolean isHeaderAlreadyOn = false;
        String currentEditingElement = null;
        

        public FormPrincipal()
        {
            InitializeComponent();
            initConfig();
        }

        private void labelIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void initConfig()
        {
            
            this.Width = fullWidth;
            this.Height = fullHeight - 1;
            this.Location = new Point(0, 0);
            panelSuperior.Width = fullWidth;
            windowControlButtons.Location = new Point(fullWidth-100, 0);
            panelLeftBar.Height = fullHeight - 5;
            tabControl.Width = fullWidth - 225;
            tabControl.Height = fullHeight - 45;
            tabControl.Location = new Point(223, 30);
            panelDash.Width = fullWidth/2 + 540;
            panelDise.Width = fullWidth / 2 + 540;
            panelConst.Width = fullWidth / 2 + 540;
            panelConst.Height = fullHeight - 10;
            flowLayoutPanelCurrentElements.Height = fullHeight/2+200;
            panelAj.Width = fullWidth / 2 + 540;
            panelAj.Height = fullHeight - 100;
            panelAyud.Width = fullWidth / 2 + 540;
            panelSave.Location = new Point(10, fullHeight - 190);
            panelSesion.Width = fullWidth - 390 ;
            radioStayLogged.Location = new Point(panelSesion.Width - 50, 6);
            panelAddElements.Location = new Point(fullWidth - 208, 54);
            panelAddElements.Height = fullHeight - 1;
            flowLayoutPanel1.Height = fullHeight - 10;
            panelFirstLogin.Height = fullWidth / 2 + 540;
            panelDash.Height = fullWidth / 2 + 540;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            sideBarColors(1);
        }

        private void panelLeftBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hideShowBar_Click(object sender, EventArgs e)
        {
            int panelWidth = panelTopSideBar.Width;

            if (extendedLeftBar == true)
            {
                hideShowBar.Image = Desktop_App.Properties.Resources.arrow_right;
                extendedLeftBar = false;
                panelLeftBar.Width = 50;
                hideShowBar.Location = new Point(15, 14);
                tabControl.Location = new Point(58,30);
                tabControl.Width = fullWidth - 62;


            }
            else
            {
                hideShowBar.Image = Desktop_App.Properties.Resources.left_arrow;
                extendedLeftBar = true;
                panelLeftBar.Width = 216;
                hideShowBar.Location = new Point(panelWidth - 35,14);
                tabControl.Location = new Point(223, 30);
                tabControl.Width = fullWidth - 227;
            }
            
        }

        private void panelDashboard_Click(object sender, EventArgs e)
        {
            sideBarColors(1);
        }

        private void sideBarColors(int option)
        {
            if( option == 1)
            {
                panelDashboard.BackColor = Color.FromArgb(96, 71, 71);
                panelDisenyo.BackColor = Color.FromArgb(49, 48, 45);
                panelConstructor.BackColor = Color.FromArgb(49, 48, 45);
                panelAjustes.BackColor = Color.FromArgb(49, 48, 45);
                panelAyuda.BackColor = Color.FromArgb(49, 48, 45);
                tabControl.SelectedTab = dashboard;
                panelAddElements.Visible = false;
            }
            if (option == 2)
            {
                panelDashboard.BackColor = Color.FromArgb(49, 48, 45);
                panelDisenyo.BackColor = Color.FromArgb(96, 71, 71);
                panelConstructor.BackColor = Color.FromArgb(49, 48, 45);
                panelAjustes.BackColor = Color.FromArgb(49, 48, 45);
                panelAyuda.BackColor = Color.FromArgb(49, 48, 45);
                tabControl.SelectedTab = disenyo;
                panelAddElements.Visible = false;
            }
            if (option == 3)
            {
                panelDashboard.BackColor = Color.FromArgb(49, 48, 45);
                panelDisenyo.BackColor = Color.FromArgb(49, 48, 45);
                panelConstructor.BackColor = Color.FromArgb(96, 71, 71);
                panelAjustes.BackColor = Color.FromArgb(49, 48, 45);
                panelAyuda.BackColor = Color.FromArgb(49, 48, 45);
                tabControl.SelectedTab = constructor;
            }
            if (option == 4)
            {
                panelDashboard.BackColor = Color.FromArgb(49, 48, 45);
                panelDisenyo.BackColor = Color.FromArgb(49, 48, 45);
                panelConstructor.BackColor = Color.FromArgb(49, 48, 45);
                panelAjustes.BackColor = Color.FromArgb(96, 71, 71);
                panelAyuda.BackColor = Color.FromArgb(49, 48, 45);
                tabControl.SelectedTab = ajustes;
                panelAddElements.Visible = false;
            }
            if (option == 5)
            {
                panelDashboard.BackColor = Color.FromArgb(49, 48, 45);
                panelDisenyo.BackColor = Color.FromArgb(49, 48, 45);
                panelConstructor.BackColor = Color.FromArgb(49, 48, 45);
                panelAjustes.BackColor = Color.FromArgb(49, 48, 45);
                panelAyuda.BackColor = Color.FromArgb(96, 71, 71);
                tabControl.SelectedTab = ayuda;
                panelAddElements.Visible = false;
            }

        }

        

        private void panelDisenyo_Click(object sender, EventArgs e)
        {
            sideBarColors(2);
        }

        private void panelConstructor_Click(object sender, EventArgs e)
        {
            sideBarColors(3);
        }

        private void panelAjustes_Click(object sender, EventArgs e)
        {
            sideBarColors(4);
        }

        private void panelAyuda_Click(object sender, EventArgs e)
        {
            sideBarColors(5);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            sideBarColors(2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sideBarColors(3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            sideBarColors(4);
        }

        private void panelAyuda_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            sideBarColors(5);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sideBarColors(1);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sideBarColors(2);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            sideBarColors(3);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            sideBarColors(4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sideBarColors(5);
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboard_Click(object sender, EventArgs e)
        {

        }

        private void ayuda_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioStayLogged_Click(object sender, EventArgs e)
        {
            if(stayLogged == false)
            {
                radioStayLogged.Image = Desktop_App.Properties.Resources.on;
                stayLogged = true;
            }
            else
            {
                radioStayLogged.Image = Desktop_App.Properties.Resources.off;
                stayLogged = false;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelColorPrincipal_Click(object sender, EventArgs e)
        {
            DataClass.backOne = changeColor(sender);
        }

        private Color changeColor(object sender)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                if(sender is Panel)
                {
                    ((Panel)sender).BackColor = colorPicker.Color;
                    return colorPicker.Color;
                }
            }
            return Color.Red;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            DataClass.backTwo = changeColor(sender);
        }

        private void panelDisenyo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void showHideFaqs_Click(object sender, EventArgs e)
        {
            if(displayFaqs == false)
            {
                panelFaqs.Visible = true;
                showHideFaqs.Image = Desktop_App.Properties.Resources.arrow_up;
                displayFaqs = true;
            }
            else
            {
                panelFaqs.Visible = false;
                showHideFaqs.Image = Desktop_App.Properties.Resources.arrow_down;
                displayFaqs = false;
            }


        }

        private void panelAddElement_MouseClick(object sender, MouseEventArgs e)
        {
            panelAddElements.Visible = true;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void buttonSelecionarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            String filename = openFileDialog.FileName;
            pictureBoxLogo.Image = Image.FromFile(filename);
        }

        private void panel31_MouseClick(object sender, MouseEventArgs e)
        {
            if(isHeaderAlreadyOn == false)
            {
                panel31.Enabled = false;
                isHeaderAlreadyOn = true;            
            }
            string title = "NavBar";
            currentEditingElement = title;
            List<string> options = new List<string>();
            options.Add("");
            options.Add("");
            options.Add("");
            options.Add("");
            options.Add("");
            options.Add("");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 6,title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name= "NavBar" + panelesFlow.Count;

            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText.ForEach(delegate (TextBox textBox)
            {
                textBox.TextChanged += textBox_TextChanged;
            });
            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            Panel colorOne = new Panel();
            Panel colorTwo = new Panel();

            colorOne.Location = new Point(299, 0);
            colorOne.Size = new Size(25, 25);
            colorOne.BackColor = panel8.BackColor;
            colorOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            colorOne.Visible = true;
            colorOne.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColorPrincipal_Click);
            panelElement.PanelGol.Controls.Add(colorOne);

            colorTwo.Location = new Point(324, 0);
            colorTwo.Size = new Size(25, 25);
            colorTwo.BackColor = panel11.BackColor;
            colorTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            colorTwo.Visible = true;
            colorTwo.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColorPrincipal_Click);
            panelElement.PanelGol.Controls.Add(colorTwo);

            panelElement.PanelDe.Name = "NavBarPanelDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "NavBarPbDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "NavBarPanelEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "NavBarPbEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
        }
        private void PanelDe_MouseClicked(Object sender, MouseEventArgs e)
        {
            string typo = sender.GetType().Name;
            if (typo == "Panel")
            {
                Panel panel = (Panel)sender;
                foreach (ClassCreatePanelElement element in panelesFlow)
                {
                    if (element.PanelDe.Equals(panel))
                    {
                        flowLayoutPanelCurrentElements.Controls.Remove(element.PanelGol);
                        panelesFlow.Remove(element);
                        break;
                    }
                }
                
                if (panel.Name.Contains("NavBar"))
                {
                    isHeaderAlreadyOn = false;
                    panel31.Enabled = true;
                    currentEditingElement = null;
                }
            }
            else if (typo == "PictureBox")
            {
                PictureBox picture = (PictureBox)sender;
                foreach (ClassCreatePanelElement element in panelesFlow)
                {
                    if (element.PbDe.Equals(picture))
                    {
                        flowLayoutPanelCurrentElements.Controls.Remove(element.PanelGol);
                        panelesFlow.Remove(element);
                        break;
                    }
                }
                if (picture.Name.Contains("NavBar"))
                {
                    isHeaderAlreadyOn = false;
                    panel31.Enabled = true;
                    currentEditingElement = null;
                }
            }
            
        }


        private void PanelEd_MouseClick(Object sender, MouseEventArgs e)
        {
            string typo = sender.GetType().Name;
            if (typo == "Panel")
            {
                Panel panel = (Panel)sender;
                foreach (ClassCreatePanelElement element in panelesFlow)
                {
                    if (element.PanelEd.Equals(panel))
                    {
                        element.CreateAjustes.PanelGlo.Visible = true;
                        break;
                    }
                }
            }
            else if (typo == "PictureBox")
            {
                PictureBox picture = (PictureBox)sender;
                foreach (ClassCreatePanelElement element in panelesFlow)
                {
                    if (element.PbEd.Equals(picture))
                    {
                        element.CreateAjustes.PanelGlo.Visible = true;
                        break;
                    }
                }
            }
            
            
            
        }

        private void PanelSave_MousClick(object sender, EventArgs e)
        {
            string[,] navItems = new string[6, 2];
            int fila = 0, col = 0;
            panelesAjustes.ForEach(delegate (ClassCreatePanelAjustes panel) 
            {
                if(panel.Title == "NavBar")
                {
                    panel.ListText.ForEach(delegate (TextBox textBox) {
                    if(textBox.Visible)
                        {
                            navItems[fila, col] = textBox.Text;
                            fila++;
                        }
                    });
                    DataClass.header = new Header(navItems, DataClass.backOne, DataClass.backTwo);
                    DataClass.listasElementos.Add(DataClass.header);
                }else if (panel.Title == "Separator")
                {
                    Separator separator = new Separator(panel.ListText[0].Text);
                    DataClass.listasElementos.Add(separator);
                }
            });
                
            
            generateJSON(DataClass.listasElementos);
            string typo = sender.GetType().Name;
            foreach(ClassCreatePanelAjustes elem in panelesAjustes)
            {
                if (typo.Equals("PictureBox"))
                {
                    PictureBox pictureBox = (PictureBox)sender;
                    if (elem.Save.Equals(pictureBox))
                    {
                        elem.PanelGlo.Visible = false;
                    }

                }else if (typo.Equals("Panel"))
                {
                    Panel panel = (Panel)sender;
                    if (elem.PanelSave.Equals(panel))
                    {
                        elem.PanelGlo.Visible = false;
                    }
                }
                else
                {
                    Label label = (Label)sender;
                    if (elem.LabelSave.Equals(label))
                    {
                        elem.PanelGlo.Visible = false;
                    }
                }
            }
            
        }

        private void generateJSON(List<object> listasElementos)
        {
            List<JObject> listaJSON = new List<JObject>();
            listasElementos.ForEach(delegate (object objeto) 
            {
                string typo=objeto.GetType().Name;
                if (typo == "Header")
                {
                    string obstring = JsonConvert.SerializeObject((Header)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    textBoxBreveDescripcion.Text = googleSearch.ToString();
                }
            });
           
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            panelesFlow.ForEach(delegate (ClassCreatePanelElement elemento) 
            {
                if (elemento.Id == "NavBar") {
                    elemento.LabelOptions[Int32.Parse(textBox.Name)].Visible = true;
                    elemento.LabelOptions[Int32.Parse(textBox.Name)].Text = textBox.Text;
                    if(elemento.LabelOptions[Int32.Parse(textBox.Name)].Text == "")
                    {
                        elemento.LabelOptions[Int32.Parse(textBox.Name)].Visible = false;
                    }
                }else if (elemento.Id == "Separator")
                {
                    elemento.LabelOptions[0].Visible = true;
                    elemento.LabelOptions[0].Text = textBox.Text.ToUpper();
                    if (elemento.LabelOptions[0].Text == "" || elemento.LabelOptions[0].Text == "#")
                    {
                        elemento.LabelOptions[0].Visible = false;
                        foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
                        {
                            if (ajustes.ListText.Contains(textBox))
                            {
                                foreach (ClassCreatePanelElement element in panelesFlow)
                                {
                                    if (element.CreateAjustes.Equals(ajustes))
                                    {
                                        foreach (object objeto in element.PanelGol.Controls)
                                        {
                                            if (objeto is Panel)
                                            {
                                                Panel panel = (Panel)objeto;
                                                if (panel.Name == "colorOne")
                                                {
                                                    panel.Visible = false;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
                        {
                            if (ajustes.ListText.Contains(textBox))
                            {
                                foreach (ClassCreatePanelElement element in panelesFlow)
                                {
                                    if (element.CreateAjustes.Equals(ajustes))
                                    {
                                        foreach (object objeto in element.PanelGol.Controls)
                                        {
                                            if (objeto is Panel)
                                            {
                                                Panel panel = (Panel)objeto;
                                                if (panel.Name == "colorOne")
                                                {
                                                    panel.Visible = true;
                                                    if(Regex.IsMatch(textBox.Text.Remove(0,1), "^[0-9A-F]{6}$"))
                                                    {
                                                        Color color = System.Drawing.ColorTranslator.FromHtml(textBox.Text);
                                                        panel.BackColor = color;
                                                    }
                                                    else
                                                    {                                                        
                                                        panel.BackColor = Color.White;
                                                    }

                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            });
        }

        private void label24_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Separator";
            List<string> options = new List<string>();
            options.Add("Color (RGB)");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 1, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);

            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText.ForEach(delegate (TextBox textBox)
            {
                textBox.MouseClick += textBoxSeparator_MouseClick;
                textBox.TextChanged += textBox_TextChanged;
            });

            Panel colorOne = new Panel();
            colorOne.Name = "colorOne";
            colorOne.Location = new Point(panelElement.LabelOptions[0].Location.X+ panelElement.LabelOptions[0].Size.Width+2, panelElement.LabelOptions[0].Location.Y);
            colorOne.Size = new Size(25, 25);
            colorOne.BackColor = panel8.BackColor;
            colorOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            colorOne.Visible = false;
            colorOne.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColorPrincipal_Click);
            panelElement.PanelGol.Controls.Add(colorOne);

            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelGol.Name = "Separator" + panelesFlow.Count;

            panelElement.PanelDe.Name = "SeparatorPanelDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "SeparatorPbDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "SeparatorPanelEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "SeparatorPbEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
        }

        private void textBoxSeparator_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            Color color = changeColor();
            foreach(ClassCreatePanelAjustes ajustes in panelesAjustes)
            {
                if (ajustes.ListText.Contains(textBox))
                {
                    foreach(ClassCreatePanelElement elemento in panelesFlow)
                    {
                        if (elemento.CreateAjustes.Equals(ajustes))
                        {
                            foreach(object objeto in elemento.PanelGol.Controls)
                            {
                                if(objeto is Panel)
                                {
                                    Panel panel = (Panel)objeto;
                                    if(panel.Name == "colorOne")
                                    {
                                        panel.Visible = true;
                                        panel.BackColor = color;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            textBox.Text = HexConverter(color);
        }
        private Color changeColor()
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                return colorPicker.Color;
            }
            return Color.Red;
        }

        private String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }

        private void pictureBox15_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Call To Action";
            currentEditingElement = title;
            List<string> options = new List<string>();
            options.Add("Title");
            options.Add("Text");
            options.Add("Button Text");
            options.Add("Button Link");
            options.Add("orientation");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 5, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "CallToAction" + panelesFlow.Count;

            panelElement.LabelOptions.ForEach(delegate (Label label)
            {
                label.Visible = true;
            });

            Panel backColor = new Panel();
            Panel titleColor = new Panel();
            Panel textColor = new Panel();

            panelElement.PanelColors.Add(backColor);
            panelElement.PanelColors.Add(titleColor);
            panelElement.PanelColors.Add(textColor);

            backColor.Name = "backColor";
            backColor.Location = new Point(112, 59);
            backColor.Size = new Size(16, 16);
            backColor.BackColor = DataClass.backOne;
            backColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            backColor.Visible = true;
            panelElement.PanelGol.Controls.Add(backColor);

            titleColor.Location = new Point(187, 59);
            titleColor.Name = "titleColor";
            titleColor.Size = new Size(16, 16);
            titleColor.BackColor = DataClass.backTwo;
            titleColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            titleColor.Visible = true;
            panelElement.PanelGol.Controls.Add(titleColor);

            textColor.Location = new Point(262, 59);
            textColor.Name = "textColor";
            textColor.Size = new Size(16, 16);
            textColor.BackColor = DataClass.backTwo;
            textColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textColor.Visible = true;
            panelElement.PanelGol.Controls.Add(textColor);

            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText.ForEach(delegate (TextBox textBox)
            {
                //textBox.TextChanged += textBox_TextChanged;
            });
            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            Panel backColorAjustes = new Panel();
            Panel titleColorAjustes = new Panel();
            Panel textColorAjustes = new Panel();

            backColorAjustes.Name = "backColorAjustes";
            backColorAjustes.Location = new Point(171, 57);
            backColorAjustes.Size = new Size(21, 21);
            backColorAjustes.BackColor = DataClass.backOne;
            backColorAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            backColorAjustes.Visible = true;
            backColorAjustes.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColor_Click);
            panelElement.CreateAjustes.PanelGlo.Controls.Add(backColorAjustes);

            titleColorAjustes.Location = new Point(343, 57);
            backColorAjustes.Name = "titleColorAjustes";
            titleColorAjustes.Size = new Size(21, 21);
            titleColorAjustes.BackColor = DataClass.backTwo;
            titleColorAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            titleColorAjustes.Visible = true;
            titleColorAjustes.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColor_Click);
            panelElement.CreateAjustes.PanelGlo.Controls.Add(titleColorAjustes);

            textColorAjustes.Location = new Point(171, 101);
            backColorAjustes.Name = "textColorAjustes";
            textColorAjustes.Size = new Size(21, 21);
            textColorAjustes.BackColor = DataClass.backTwo;
            textColorAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            textColorAjustes.Visible = true;
            textColorAjustes.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColor_Click);
            panelElement.CreateAjustes.PanelGlo.Controls.Add(textColorAjustes);

            panelElement.PanelDe.Name = "CallToActionDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "CallToActionDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "CallToActionEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "CallToActionEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
        }

        private void panelColor_Click(object sender, MouseEventArgs e)
        {
            Color color = changeColor(sender);
            Panel panel = (Panel)sender;
            foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
            {
                if (ajustes.PanelGlo.Controls.Contains(panel))
                {
                    foreach (ClassCreatePanelElement elementos in panelesFlow)
                    {
                        if (elementos.CreateAjustes.Equals(ajustes))
                        {
                            foreach (object objeto in elementos.PanelGol.Controls)
                            {
                                if (objeto is Panel)
                                {
                                    Panel panelColor = (Panel)objeto;
                                    if (panel.Name.Contains(panelColor.Name))
                                    {
                                        panelColor.BackColor = color;
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
