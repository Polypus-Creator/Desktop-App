
namespace Desktop_App
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.windowControlButtons = new System.Windows.Forms.Panel();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelLeftBar = new System.Windows.Forms.Panel();
            this.panelAyuda = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAjustes = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelConstructor = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelDisenyo = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelTopSideBar = new System.Windows.Forms.Panel();
            this.hideShowBar = new System.Windows.Forms.PictureBox();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.windowControlButtons.SuspendLayout();
            this.panelLeftBar.SuspendLayout();
            this.panelAyuda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panelAjustes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelConstructor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelDisenyo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelTopSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hideShowBar)).BeginInit();
            this.panelDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.labelIniciarSesion);
            this.panelSuperior.Controls.Add(this.windowControlButtons);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(824, 54);
            this.panelSuperior.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.labelIniciarSesion.Location = new System.Drawing.Point(47, 12);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(168, 30);
            this.labelIniciarSesion.TabIndex = 3;
            this.labelIniciarSesion.Text = "Polypus Creator";
            this.labelIniciarSesion.Click += new System.EventHandler(this.labelIniciarSesion_Click);
            // 
            // windowControlButtons
            // 
            this.windowControlButtons.Controls.Add(this.labelMinimize);
            this.windowControlButtons.Controls.Add(this.labelClose);
            this.windowControlButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowControlButtons.Location = new System.Drawing.Point(716, 0);
            this.windowControlButtons.Name = "windowControlButtons";
            this.windowControlButtons.Size = new System.Drawing.Size(105, 51);
            this.windowControlButtons.TabIndex = 1;
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.Color.White;
            this.labelMinimize.Location = new System.Drawing.Point(16, 4);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(29, 40);
            this.labelMinimize.TabIndex = 1;
            this.labelMinimize.Text = "-";
            this.labelMinimize.Click += new System.EventHandler(this.labelMinimize_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(58, 10);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(31, 32);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panelLeftBar
            // 
            this.panelLeftBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelLeftBar.Controls.Add(this.panelAyuda);
            this.panelLeftBar.Controls.Add(this.panelAjustes);
            this.panelLeftBar.Controls.Add(this.panelConstructor);
            this.panelLeftBar.Controls.Add(this.panelDisenyo);
            this.panelLeftBar.Controls.Add(this.panelTopSideBar);
            this.panelLeftBar.Controls.Add(this.panelDashboard);
            this.panelLeftBar.Location = new System.Drawing.Point(0, 51);
            this.panelLeftBar.Name = "panelLeftBar";
            this.panelLeftBar.Size = new System.Drawing.Size(216, 582);
            this.panelLeftBar.TabIndex = 2;
            this.panelLeftBar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeftBar_Paint);
            // 
            // panelAyuda
            // 
            this.panelAyuda.Controls.Add(this.pictureBox6);
            this.panelAyuda.Controls.Add(this.label5);
            this.panelAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAyuda.Location = new System.Drawing.Point(1, 348);
            this.panelAyuda.Name = "panelAyuda";
            this.panelAyuda.Size = new System.Drawing.Size(216, 73);
            this.panelAyuda.TabIndex = 9;
            this.panelAyuda.Click += new System.EventHandler(this.panelAyuda_Click);
            this.panelAyuda.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAyuda_Paint);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(11, 26);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(23, 23);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(59, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ayuda";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panelAjustes
            // 
            this.panelAjustes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelAjustes.Controls.Add(this.pictureBox5);
            this.panelAjustes.Controls.Add(this.label4);
            this.panelAjustes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelAjustes.Location = new System.Drawing.Point(0, 271);
            this.panelAjustes.Name = "panelAjustes";
            this.panelAjustes.Size = new System.Drawing.Size(216, 73);
            this.panelAjustes.TabIndex = 8;
            this.panelAjustes.Click += new System.EventHandler(this.panelAjustes_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ajustes";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panelConstructor
            // 
            this.panelConstructor.Controls.Add(this.pictureBox4);
            this.panelConstructor.Controls.Add(this.label3);
            this.panelConstructor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelConstructor.Location = new System.Drawing.Point(0, 195);
            this.panelConstructor.Name = "panelConstructor";
            this.panelConstructor.Size = new System.Drawing.Size(216, 73);
            this.panelConstructor.TabIndex = 7;
            this.panelConstructor.Click += new System.EventHandler(this.panelConstructor_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(11, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(59, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Constructor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelDisenyo
            // 
            this.panelDisenyo.Controls.Add(this.pictureBox3);
            this.panelDisenyo.Controls.Add(this.label2);
            this.panelDisenyo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDisenyo.Location = new System.Drawing.Point(1, 120);
            this.panelDisenyo.Name = "panelDisenyo";
            this.panelDisenyo.Size = new System.Drawing.Size(216, 73);
            this.panelDisenyo.TabIndex = 6;
            this.panelDisenyo.Click += new System.EventHandler(this.panelDisenyo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(59, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Diseño";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelTopSideBar
            // 
            this.panelTopSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelTopSideBar.Controls.Add(this.hideShowBar);
            this.panelTopSideBar.Location = new System.Drawing.Point(0, 5);
            this.panelTopSideBar.Name = "panelTopSideBar";
            this.panelTopSideBar.Size = new System.Drawing.Size(216, 45);
            this.panelTopSideBar.TabIndex = 5;
            // 
            // hideShowBar
            // 
            this.hideShowBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideShowBar.Image = global::Desktop_App.Properties.Resources.left_arrow;
            this.hideShowBar.Location = new System.Drawing.Point(182, 14);
            this.hideShowBar.Name = "hideShowBar";
            this.hideShowBar.Size = new System.Drawing.Size(18, 18);
            this.hideShowBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hideShowBar.TabIndex = 4;
            this.hideShowBar.TabStop = false;
            this.hideShowBar.Click += new System.EventHandler(this.hideShowBar_Click);
            // 
            // panelDashboard
            // 
            this.panelDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.panelDashboard.Controls.Add(this.pictureBox2);
            this.panelDashboard.Controls.Add(this.label1);
            this.panelDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDashboard.Location = new System.Drawing.Point(0, 46);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(216, 73);
            this.panelDashboard.TabIndex = 0;
            this.panelDashboard.Click += new System.EventHandler(this.panelDashboard_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 706);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelLeftBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.windowControlButtons.ResumeLayout(false);
            this.windowControlButtons.PerformLayout();
            this.panelLeftBar.ResumeLayout(false);
            this.panelAyuda.ResumeLayout(false);
            this.panelAyuda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panelAjustes.ResumeLayout(false);
            this.panelAjustes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelConstructor.ResumeLayout(false);
            this.panelConstructor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelDisenyo.ResumeLayout(false);
            this.panelDisenyo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelTopSideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hideShowBar)).EndInit();
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Panel windowControlButtons;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLeftBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDashboard;
        private System.Windows.Forms.PictureBox hideShowBar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTopSideBar;
        private System.Windows.Forms.Panel panelConstructor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelDisenyo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelAjustes;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelAyuda;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label5;
    }
}