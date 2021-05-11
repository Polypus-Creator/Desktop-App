﻿using System;
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
        private Boolean extendedLeftBar = true;
        private int fullWidth = Screen.PrimaryScreen.Bounds.Width;
        private int fullHeight = Screen.PrimaryScreen.Bounds.Height;
        private List<ClassCreatePanel> paneles = new List<ClassCreatePanel>();
        private int ypanels = 150;

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
            panelConst.Height = fullHeight - 100;
            panelConst.Width = fullWidth / 2;
            flowScroll.Width = panelAdd.Width+40;
            flowScroll.Height = fullHeight / 2;
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

        private void panelAdd_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> options = new List<string>();
            options.Add("Home");
            options.Add("Perfil");
            options.Add("Menu");
            options.Add("News");
            options.Add("Options");
            options.Add("Blog");
            string title = "HEADER";
            ClassCreatePanel ejempo = new ClassCreatePanel(flowScroll.Width, 6, title, options);
            paneles.Add(ejempo);
            flowScroll.Controls.Add(ejempo.PanelGol);
            ejempo.PanelGol.Location = new Point(0,ypanels);
            ypanels += 150;
        }

        
    }
}
