
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
using System.IO;

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
        Boolean isFooterAlreadyOn = false;
        Boolean firstLogin = true;
        

        public FormPrincipal()
        {
            InitializeComponent();
            initConfig();
            checkFirstLogin();
        }

        private void checkFirstLogin()
        {
            if(firstLogin)
            {
                panelFirstLogin.Visible = true;
                panelDashboard.Enabled = true;

                panelDisenyo.Enabled = false;
                //panelDisenyo.BackColor = Color.FromArgb(153, 155, 154);

                panelConstructor.Enabled = false;
                //panelConstructor.BackColor = Color.FromArgb(153, 155, 154);

                panelAjustes.Enabled = false;
                //panelAjustes.BackColor = Color.FromArgb(153, 155, 154);

                panelAyuda.Enabled = true;
            } else
            {
                // panelPorDefinir.Visible = true;
                panelDashboard.Enabled = true;
                panelFirstLogin.Visible = false;
                panelDisenyo.Enabled = true;
                panelConstructor.Enabled = true;
                panelAjustes.Enabled = true;
                panelAyuda.Enabled = true;
            }
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
            DataClass.backOne = panel8.BackColor;
            DataClass.backTwo = panel11.BackColor;
            firstLogin = true;



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
            List<string> options = new List<string>();
            options.Add("");
            options.Add("");
            options.Add("");
            options.Add("");
            options.Add("");
            options.Add("");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 6,title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelElement.PanelGol.BackColor = Color.FromArgb(175,175,175);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name= "NavBar";

            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText.ForEach(delegate (TextBox textBox)
            {
                textBox.TextChanged += textBox_TextChanged;
                textBox.LostFocus += textBoxNavBar_LostFocus;
            });
            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.TextBoxLink.LostFocus += textBoxLink_LostFocus;

            panelElement.PanelDe.Name = "NavBarPanelDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "NavBarPbDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "NavBarPanelEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "NavBarPbEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);

            ordenarPaneles();
        }

        private void ordenarPaneles()
        {
            int he = panelesFlow[0].PanelGol.Height;
            ClassCreatePanelElement navBar = null;
            ClassCreatePanelElement footer = null;
            List<ClassCreatePanelElement> newElemento = new List<ClassCreatePanelElement>();
            panelesFlow.ForEach(delegate(ClassCreatePanelElement element){
                if (element.Title.Equals("NavBar"))
                {
                    navBar = element;
                }
                else if (element.Title.Equals("Footer"))
                {
                    footer = element;
                }
            });
            if (navBar != null)
            {
                newElemento.Add(navBar);
            }
            panelesFlow.ForEach(delegate (ClassCreatePanelElement element) {
                if (!element.Title.Equals("NavBar")&& !element.Title.Equals("Footer"))
                {
                    newElemento.Add(element);
                }
            });

            if (footer!=null) {
                newElemento.Add(footer);
            }
            panelesFlow = newElemento;
            flowLayoutPanelCurrentElements.Controls.Clear();
            panelesFlow.ForEach(delegate (ClassCreatePanelElement element) {
                flowLayoutPanelCurrentElements.Controls.Add(element.PanelGol);
            });
        }

        private void textBoxNavBar_LostFocus(object sender, EventArgs e) 
        {
            TextBox textBox = (TextBox)sender;
            int fila = Int32.Parse(textBox.Name);
            if (!textBox.Text.Equals(""))
            {
                string message ="Quieres añadir un link a "+textBox.Text+"?";
                string caption = "Link";
                var result = MessageBox.Show(message, caption,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach(ClassCreatePanelAjustes ajustes in panelesAjustes)
                    {
                        if (ajustes.PanelTextos.Controls.Contains(textBox))
                        {
                            ajustes.ListLinks[fila, 0] = textBox.Text;
                            ajustes.TextBoxLink.Name = textBox.Name;
                            if (ajustes.ListLinks[fila, 1]!=null)
                            {
                                ajustes.TextBoxLink.Text = ajustes.ListLinks[fila, 1];
                            }
                            else
                            {
                                ajustes.TextBoxLink.Text = "";
                            }
                            ajustes.TextBoxLink.Visible = true;
                            ajustes.LabelLink.Visible = true;
                        }
                    }
                }
            }
        }

        private void textBoxLink_LostFocus(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            int fila = Int32.Parse(textBox.Name);
            if (!textBox.Text.Equals(""))
            {
                string message = "Quieres guardar el link?";
                string caption = "Link";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
                    {
                        if (ajustes.PanelGlo.Controls.Contains(textBox))
                        {
                            ajustes.ListLinks[fila, 1] = textBox.Text;
                            ajustes.TextBoxLink.Visible = false;
                            ajustes.LabelLink.Visible = false;
                        }
                    }
                }
            }
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
                        panel4.Controls.Remove(element.CreateAjustes.PanelGlo);
                        panelesAjustes.Remove(element.CreateAjustes);
                        panelesFlow.Remove(element);
                        break;
                    }
                }
                
                if (panel.Name.Contains("NavBar"))
                {
                    isHeaderAlreadyOn = false;
                    panel31.Enabled = true;
                }

                if (panel.Name.Contains("Footer"))
                {
                    isFooterAlreadyOn = false;
                    panel6.Enabled = true;
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
                        panel4.Controls.Remove(element.CreateAjustes.PanelGlo);
                        panelesAjustes.Remove(element.CreateAjustes);
                        panelesFlow.Remove(element);
                        break;
                    }
                }
                if (picture.Name.Contains("NavBar"))
                {
                    isHeaderAlreadyOn = false;
                    panel31.Enabled = true;
                }

                if (picture.Name.Contains("Footer"))
                {
                    isFooterAlreadyOn = false;
                    panel6.Enabled = true;
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
                    element.CreateAjustes.PanelGlo.Visible = false;
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
                    element.CreateAjustes.PanelGlo.Visible = false;
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
            DataClass.listasElementos.Clear();            
            panelesAjustes.ForEach(delegate (ClassCreatePanelAjustes panel) 
            {
                if(panel.Title == "NavBar")
                {
                    DataClass.header = new Header(panel.ListLinks, DataClass.backOne, DataClass.backTwo);
                    DataClass.listasElementos.Add(DataClass.header);
                }else if (panel.Title == "Separator")
                {
                    Separator separator = new Separator(panel.ListText[0].Text);
                    DataClass.listasElementos.Add(separator);
                }else if (panel.Title == "Call To Action")
                {
                    Color backColor = DataClass.backOne;
                    Color buttonColor = DataClass.backTwo;
                    string orientation = "left";
                    foreach (object objeto in panel.PanelTextos.Controls)
                    {
                        if (objeto is Panel)
                        {
                            Panel panelCo = (Panel)objeto;
                            if (panelCo.Name.Equals("buttonColorAjustes"))
                            {
                                buttonColor = panelCo.BackColor;
                            }
                        }else if (objeto is ComboBox)
                        {
                            ComboBox comboBox = (ComboBox)objeto;
                            orientation = comboBox.SelectedItem.ToString();
                        }
                    }
                    CallToAction callToaction = new CallToAction(panel.ListText[0].Text, panel.ListText[1].Text,backColor,buttonColor, panel.ListText[2].Text, panel.ListText[3].Text, orientation);
                    DataClass.listasElementos.Add(callToaction);
                }else if (panel.Title == "Image Text")
                {
                    string orientation = "left";
                    foreach(object objeto in panel.PanelTextos.Controls)
                    {
                        if (objeto is ComboBox)
                        {
                            ComboBox comboBox = (ComboBox)objeto;
                            orientation = comboBox.SelectedItem.ToString();
                        }
                    }
                    ImageText imageText = null;
                    if (panel.ListText[0].Text.Equals("Title") || panel.ListText[0].Text.Equals(""))
                    {
                        imageText = new ImageText(panel.ListText[2].Text, panel.ListText[1].Text, orientation);
                    }
                    else
                    {
                        imageText = new ImageText(panel.ListText[0].Text, panel.ListText[2].Text, panel.ListText[1].Text, orientation);
                    }
                    DataClass.listasElementos.Add(imageText);
                }else if (panel.Title == "Footer")
                {
                    Footer footer = new Footer(panel.ListText[0].Text);
                    DataClass.listasElementos.Add(footer);
                }else if (panel.Title == "Image")
                {
                    ClassImage image = new ClassImage("Image");
                    foreach(ClassCreatePanelElement element in panelesFlow)
                    {
                        if (element.CreateAjustes.Equals(panel))
                        {
                            element.Options.ForEach(delegate (string ruta)
                            {
                                if(ruta != null && ruta != "")
                                {
                                    image.RutasImages.Add(ruta);
                                }
                            });
                        }
                        break;
                    }
                    DataClass.listasElementos.Add(image);
                }else if (panel.Title == "Title")
                {
                    Title title = new Title("Tilte", panel.ListText[0].Text);
                    DataClass.listasElementos.Add(title);
                }
                else if (panel.Title == "Text")
                {
                    Text text = new Text("Text", panel.ListText[0].Text);
                    DataClass.listasElementos.Add(text);
                }
            });
                
            
            generateJSON(DataClass.listasElementos);
            DataClass.classListaJSON.WebName = textBoxNombre.Text;
            string obstring = JsonConvert.SerializeObject(DataClass.classListaJSON);
            JObject googleSearch = JObject.Parse(obstring);
            //textBoxBreveDescripcion.Text = googleSearch.ToString();
            MessageBox.Show(googleSearch.ToString());

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
            listasElementos.ForEach(delegate (object objeto) 
            {
                if (objeto is Header)
                {
                    string obstring = JsonConvert.SerializeObject((Header)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }else if (objeto is Separator)
                {
                    string obstring = JsonConvert.SerializeObject((Separator)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }
                else if(objeto is CallToAction)
                {
                    string obstring = JsonConvert.SerializeObject((CallToAction)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }else if (objeto is ImageText)
                {
                    string obstring = JsonConvert.SerializeObject((ImageText)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }else if (objeto is Footer)
                {
                    string obstring = JsonConvert.SerializeObject((Footer)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }else if(objeto is ClassImage)
                {
                    string obstring = JsonConvert.SerializeObject((ClassImage)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }
                else if (objeto is Title)
                {
                    string obstring = JsonConvert.SerializeObject((Title)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }
                else if (objeto is Text)
                {
                    string obstring = JsonConvert.SerializeObject((Text)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }
            });
           
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            ClassCreatePanelAjustes ajustes = null;
            ClassCreatePanelElement elementos = null;
            foreach (ClassCreatePanelAjustes ajuste in panelesAjustes)
            {
                if (ajuste.PanelTextos.Controls.Contains(textBox))
                {
                    ajustes = ajuste;
                    break;
                }
            }
            foreach (ClassCreatePanelElement elemento in panelesFlow)
            {
                if (elemento.CreateAjustes.Equals(ajustes))
                {
                    elementos = elemento;   
                    break;
                }
            }

            if (elementos.Id == "NavBar")
            {
                elementos.LabelOptions[Int32.Parse(textBox.Name)].Visible = true;
                elementos.LabelOptions[Int32.Parse(textBox.Name)].Text = textBox.Text;
                if (elementos.LabelOptions[Int32.Parse(textBox.Name)].Text == "")
                {
                    elementos.LabelOptions[Int32.Parse(textBox.Name)].Visible = false;
                }
            }
            else if (elementos.Id == "Separator")
            {
                elementos.LabelOptions[0].Visible = true;
                elementos.LabelOptions[0].Text = textBox.Text.ToUpper();
                if (elementos.LabelOptions[0].Text == "" || elementos.LabelOptions[0].Text == "#")
                {
                    elementos.LabelOptions[0].Visible = false;

                    foreach (object objeto in elementos.PanelGol.Controls)
                    {
                        if (objeto is Panel)
                        {
                            Panel panel = (Panel)objeto;
                            if (panel.Name == "colorOne")
                            {
                                panel.Visible = false;
                                break;
                            }
                        }
                    }
                }
                else
                {
                    foreach (object objeto in elementos.PanelGol.Controls)
                    {
                        if (objeto is Panel)
                        {
                            Panel panel = (Panel)objeto;
                            if (panel.Name == "colorOne")
                            {
                                panel.Visible = true;
                                if (Regex.IsMatch(textBox.Text.Remove(0, 1), "^[0-9A-F]{6}$"))
                                {
                                    Color color = System.Drawing.ColorTranslator.FromHtml(textBox.Text);
                                    panel.BackColor = color;
                                    break;
                                }
                                else
                                {
                                    panel.BackColor = Color.White;
                                    break;
                                }

                            }
                        }
                    }
                }
            }else if (elementos.Id == "Title")
            {
                elementos.LabelOptions[Int32.Parse(textBox.Name)].Visible = true;
                elementos.LabelOptions[Int32.Parse(textBox.Name)].Text = textBox.Text;
                if (elementos.LabelOptions[Int32.Parse(textBox.Name)].Text == "")
                {
                    elementos.LabelOptions[Int32.Parse(textBox.Name)].Visible = false;
                }
            }
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
            colorOne.BackColor = DataClass.backOne;
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

            ordenarPaneles();
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
                                break;
                            }
                        }
                        break;
                    }
                    break;
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
            List<string> options = new List<string>();
            options.Add("Title");
            options.Add("Text");
            options.Add("Button Text");
            options.Add("Button Link");
            options.Add("Orientation");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 5, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "CallToAction" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120,21);
            panelElement.LabelOptions.ForEach(delegate (Label label)
            {
                label.Visible = true;
                if(label.Text.Equals("Button Text") || label.Text.Equals("Button Link")  || label.Text.Equals("Orientation"))
                {
                    label.Size = new Size(100, 21);
                }
            });

            Panel buttonColor = new Panel();
            

            panelElement.PanelColors.Add(buttonColor);
            

            buttonColor.Name = "buttonColor";
            buttonColor.Location = new Point(324, 0);
            buttonColor.Size = new Size(25, 25);
            buttonColor.BackColor = DataClass.backTwo;
            buttonColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            buttonColor.Visible = true;
            panelElement.PanelGol.Controls.Add(buttonColor);

            List<string> optionsAjustes = new List<string>();
            for(int id = 0; id<panelElement.Options.Count-1; id++)
            {
                optionsAjustes.Add(panelElement.Options[id]);
            }
            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, optionsAjustes);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            
            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            
            Panel buttonColorAjustes = new Panel();

            buttonColorAjustes.Location = new Point(148, 89);
            buttonColorAjustes.Name = "buttonColorAjustes";
            buttonColorAjustes.Size = new Size(21, 11);
            buttonColorAjustes.BackColor = DataClass.backTwo;
            buttonColorAjustes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            buttonColorAjustes.Visible = true;
            buttonColorAjustes.MouseClick += new System.Windows.Forms.MouseEventHandler(panelColor_Click);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(buttonColorAjustes);

            ComboBox comboBox = new ComboBox();
            comboBox.Items.Clear();
            comboBox.Items.Add("Right");
            comboBox.SelectedItem = "Right";
            comboBox.Items.Add("Left");
            comboBox.Items.Add("Middle");
            comboBox.Size = new Size(149, 20);
            comboBox.Location = new Point(21, 145);
            comboBox.SelectedValueChanged += new EventHandler(comboBoxLado_SelectedValueChanged);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(comboBox);

            panelElement.PanelDe.Name = "CallToActionDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "CallToActionDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "CallToActionEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "CallToActionEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);

            ordenarPaneles();
        }

        private void panelColorCallToAction_Click(object sender, EventArgs e)
        {
            Color color = changeColor(sender);
        }

        private void panelColor_Click(object sender, MouseEventArgs e)
        {
            Color color = changeColor(sender);
            Panel panel = (Panel)sender;
            foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
            {
                if (ajustes.PanelTextos.Controls.Contains(panel))
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
                                    string name = panel.Name.Replace("Ajustes", "");
                                    if (name.Equals(panelColor.Name))
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

        private void label26_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Image Text";
            List<string> options = new List<string>();
            options.Add("Title");
            options.Add("Text");
            options.Add("Path Image");
            options.Add("orientation");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 3, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "ImageText" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120, 21);
            panelElement.LabelOptions.ForEach(delegate (Label label)
            {
                label.Visible = true;
            });

            List<string> optionsAjustes = new List<string>();
            optionsAjustes.Add(panelElement.Options[0]);
            optionsAjustes.Add(panelElement.Options[2]);
            optionsAjustes.Add(panelElement.Options[1]);


            PictureBox image1 = new PictureBox();
            image1.BackColor = Color.LightGray;
            image1.Size = new Size(90, 70);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image1.Location = new Point(370, 50);
            image1.Visible = false;
            panelElement.PanelGol.Controls.Add(image1);
            panelElement.ButonsOptions.Add(image1);

            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, optionsAjustes);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText[1].MouseClick += clickTextBox_AjustesFoto;

            panelElement.CreateAjustes.ListText[1].ReadOnly = true;

            panelElement.CreateAjustes.ListText[2].Size = new Size(149,80);
            panelElement.CreateAjustes.ListText[2].Multiline = true;

            ComboBox comboBox = new ComboBox();
            comboBox.Items.Clear();
            comboBox.Items.Add("Right");
            comboBox.SelectedItem = "Right";
            comboBox.Items.Add("Left");
            comboBox.Size = new Size(149, 20);
            comboBox.Location = new Point(193, 101);
            comboBox.SelectedValueChanged += new EventHandler(comboBoxLado_SelectedValueChanged);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(comboBox);


            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "ImageTextDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "ImageTextDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "ImageTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "ImageTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);

            ordenarPaneles();
        }

        private void clickTextBox_AjustesFoto(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string rutaOrigen = picPhoto();
            if (rutaOrigen != null) {
                string[] rutas = rutaOrigen.Split('\\');
                String directory = Path.GetDirectoryName(rutaOrigen) + @"\" + Path.GetFileName(rutaOrigen);
                String newPath = @"..\..\Polypus\YourWebsites\Images\";
                textBox.Text = "\\" + rutas[rutas.Length - 1];
                if (!File.Exists(newPath + rutas[rutas.Length - 1]))
                {
                    File.Copy(directory, newPath + rutas[rutas.Length - 1]);
                }
                else
                {
                    MessageBox.Show("Nombre de fichero existente");
                }
                foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
                {
                    if (ajustes.PanelTextos.Controls.Contains(textBox))
                    {
                        foreach (ClassCreatePanelElement element in panelesFlow)
                        {
                            if (element.CreateAjustes.Equals(ajustes))
                            {
                                element.ButonsOptions[0].Image = Image.FromFile(newPath + rutas[rutas.Length - 1]);
                                element.ButonsOptions[0].Visible = true;
                            }
                            break;
                        }
                    }
                    break;
                }
            }
        }
        private string picPhoto()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            if (filename != null && filename != "")
            {
                if (Path.GetExtension(filename).ToLower().Contains("png") || Path.GetExtension(filename).ToLower().Contains("jpg") || Path.GetExtension(filename).ToLower().Contains("svg"))
                {
                    return filename;
                }

            }
            return null;
        }

        private void comboBoxLado_SelectedValueChanged(object sender, EventArgs e) 
        {
            ComboBox comboBox = (ComboBox)sender;
            foreach (ClassCreatePanelElement element in panelesFlow)
            {
                if (element.CreateAjustes.PanelTextos.Controls.Contains(comboBox))
                {
                    element.LabelOptions[element.LabelOptions.Count-1].Text = comboBox.SelectedItem.ToString();
                    break;
                }
            }
        }

        private void pictureBox10_MouseClick(object sender, MouseEventArgs e)
        {
            if(isFooterAlreadyOn == false)
            {
                string title = "Footer";
                List<string> options = new List<string>();
                options.Add("Text");
                ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 3, title, options);
                flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
                panelesFlow.Add(panelElement);
                panelElement.PanelGol.Name = "Footer" + panelesFlow.Count;
                panelElement.LabelTitle.Size = new Size(120, 21);
                panelElement.LabelOptions.ForEach(delegate (Label label)
                {
                    label.Visible = true;
                });

                panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
                panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
                panelElement.PanelGol.BackColor = Color.FromArgb(175, 175, 175);
                panelesAjustes.Add(panelElement.CreateAjustes);

                panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
                panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

                panelElement.PanelDe.Name = "FooterDelete" + panelesFlow.Count;
                panelElement.PbDe.Name = "FooterDelete" + panelesFlow.Count;

                panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
                panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

                panelElement.PanelEd.Name = "FooterTextEdit" + panelesFlow.Count;
                panelElement.PbEd.Name = "FooterTextEdit" + panelesFlow.Count;

                panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
                panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
                panel6.Enabled = false;
                isFooterAlreadyOn = true;
                ordenarPaneles();
            }
            
            
        }

        private void buttonGenerarLogoAleatorio_Click(object sender, EventArgs e)
        {
            String[] images = new string[7];
            images[0] = @"..\..\Resources\logos\logo1.png";
            images[1] = @"..\..\Resources\logos\logo2.png";
            images[2] = @"..\..\Resources\logos\logo3.png";
            images[3] = @"..\..\Resources\logos\logo4.png";
            images[4] = @"..\..\Resources\logos\logo5.png";
            images[5] = @"..\..\Resources\logos\logo6.png";
            images[6] = @"..\..\Resources\logos\logo7.png";
            Random rnd = new Random();
            int random = rnd.Next(0, 6);
            pictureBoxLogo.Image = Image.FromFile(images[random]);
            MessageBox.Show("Se ha generado un logo aleatorio.");
        }

        private void panelSelectLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string filename = openFileDialog.FileName;
            if (filename != null && filename != "")
            {
                if(Path.GetExtension(filename).ToLower().Contains("png") || Path.GetExtension(filename).ToLower().Contains("jpg") || Path.GetExtension(filename).ToLower().Contains("svg")){
                    pictureBoxLogo.Image = Image.FromFile(filename);
                }
                
            }
            
        }

        private void panelRandomLogo_Click(object sender, EventArgs e)
        {
            String[] images = new string[7];
            images[0] = @"..\..\Resources\logos\logo1.png";
            images[1] = @"..\..\Resources\logos\logo2.png";
            images[2] = @"..\..\Resources\logos\logo3.png";
            images[3] = @"..\..\Resources\logos\logo4.png";
            images[4] = @"..\..\Resources\logos\logo5.png";
            images[5] = @"..\..\Resources\logos\logo6.png";
            images[6] = @"..\..\Resources\logos\logo7.png";
            Random rnd = new Random();
            int random = rnd.Next(0, 6);
            pictureBoxLogo.Image = Image.FromFile(images[random]);
        }

        private void panel35_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Image";
            List<string> options = new List<string>();
            options.Add("");
            options.Add("");
            options.Add("");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 0, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "Image" + panelesFlow.Count;

            PictureBox image1 = new PictureBox();
            image1.BackColor = Color.LightGray;
            image1.Size = new Size(100, 80);
            image1.SizeMode = PictureBoxSizeMode.StretchImage;
            image1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image1.Location = new Point(35,40);
            image1.Visible = false;
            panelElement.PanelGol.Controls.Add(image1);
            panelElement.ButonsOptions.Add(image1);

            PictureBox image2 = new PictureBox();
            image2.BackColor = Color.LightGray;
            image2.Size = new Size(100, 80);
            image2.SizeMode = PictureBoxSizeMode.StretchImage;
            image2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image2.Location = new Point(140, 40);
            image2.Visible = false;
            panelElement.PanelGol.Controls.Add(image2);
            panelElement.ButonsOptions.Add(image2);

            PictureBox image3 = new PictureBox();
            image3.BackColor = Color.LightGray;
            image3.Size = new Size(100, 80);
            image3.SizeMode = PictureBoxSizeMode.StretchImage;
            image3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image3.Location = new Point(244, 40);
            image3.Visible = false;
            panelElement.PanelGol.Controls.Add(image3);
            panelElement.ButonsOptions.Add(image3);


            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            PictureBox image1Ajuste = new PictureBox();
            image1Ajuste.Name = "image1Ajuste";
            image1Ajuste.BackColor = Color.Transparent;
            image1Ajuste.Cursor = Cursors.Hand;
            image1Ajuste.Size = new Size(100, 100);
            image1Ajuste.SizeMode = PictureBoxSizeMode.StretchImage;
            image1Ajuste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image1Ajuste.Location = new Point(11, 59);
            image1Ajuste.Image = Desktop_App.Properties.Resources.addNewImage;
            image1Ajuste.MouseClick += new System.Windows.Forms.MouseEventHandler(ImageAjustes_MouseClick);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(image1Ajuste);
            panelElement.CreateAjustes.ListaImages.Add(image1Ajuste);

            PictureBox image2Ajuste = new PictureBox();
            image2Ajuste.Name = "image2Ajuste";
            image2Ajuste.BackColor = Color.Transparent;
            image2Ajuste.Cursor = Cursors.Hand;
            image2Ajuste.Size = new Size(100, 100);
            image2Ajuste.SizeMode = PictureBoxSizeMode.StretchImage;
            image2Ajuste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image2Ajuste.Location = new Point(122, 59);
            image2Ajuste.Image = Desktop_App.Properties.Resources.addNewImage;
            image2Ajuste.MouseClick += new System.Windows.Forms.MouseEventHandler(ImageAjustes_MouseClick);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(image2Ajuste);
            panelElement.CreateAjustes.ListaImages.Add(image2Ajuste);

            PictureBox image3Ajuste = new PictureBox();
            image3Ajuste.Name = "image3Ajuste";
            image3Ajuste.BackColor = Color.Transparent;
            image3Ajuste.Cursor = Cursors.Hand;
            image3Ajuste.Size = new Size(100, 100);
            image3Ajuste.SizeMode = PictureBoxSizeMode.StretchImage;
            image3Ajuste.Image = Desktop_App.Properties.Resources.addNewImage;
            image3Ajuste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            image3Ajuste.Location = new Point(233, 59);
            image3Ajuste.MouseClick += new System.Windows.Forms.MouseEventHandler(ImageAjustes_MouseClick);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(image3Ajuste);
            panelElement.CreateAjustes.ListaImages.Add(image3Ajuste);

            Panel panelDelete1 = new Panel();
            panelDelete1.Name = "panelDelete1";
            panelDelete1.Location = new Point(100, 45);
            panelDelete1.Size = new Size(15, 15);
            panelDelete1.Cursor = Cursors.Hand;
            panelDelete1.BackColor = Color.FromArgb(96, 71, 71);
            panelDelete1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelDelete1.Visible = true;
            panelDelete1.MouseClick += new System.Windows.Forms.MouseEventHandler(DeleteImageAjustes_MouseClick);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(panelDelete1);
            panelElement.CreateAjustes.DeleteImage.Add(panelDelete1);

            Label labelX1 = new Label();
            labelX1.Name = "labelX1";
            labelX1.Size = new Size(10, 10);
            labelX1.Cursor = Cursors.Hand;
            labelX1.Location = new Point(0, 0);
            labelX1.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            labelX1.Text = "X";
            labelX1.ForeColor = Color.White;
            labelX1.Visible = true;
            labelX1.MouseClick += new System.Windows.Forms.MouseEventHandler(DeleteImageAjustes_MouseClick);
            panelDelete1.Controls.Add(labelX1);

            Panel panelDelete2 = new Panel();
            panelDelete2.Name = "panelDelete2";
            panelDelete2.Location = new Point(210, 45);
            panelDelete2.Size = new Size(15, 15);
            panelDelete2.Cursor = Cursors.Hand;
            panelDelete2.BackColor = Color.FromArgb(96, 71, 71);
            panelDelete2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelDelete2.Visible = true;
            panelDelete2.MouseClick += new System.Windows.Forms.MouseEventHandler(DeleteImageAjustes_MouseClick);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(panelDelete2);
            panelElement.CreateAjustes.DeleteImage.Add(panelDelete2);

            Label labelX2 = new Label();
            labelX2.Name = "labelX2";
            labelX2.Size = new Size(10, 10);
            labelX2.Cursor = Cursors.Hand;
            labelX2.Location = new Point(0, 0);
            labelX2.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            labelX2.Text = "X";
            labelX2.ForeColor = Color.White;
            labelX2.Visible = true;
            labelX2.MouseClick += new System.Windows.Forms.MouseEventHandler(DeleteImageAjustes_MouseClick);
            panelDelete2.Controls.Add(labelX2);

            Panel panelDelete3 = new Panel();
            panelDelete3.Name = "panelDelete3";
            panelDelete3.Location = new Point(320, 45);
            panelDelete3.Size = new Size(15, 15);
            panelDelete3.Cursor = Cursors.Hand;
            panelDelete3.BackColor = Color.FromArgb(96, 71, 71);
            panelDelete3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            panelDelete3.Visible = true;
            panelDelete3.MouseClick += new System.Windows.Forms.MouseEventHandler(DeleteImageAjustes_MouseClick);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(panelDelete3);
            panelElement.CreateAjustes.DeleteImage.Add(panelDelete3);

            Label labelX3 = new Label();
            labelX3.Name = "labelX3";
            labelX3.Size = new Size(10, 10);
            labelX3.Cursor = Cursors.Hand;
            labelX3.Location = new Point(0, 0);
            labelX3.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            labelX3.Text = "X";
            labelX3.ForeColor = Color.White;
            labelX3.Visible = true;
            labelX3.MouseClick += new System.Windows.Forms.MouseEventHandler(DeleteImageAjustes_MouseClick);
            panelDelete3.Controls.Add(labelX3);

            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "ImageDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "ImageDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "ImageTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "ImageTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            
            ordenarPaneles();
        }

        private void ImageAjustes_MouseClick(object sender, EventArgs e)
        {
            PictureBox imageAjustes = (PictureBox)sender;
            string rutaOrigen = picPhoto();
            if (rutaOrigen != null && rutaOrigen != "")
            {
                if (Path.GetExtension(rutaOrigen).ToLower().Contains("png") || Path.GetExtension(rutaOrigen).ToLower().Contains("jpg") || Path.GetExtension(rutaOrigen).ToLower().Contains("svg"))
                {
                    string[] rutas = rutaOrigen.Split('\\');
                    String directory = Path.GetDirectoryName(rutaOrigen) + @"\" + Path.GetFileName(rutaOrigen);
                    String newPath = @"..\..\Polypus\YourWebsites\Images\";
                    if (!File.Exists(newPath + rutas[rutas.Length - 1]))
                    {
                        File.Copy(directory, newPath + rutas[rutas.Length - 1]);
                    }
                    else
                    {
                        MessageBox.Show("Nombre de fichero existente");
                    }
                    imageAjustes.Image = Image.FromFile(newPath + rutas[rutas.Length - 1]);
                    foreach(ClassCreatePanelAjustes ajustes in panelesAjustes)
                    {
                        if (ajustes.PanelTextos.Controls.Contains(imageAjustes))
                        {
                            foreach(ClassCreatePanelElement element in panelesFlow)
                            {
                                if (element.CreateAjustes.Equals(ajustes))
                                {
                                    if (imageAjustes.Name.Contains("1"))
                                    {
                                        element.ButonsOptions[0].Image = Image.FromFile(newPath + rutas[rutas.Length - 1]);
                                        element.ButonsOptions[0].Visible = true;
                                        element.Options[0] = "\\" + rutas[rutas.Length - 1];
                                        break;
                                    }
                                    else if (imageAjustes.Name.Contains("2"))
                                    {
                                        element.ButonsOptions[1].Image = Image.FromFile(newPath + rutas[rutas.Length - 1]);
                                        element.ButonsOptions[1].Visible = true;
                                        element.Options[1] = "\\" + rutas[rutas.Length - 1];
                                        break;
                                    }
                                    else if (imageAjustes.Name.Contains("3"))
                                    {
                                        element.ButonsOptions[2].Image = Image.FromFile(newPath + rutas[rutas.Length - 1]);
                                        element.ButonsOptions[2].Visible = true;
                                        element.Options[2] = "\\" + rutas[rutas.Length - 1];
                                        break;
                                    }
                                    
                                }
                            }
                            break;
                        }
                    }
                }

            }
        }

        private void DeleteImageAjustes_MouseClick(object sender, EventArgs e)
        {
            if (sender is Panel)
            {
                Panel panelDelete = (Panel)sender;
                foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
                {
                    if (ajustes.PanelTextos.Controls.Contains(panelDelete))
                    {
                        foreach (ClassCreatePanelElement element in panelesFlow)
                        {
                            if (element.CreateAjustes.Equals(ajustes))
                            {
                                if (panelDelete.Name.Contains("1"))
                                {
                                    ajustes.ListaImages[0].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[0].Image = null;
                                    element.ButonsOptions[0].Visible = false;
                                    element.Options[0] = null;
                                    break;
                                }
                                else if (panelDelete.Name.Contains("2"))
                                {
                                    ajustes.ListaImages[1].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[1].Image = null;
                                    element.ButonsOptions[1].Visible = false;
                                    element.Options[1] = null;
                                    break;
                                }
                                else if (panelDelete.Name.Contains("3"))
                                {
                                    ajustes.ListaImages[2].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[2].Image = null;
                                    element.ButonsOptions[2].Visible = false;
                                    element.Options[2] = null;
                                    break;
                                }

                            }
                        }
                        break;
                    }
                }
            }
            else
            {
                Label labelDelete = (Label)sender;
                Panel panelDelete = null;
                foreach (ClassCreatePanelAjustes ajust in panelesAjustes)
                {
                    foreach (object objeto in ajust.PanelTextos.Controls)
                    {
                        if(objeto is Panel)
                        {
                            Panel panel = (Panel)objeto;
                            if (panel.Controls.Contains(labelDelete))
                            {
                                panelDelete = panel;
                                break;
                            }
                        }
                    }
                    if(panelDelete != null)
                    {
                        break;
                    }
                }
                foreach (ClassCreatePanelAjustes ajustes in panelesAjustes)
                {
                    if (ajustes.PanelTextos.Controls.Contains(panelDelete))
                    {
                        foreach (ClassCreatePanelElement element in panelesFlow)
                        {
                            if (element.CreateAjustes.Equals(ajustes))
                            {
                                if (panelDelete.Name.Contains("1"))
                                {
                                    ajustes.ListaImages[0].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[0].Image = null;
                                    element.ButonsOptions[0].Visible = false;
                                    element.Options[0] = null;
                                    break;
                                }
                                else if (panelDelete.Name.Contains("2"))
                                {
                                    ajustes.ListaImages[1].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[1].Image = null;
                                    element.ButonsOptions[1].Visible = false;
                                    element.Options[1] = null;
                                    break;
                                }
                                else if (panelDelete.Name.Contains("3"))
                                {
                                    ajustes.ListaImages[2].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[2].Image = null;
                                    element.ButonsOptions[2].Visible = false;
                                    element.Options[2] = null;
                                    break;
                                }

                            }
                        }
                        break;
                    }
                }
            }
        }

        private void pictureBox21_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Title";
            List<string> options = new List<string>();
            options.Add("");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 1, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "Title" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120, 21);
            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText[0].TextChanged += textBox_TextChanged;
            panelElement.CreateAjustes.ListText[0].Size = new Size(350, 20);
            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "TitleDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "TitleDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "TitleTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "TitleTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            ordenarPaneles();
        }

        private void label54_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Text";
            List<string> options = new List<string>();
            options.Add("Text");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, 1, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "Text" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120, 21);
            panelElement.LabelOptions[0].Visible = true;
            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText[0].Multiline = true;
            panelElement.CreateAjustes.ListText[0].Text = "";
            panelElement.CreateAjustes.ListText[0].Size = new Size(350, 124);

            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "TextDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "TextDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "TextTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "TextTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            ordenarPaneles();
        }

        private void panelSelectLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEmpezar_Click(object sender, EventArgs e)
        {
            firstLogin = false;
            // guardar todos los datos introducidos
            MessageBox.Show("Tu configuración se ha guardado. Bienvenido, ya puedes empezar a utilizar Polypus Creator.");
            checkFirstLogin();
        }
    }
}
