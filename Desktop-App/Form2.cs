using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop_App
{
    public partial class Form2 : Form
    {
        Boolean extendedLeftBar = true;
        Boolean displayFaqs = false;
        Boolean stayLogged = false;
        int fullWidth = Screen.PrimaryScreen.Bounds.Width;
        int fullHeight = Screen.PrimaryScreen.Bounds.Height;
        List<String> listFiles = new List<String>();

        public Form2()
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
            }
            if (option == 2)
            {
                panelDashboard.BackColor = Color.FromArgb(49, 48, 45);
                panelDisenyo.BackColor = Color.FromArgb(96, 71, 71);
                panelConstructor.BackColor = Color.FromArgb(49, 48, 45);
                panelAjustes.BackColor = Color.FromArgb(49, 48, 45);
                panelAyuda.BackColor = Color.FromArgb(49, 48, 45);
                tabControl.SelectedTab = disenyo;
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
            }
            if (option == 5)
            {
                panelDashboard.BackColor = Color.FromArgb(49, 48, 45);
                panelDisenyo.BackColor = Color.FromArgb(49, 48, 45);
                panelConstructor.BackColor = Color.FromArgb(49, 48, 45);
                panelAjustes.BackColor = Color.FromArgb(49, 48, 45);
                panelAyuda.BackColor = Color.FromArgb(96, 71, 71);
                tabControl.SelectedTab = ayuda;
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
            changeColor(sender);
        }

        private void changeColor(object sender)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                if(sender is Panel)
                {
                    ((Panel)sender).BackColor = colorPicker.Color;

                }
            }
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            changeColor(sender);
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
    }
}
