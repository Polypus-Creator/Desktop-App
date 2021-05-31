
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
        Boolean panelConstDetalleShow = false;
        int timerCount = 0;
        

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

                panelDisenyo.Visible = false;

                panelConstructor.Visible = false;

                panelAjustes.Visible = false;
                panelAyuda.Location = new Point(1, 121);
                panelAyuda.Enabled = true;
                panelInfoDashboard.Visible = false;
                panelSavedFirsTime.Visible = false;

            } else
            {
                // panelPorDefinir.Visible = true;
                panelDashboard.Enabled = true;
                panelFirstLogin.Visible = false;
                panelDisenyo.Visible = true;
                panelConstructor.Visible = true;
                panelAjustes.Visible = true;
                panelAyuda.Visible = true;
                panelAyuda.Location = new Point(1, 345);
                panelInfoDashboard.Visible = true;
                panelInfoDashboard.Location = new Point(9, 66);
                timerPanelGuardado.Start();

            }
        }


        private void labelIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void initConfig()
        {

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
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
            panel4.Height = panelConst.Height - 20;
            //panelUsuario.Location = new Point(fullHeight / 2);
            

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
                panelPrevisualizar.Visible = false;
                panelFinalizarWeb.Visible = false;
                panelUsuario.Visible = false;


            }
            else
            {
                hideShowBar.Image = Desktop_App.Properties.Resources.left_arrow;
                extendedLeftBar = true;
                panelLeftBar.Width = 216;
                hideShowBar.Location = new Point(panelWidth - 35,14);
                tabControl.Location = new Point(223, 30);
                tabControl.Width = fullWidth - 227;
                panelPrevisualizar.Visible = true;
                panelFinalizarWeb.Visible = true;
                panelUsuario.Visible = true;
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
            timerPanelGuardado.Start();
            labelFirstTimeSaved.Text = "Color guardado!";
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
            timerPanelGuardado.Start();
            labelFirstTimeSaved.Text = "Color guardado!";
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
                panelFaqs.Width = 736;
                panelFaqs.Height = 394;
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
                    }
                }
            }
            
            
            
        }

        private void PanelSave_MousClick(object sender, EventArgs e)
        {
            DataClass.listasElementos.Clear();
            timerPanelGuardado.Start();
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
                    foreach (ClassCreatePanelElement element in panelesFlow) {
                        if (element.CreateAjustes.Equals(panel)){
                            element.Options.ForEach(delegate (string ruta)
                            {
                                if (ruta != null && ruta != "")
                                {
                                    image.RutasImages.Add(ruta);
                                }

                            });
                            
                        }
                        
                    }
                    DataClass.listasElementos.Add(image);
                }else if (panel.Title == "Title")
                {
                    Title title = new Title("Title", panel.ListText[0].Text);
                    DataClass.listasElementos.Add(title);
                }
                else if (panel.Title == "Text")
                {
                    Text text = new Text("Text", panel.ListText[0].Text);
                    DataClass.listasElementos.Add(text);
                }
                else if (panel.Title == "Price Cards")
                {
                    string[,] contenido = new string[3, 4];
                    foreach(object objeto in panel.PanelTextos.Controls)
                    {
                        if (objeto is TextBox)
                        {
                            TextBox text = (TextBox)objeto;
                            if (text.Name.Contains("Title"))
                            {
                                if (text.Name.Contains("1"))
                                {
                                    contenido[0, 0] = text.Text;
                                }
                                else if (text.Name.Contains("2"))
                                {
                                    contenido[1, 0] = text.Text;
                                }
                                else if (text.Name.Contains("3"))
                                {
                                    contenido[2, 0] = text.Text;
                                }
                            }
                            else if (text.Name.Contains("Price"))
                            {
                                if (text.Name.Contains("1"))
                                {
                                    contenido[0, 1] = text.Text;
                                }
                                else if (text.Name.Contains("2"))
                                {
                                    contenido[1, 1] = text.Text;
                                }
                                else if (text.Name.Contains("3"))
                                {
                                    contenido[2, 1] = text.Text;
                                }
                            }
                            else if (text.Name.Contains("Descr"))
                            {
                                if (text.Name.Contains("1"))
                                {
                                    contenido[0, 3] = text.Text;
                                }
                                else if (text.Name.Contains("2"))
                                {
                                    contenido[1, 3] = text.Text;
                                }
                                else if (text.Name.Contains("3"))
                                {
                                    contenido[2, 3] = text.Text;
                                }
                            }
                        }
                        else if (objeto is ComboBox)
                        {
                            ComboBox text = (ComboBox)objeto;
                            if (text.Name.Contains("1"))
                            {
                                contenido[0, 2] = text.SelectedItem.ToString();
                            }
                            else if (text.Name.Contains("2"))
                            {
                                contenido[1, 2] = text.SelectedItem.ToString();
                            }
                            else if (text.Name.Contains("3"))
                            {
                                contenido[2, 2] = text.SelectedItem.ToString();
                            }
                        }
                    }
                    PriceCard price = new PriceCard("Price Card", contenido);
                    DataClass.listasElementos.Add(price);
                }
                else if (panel.Title == "Button")
                {
                    ClassButton button = new ClassButton("Button", panel.ListText[0].Text, panel.ListText[1].Text);
                    DataClass.listasElementos.Add(button);
                }
                else if (panel.Title == "Mapa")
                {
                    string[] iframe = panel.ListText[4].Text.Split('"');
                    string text = iframe[0] + '"' + iframe[1] + " "+'"' +  "allowfullscreen="+'"'+'"'+ " loading="+'"'+"lazy"+'"'+ "></iframe>";

                    Mapa button = new Mapa("Mapa", text, panel.ListText[5].Text, panel.ListText[0].Text, panel.ListText[1].Text, panel.ListText[2].Text, panel.ListText[3].Text);
                    DataClass.listasElementos.Add(button);
                }
            });
                
            
            generateJSON(DataClass.listasElementos);
            string obstring = JsonConvert.SerializeObject(DataClass.classListaJSON);
            JObject googleSearch = JObject.Parse(obstring);
            Console.WriteLine(googleSearch.ToString());

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
            DataClass.classListaJSON.ListaJSON.Clear();
            listasElementos.ForEach(delegate (object objeto) 
            {
                if (objeto is Header)
                {
                    DataClass.classListaJSON.Header = (Header)objeto;
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
                    DataClass.classListaJSON.Footer = (Footer)objeto;
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
                else if (objeto is PriceCard)
                {
                    string obstring = JsonConvert.SerializeObject((PriceCard)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }
                else if (objeto is ClassButton)
                {
                    string obstring = JsonConvert.SerializeObject((ClassButton)objeto);
                    JObject googleSearch = JObject.Parse(obstring);
                    DataClass.classListaJSON.ListaJSON.Add(googleSearch);
                }
                else if (objeto is Mapa)
                {
                    string obstring = JsonConvert.SerializeObject((Mapa)objeto);
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
            else if (elementos.Id == "Button")
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
                                    ajustes.ListItems[0] = null;
                                    break;
                                }
                                else if (panelDelete.Name.Contains("2"))
                                {
                                    ajustes.ListaImages[1].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[1].Image = null;
                                    element.ButonsOptions[1].Visible = false;
                                    ajustes.ListItems[1] = null;
                                    break;
                                }
                                else if (panelDelete.Name.Contains("3"))
                                {
                                    ajustes.ListaImages[2].Image = Desktop_App.Properties.Resources.addNewImage; ;
                                    element.ButonsOptions[2].Image = null;
                                    element.ButonsOptions[2].Visible = false;
                                    ajustes.ListItems[2] = null;
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
            checkFirstLogin();
            
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            string title = "Price Cards";
            List<string> options = new List<string>();
            options.Add("Title");
            options.Add("Title");
            options.Add("Title");
            options.Add("Price");
            options.Add("Price");
            options.Add("Price");
            options.Add("Description");
            options.Add("Description");
            options.Add("Description");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, options.Count, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "PriceCards" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120, 21);
            panelElement.LabelOptions.ForEach(delegate (Label label)
            {
                label.Visible = true;
            });
            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, panel4.Height-140, panelElement.Title, new List<string>());
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.PanelTextos.Height = panelElement.CreateAjustes.PanelGlo.Height - panelElement.CreateAjustes.PanelSave.Height - 75;
            panelElement.CreateAjustes.PanelSave.Location = new Point(panelElement.CreateAjustes.PanelSave.Location.X, panelElement.CreateAjustes.PanelGlo.Height - panelElement.CreateAjustes.PanelSave.Height - 5);

            CrearAjustesPriceCard(panelElement.CreateAjustes);

            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "PriceCardsDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "PriceCardsDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "PriceCardsTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "PriceCardsTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            ordenarPaneles();
        }

        private void CrearAjustesPriceCard(ClassCreatePanelAjustes createAjustes)
        {
            int x1 = 5, y1=57;
            int H = createAjustes.PanelTextos.Height/3;
            int W = createAjustes.PanelTextos.Width-10;
            int marg= H/5/3;

            TextBox textBox1 = new TextBox();
            textBox1.Name = "Title1";
            textBox1.Location = new Point(x1, y1);
            textBox1.Size = new Size(W/2-20,H/5);
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox1);
            createAjustes.PanelTextos.Controls.Add(textBox1);

            int x2 = x1 + textBox1.Width + 10;

            TextBox textBox2 = new TextBox();
            textBox2.Name = "Price1";
            textBox2.Location = new Point(x2, y1);
            textBox2.TextAlign = HorizontalAlignment.Right;
            textBox2.Size = new Size(W / 4 - 20, H / 5);
            textBox2.TextChanged += textBoxPrice_TextChanged;
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox2);
            createAjustes.PanelTextos.Controls.Add(textBox2);

            int x3 = x2 + textBox2.Width + 10;

            ComboBox comboBox3 = new ComboBox();
            comboBox3.Name = "Moneda1";
            comboBox3.Location = new Point(x3, y1);
            comboBox3.Size = new Size(W / 4 - 20, H / 5);
            comboBox3.Items.Add("$");
            comboBox3.Items.Add("€");
            comboBox3.Items.Add("£");
            comboBox3.SelectedIndex = 0;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            createAjustes.ListaMoneda.Add(comboBox3);
            createAjustes.PanelTextos.Controls.Add(comboBox3);

            int y2 = y1 + textBox1.Height + marg;

            TextBox textBox4 = new TextBox();
            textBox4.Name = "Descrip1";
            textBox4.Location = new Point(x1, y2);
            textBox4.Size = new Size(W, H * 3 / 5);
            textBox4.Multiline = true;
            textBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox4);
            createAjustes.PanelTextos.Controls.Add(textBox4);

            int y3 = y2 + textBox4.Height + 5, y4 = y3 + textBox1.Height + marg;
            

            TextBox textBox5 = new TextBox();
            textBox5.Name = "Title2";
            textBox5.Location = new Point(x1, y3);
            textBox5.Size = new Size(W / 2 - 20, H / 5);
            textBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox5);
            createAjustes.PanelTextos.Controls.Add(textBox5);

            TextBox textBox6 = new TextBox();
            textBox6.Name = "Price2";
            textBox6.TextAlign = HorizontalAlignment.Right;
            textBox6.Location = new Point(x2, y3);
            textBox6.Size = new Size(W / 4 - 20, H / 5);
            textBox6.TextChanged += textBoxPrice_TextChanged;
            textBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox6);
            createAjustes.PanelTextos.Controls.Add(textBox6);

            ComboBox comboBox7 = new ComboBox();
            comboBox7.Name = "Moneda2";
            comboBox7.Location = new Point(x3, y3);
            comboBox7.Size = new Size(W / 4 - 20, H / 5);
            comboBox7.Items.Add("$");
            comboBox7.Items.Add("€");
            comboBox7.Items.Add("£");
            comboBox7.SelectedIndex = 0;
            comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            createAjustes.ListaMoneda.Add(comboBox7);
            createAjustes.PanelTextos.Controls.Add(comboBox7);

            TextBox textBox8 = new TextBox();
            textBox8.Name = "Descrip2";
            textBox8.Location = new Point(x1, y4);
            textBox8.Size = new Size(W, H * 3 / 5);
            textBox8.Multiline = true;
            textBox8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox8);
            createAjustes.PanelTextos.Controls.Add(textBox8);

            int y5 = y4 + textBox4.Height + 5, y6 = y5 + textBox1.Height + marg;

            TextBox textBox9 = new TextBox();
            textBox9.Name = "Title3";
            textBox9.Location = new Point(x1, y5);
            textBox9.Size = new Size(W / 2 - 20, H / 5);
            textBox9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox9);
            createAjustes.PanelTextos.Controls.Add(textBox9);

            TextBox textBox10 = new TextBox();
            textBox10.Name = "Price3";
            textBox10.Location = new Point(x2, y5);
            textBox10.Size = new Size(W / 4 - 20, H / 5);
            textBox10.TextAlign = HorizontalAlignment.Right;
            textBox10.TextChanged += textBoxPrice_TextChanged;
            textBox10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox10);
            createAjustes.PanelTextos.Controls.Add(textBox10);

            ComboBox comboBox11 = new ComboBox();
            comboBox11.Name = "Moneda3";
            comboBox11.Location = new Point(x3, y5);
            comboBox11.Size = new Size(W / 4 - 20, H / 5);
            comboBox11.Items.Add("$");
            comboBox11.Items.Add("€");
            comboBox11.Items.Add("£");
            comboBox11.SelectedIndex = 0;
            comboBox11.DropDownStyle = ComboBoxStyle.DropDownList;
            createAjustes.ListaMoneda.Add(comboBox11);
            createAjustes.PanelTextos.Controls.Add(comboBox11);

            TextBox textBox12 = new TextBox();
            textBox12.Name = "Descrip3";
            textBox12.Location = new Point(x1, y6);
            textBox12.Multiline = true;
            textBox12.Size = new Size(W, H * 3 / 5);
            textBox12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            createAjustes.ListText.Add(textBox12);
            createAjustes.PanelTextos.Controls.Add(textBox12);
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            try
            {
                Regex regexObj = new Regex(@"[^\d]");
                text.Text = regexObj.Replace(text.Text, "");
                text.Select(text.Text.Length, 0);
            }
            catch (ArgumentException ex)
            {
                
            }
        }

        private void panelDesconectar_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        private void pictureBoxFuenteAyuda_Click(object sender, EventArgs e)
        {
            panelAyudaFuente.Visible = true;
        }



        private void panelPrevisualizar_Click(object sender, EventArgs e)
        {
            // codigo de generar la web
            //panelFinalizarWeb.Enabled = true;
        }

        private void panelOcultarAyuda_Click_2(object sender, EventArgs e)
        {
            panelAyudaFuente.Visible = false;
        }

        private void pictureBox24_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Button";
            List<string> options = new List<string>();
            options.Add("Text");
            options.Add("Link");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, options.Count, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "Button" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120, 21);
            panelElement.LabelOptions.ForEach(delegate (Label label)
            {
                label.Visible = true;
            });
            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 310, panelElement.Title, panelElement.Options);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.ListText.ForEach(delegate (TextBox text)
            {
                text.TextChanged += textBox_TextChanged;
            });

            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "ButtonDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "ButtonDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "ButtonTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "ButtonTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            ordenarPaneles();
        }


        private void pictureBox28_MouseClick(object sender, MouseEventArgs e)
        {
            string title = "Mapa";
            List<string> options = new List<string>();
            options.Add("Google");
            options.Add("Title");
            options.Add("Correo");
            options.Add("Tel.");
            options.Add("Hora");
            options.Add("Web");
            ClassCreatePanelElement panelElement = new ClassCreatePanelElement(482, options.Count, title, options);
            flowLayoutPanelCurrentElements.Controls.Add(panelElement.PanelGol);
            panelesFlow.Add(panelElement);
            panelElement.PanelGol.Name = "Mapa" + panelesFlow.Count;
            panelElement.LabelTitle.Size = new Size(120, 21);
            panelElement.LabelOptions.ForEach(delegate (Label label)
            {
                label.Visible = true;
            });
            List<string> option2 = new List<string>();
            option2.Add("Correo");
            option2.Add("Teléfono");
            option2.Add("Horario");
            option2.Add("Web");
            panelElement.CreateAjustes = new ClassCreatePanelAjustes(410, 355, panelElement.Title,option2, 57 + 40 + 24+44);
            panel4.Controls.Add(panelElement.CreateAjustes.PanelGlo);
            panelesAjustes.Add(panelElement.CreateAjustes);

            panelElement.CreateAjustes.PanelTextos.Height = 229;
            panelElement.CreateAjustes.PanelSave.Location = new Point(panelElement.CreateAjustes.PanelSave.Location.X, panelElement.CreateAjustes.PanelGlo.Height - panelElement.CreateAjustes.PanelSave.Height - 5);

            TextBox iframe = new TextBox();
            iframe.Name = "iframe";
            iframe.Multiline = true;
            iframe.Size = new Size(149*2+23, 40);
            iframe.Location = new Point(21, 57);
            iframe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelElement.CreateAjustes.ListText.Add(iframe);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(iframe);

            TextBox tbTitle = new TextBox();
            tbTitle.Name = "title";
            tbTitle.Size = new Size(149 * 2+23, 20);
            tbTitle.Location = new Point(21, 57+40+24);
            tbTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panelElement.CreateAjustes.ListText.Add(tbTitle);
            panelElement.CreateAjustes.PanelTextos.Controls.Add(tbTitle);

            panelElement.CreateAjustes.ListText[0].LostFocus += CorreoValidator_LostFocus;
            panelElement.CreateAjustes.ListText[1].LostFocus += PhoneValidator_LostFocus;

            panelElement.CreateAjustes.PanelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);
            panelElement.CreateAjustes.LabelSave.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelSave_MousClick);

            panelElement.PanelDe.Name = "MapaDelete" + panelesFlow.Count;
            panelElement.PbDe.Name = "MapaDelete" + panelesFlow.Count;

            panelElement.PanelDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);
            panelElement.PbDe.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelDe_MouseClicked);

            panelElement.PanelEd.Name = "MapaTextEdit" + panelesFlow.Count;
            panelElement.PbEd.Name = "MapaTextEdit" + panelesFlow.Count;

            panelElement.PanelEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            panelElement.PbEd.MouseClick += new System.Windows.Forms.MouseEventHandler(PanelEd_MouseClick);
            ordenarPaneles();
        }

        private void CorreoValidator_LostFocus(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            try
            {
                /*Regex regexObj = new Regex(@"^[^@\s] +@[^@\s] +\.[^@\s]+$");
                if (!regexObj.Match(text.Text).Success)
                {
                    MessageBox.Show("Correo no valido");
                }*/
            }
            catch (ArgumentException ex)
            {

            }
        }

        private void PhoneValidator_LostFocus(object sender, EventArgs e)
        {
            TextBox text = (TextBox)sender;
            try
            {
                /*Regex regexObj = new Regex(@"^(\+[0-9]{9})$");
                if (!regexObj.Match(text.Text).Success)
                {
                    MessageBox.Show("Teléfono no valido");
                }*/
            }
            catch (ArgumentException ex)
            {

            }
        }

        private void buttonCambiarConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void timerPanelGuardado_Tick(object sender, EventArgs e)
        {

            if(timerCount == 3)
            {
                panelSavedFirsTime.Visible = false;
                timerPanelGuardado.Stop();
                timerCount = 0;
            }
            else
            {
                panelSavedFirsTime.Visible = true;

            }
            timerCount++;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            timerPanelGuardado.Start();
            labelFirstTimeSaved.Text = "La fuente es " + comboBoxFont.SelectedItem + "!";
        }

        private void showHideConstDetalle_Click(object sender, EventArgs e)
        {
            if (panelConstDetalleShow == false)
            {
                panelConstDetalle.Visible = true;
                showHideConstDetalle.Image = Desktop_App.Properties.Resources.arrow_up;
                panelConstDetalleShow = true;
                panelConstDetalle.Width = 736;
                panelConstDetalle.Height = 394;
            }
            else
            {
                panelConstDetalle.Visible = false;
                showHideConstDetalle.Image = Desktop_App.Properties.Resources.arrow_down;
                panelConstDetalleShow = false;
            }
        }
    }
}
