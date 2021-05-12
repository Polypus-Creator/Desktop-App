
namespace Desktop_App
{
    partial class FormSoporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSoporte));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelContrasenaOlvidada = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.webBrowserMapaContacto = new System.Windows.Forms.WebBrowser();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelTitulo2 = new System.Windows.Forms.Label();
            this.labelNuestrasOficinas = new System.Windows.Forms.Label();
            this.buttonEnviar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.labelHorarioSD = new System.Windows.Forms.Label();
            this.buttonVerMapaEnNavegador = new System.Windows.Forms.Button();
            this.buttonAbrirWeb = new System.Windows.Forms.Button();
            this.labelCaptcha = new System.Windows.Forms.Label();
            this.labelTituloCaptcha = new System.Windows.Forms.Label();
            this.textBoxCaptcha = new System.Windows.Forms.TextBox();
            this.labelWeb = new System.Windows.Forms.Label();
            this.labelHorarioLV = new System.Windows.Forms.Label();
            this.labelTelefonoContacto = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelSuperior.Controls.Add(this.pictureBox6);
            this.panelSuperior.Controls.Add(this.labelContrasenaOlvidada);
            this.panelSuperior.Controls.Add(this.panel2);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1384, 54);
            this.panelSuperior.TabIndex = 2;
            // 
            // labelContrasenaOlvidada
            // 
            this.labelContrasenaOlvidada.AutoSize = true;
            this.labelContrasenaOlvidada.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenaOlvidada.ForeColor = System.Drawing.Color.White;
            this.labelContrasenaOlvidada.Location = new System.Drawing.Point(45, 9);
            this.labelContrasenaOlvidada.Name = "labelContrasenaOlvidada";
            this.labelContrasenaOlvidada.Size = new System.Drawing.Size(118, 32);
            this.labelContrasenaOlvidada.TabIndex = 3;
            this.labelContrasenaOlvidada.Text = "Contacto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMinimize);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(1279, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 51);
            this.panel2.TabIndex = 1;
            // 
            // labelMinimize
            // 
            this.labelMinimize.AutoSize = true;
            this.labelMinimize.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimize.ForeColor = System.Drawing.Color.White;
            this.labelMinimize.Location = new System.Drawing.Point(21, 1);
            this.labelMinimize.Name = "labelMinimize";
            this.labelMinimize.Size = new System.Drawing.Size(35, 32);
            this.labelMinimize.TabIndex = 1;
            this.labelMinimize.Text = "__";
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
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelNombre.Location = new System.Drawing.Point(39, 182);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(100, 30);
            this.labelNombre.TabIndex = 9;
            this.labelNombre.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxNombre.Location = new System.Drawing.Point(44, 221);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(461, 35);
            this.textBoxNombre.TabIndex = 10;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelEmail.Location = new System.Drawing.Point(39, 277);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 30);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxEmail.Location = new System.Drawing.Point(44, 316);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(461, 35);
            this.textBoxEmail.TabIndex = 12;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelMensaje.Location = new System.Drawing.Point(39, 381);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(100, 30);
            this.labelMensaje.TabIndex = 13;
            this.labelMensaje.Text = "Mensaje:";
            this.labelMensaje.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMensaje.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxMensaje.Location = new System.Drawing.Point(44, 420);
            this.textBoxMensaje.Multiline = true;
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(461, 133);
            this.textBoxMensaje.TabIndex = 14;
            this.textBoxMensaje.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // webBrowserMapaContacto
            // 
            this.webBrowserMapaContacto.Location = new System.Drawing.Point(607, 277);
            this.webBrowserMapaContacto.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserMapaContacto.Name = "webBrowserMapaContacto";
            this.webBrowserMapaContacto.Size = new System.Drawing.Size(728, 310);
            this.webBrowserMapaContacto.TabIndex = 15;
            this.webBrowserMapaContacto.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelTitulo.Location = new System.Drawing.Point(35, 80);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(494, 40);
            this.labelTitulo.TabIndex = 16;
            this.labelTitulo.Text = "¿Tienes alguna duda o sugerencia?";
            // 
            // labelTitulo2
            // 
            this.labelTitulo2.AutoSize = true;
            this.labelTitulo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelTitulo2.Location = new System.Drawing.Point(40, 124);
            this.labelTitulo2.Name = "labelTitulo2";
            this.labelTitulo2.Size = new System.Drawing.Size(831, 21);
            this.labelTitulo2.TabIndex = 17;
            this.labelTitulo2.Text = "Contáctenos para cualquier cosa relacionada con la aplicación Polypus Creator, se" +
    "rvicios o nuestra empresa.";
            // 
            // labelNuestrasOficinas
            // 
            this.labelNuestrasOficinas.AutoSize = true;
            this.labelNuestrasOficinas.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNuestrasOficinas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.labelNuestrasOficinas.Location = new System.Drawing.Point(599, 223);
            this.labelNuestrasOficinas.Name = "labelNuestrasOficinas";
            this.labelNuestrasOficinas.Size = new System.Drawing.Size(257, 40);
            this.labelNuestrasOficinas.TabIndex = 18;
            this.labelNuestrasOficinas.Text = "Nuestras Oficinas";
            // 
            // buttonEnviar
            // 
            this.buttonEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonEnviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEnviar.FlatAppearance.BorderSize = 0;
            this.buttonEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnviar.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEnviar.ForeColor = System.Drawing.Color.White;
            this.buttonEnviar.Location = new System.Drawing.Point(44, 658);
            this.buttonEnviar.Name = "buttonEnviar";
            this.buttonEnviar.Size = new System.Drawing.Size(461, 59);
            this.buttonEnviar.TabIndex = 19;
            this.buttonEnviar.Text = "ENVIAR";
            this.buttonEnviar.UseVisualStyleBackColor = false;
            this.buttonEnviar.Click += new System.EventHandler(this.buttonEnviar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(72)))));
            this.buttonVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVolver.FlatAppearance.BorderSize = 0;
            this.buttonVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVolver.Font = new System.Drawing.Font("Segoe UI Black", 10.15F, System.Drawing.FontStyle.Bold);
            this.buttonVolver.ForeColor = System.Drawing.Color.White;
            this.buttonVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVolver.Location = new System.Drawing.Point(1097, 699);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(238, 32);
            this.buttonVolver.TabIndex = 24;
            this.buttonVolver.Text = "VOLVER";
            this.buttonVolver.UseVisualStyleBackColor = false;
            // 
            // labelHorarioSD
            // 
            this.labelHorarioSD.AutoSize = true;
            this.labelHorarioSD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioSD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHorarioSD.Location = new System.Drawing.Point(844, 674);
            this.labelHorarioSD.Name = "labelHorarioSD";
            this.labelHorarioSD.Size = new System.Drawing.Size(218, 21);
            this.labelHorarioSD.TabIndex = 25;
            this.labelHorarioSD.Text = "Sábado y Domingo cerrado";
            // 
            // buttonVerMapaEnNavegador
            // 
            this.buttonVerMapaEnNavegador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(72)))));
            this.buttonVerMapaEnNavegador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerMapaEnNavegador.FlatAppearance.BorderSize = 0;
            this.buttonVerMapaEnNavegador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerMapaEnNavegador.Font = new System.Drawing.Font("Segoe UI Black", 10.15F, System.Drawing.FontStyle.Bold);
            this.buttonVerMapaEnNavegador.ForeColor = System.Drawing.Color.White;
            this.buttonVerMapaEnNavegador.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVerMapaEnNavegador.Location = new System.Drawing.Point(1097, 658);
            this.buttonVerMapaEnNavegador.Name = "buttonVerMapaEnNavegador";
            this.buttonVerMapaEnNavegador.Size = new System.Drawing.Size(238, 32);
            this.buttonVerMapaEnNavegador.TabIndex = 27;
            this.buttonVerMapaEnNavegador.Text = "VER MAPA EN NAVEGADOR";
            this.buttonVerMapaEnNavegador.UseVisualStyleBackColor = false;
            // 
            // buttonAbrirWeb
            // 
            this.buttonAbrirWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(72)))));
            this.buttonAbrirWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAbrirWeb.FlatAppearance.BorderSize = 0;
            this.buttonAbrirWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbrirWeb.Font = new System.Drawing.Font("Segoe UI Black", 10.15F, System.Drawing.FontStyle.Bold);
            this.buttonAbrirWeb.ForeColor = System.Drawing.Color.White;
            this.buttonAbrirWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbrirWeb.Location = new System.Drawing.Point(1097, 620);
            this.buttonAbrirWeb.Name = "buttonAbrirWeb";
            this.buttonAbrirWeb.Size = new System.Drawing.Size(238, 32);
            this.buttonAbrirWeb.TabIndex = 28;
            this.buttonAbrirWeb.Text = "ABRIR WEB EN NAVEGADOR";
            this.buttonAbrirWeb.UseVisualStyleBackColor = false;
            // 
            // labelCaptcha
            // 
            this.labelCaptcha.AutoSize = true;
            this.labelCaptcha.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaptcha.Location = new System.Drawing.Point(38, 588);
            this.labelCaptcha.Name = "labelCaptcha";
            this.labelCaptcha.Size = new System.Drawing.Size(143, 36);
            this.labelCaptcha.TabIndex = 29;
            this.labelCaptcha.Text = "captcha";
            // 
            // labelTituloCaptcha
            // 
            this.labelTituloCaptcha.AutoSize = true;
            this.labelTituloCaptcha.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelTituloCaptcha.Location = new System.Drawing.Point(220, 564);
            this.labelTituloCaptcha.Name = "labelTituloCaptcha";
            this.labelTituloCaptcha.Size = new System.Drawing.Size(98, 30);
            this.labelTituloCaptcha.TabIndex = 30;
            this.labelTituloCaptcha.Text = "Captcha:";
            // 
            // textBoxCaptcha
            // 
            this.textBoxCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCaptcha.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxCaptcha.Location = new System.Drawing.Point(225, 597);
            this.textBoxCaptcha.Name = "textBoxCaptcha";
            this.textBoxCaptcha.Size = new System.Drawing.Size(280, 35);
            this.textBoxCaptcha.TabIndex = 31;
            // 
            // labelWeb
            // 
            this.labelWeb.AutoSize = true;
            this.labelWeb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelWeb.Image = ((System.Drawing.Image)(resources.GetObject("labelWeb.Image")));
            this.labelWeb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelWeb.Location = new System.Drawing.Point(603, 710);
            this.labelWeb.Name = "labelWeb";
            this.labelWeb.Size = new System.Drawing.Size(175, 21);
            this.labelWeb.TabIndex = 26;
            this.labelWeb.Text = "     www.example.com";
            // 
            // labelHorarioLV
            // 
            this.labelHorarioLV.AutoSize = true;
            this.labelHorarioLV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorarioLV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelHorarioLV.Image = ((System.Drawing.Image)(resources.GetObject("labelHorarioLV.Image")));
            this.labelHorarioLV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelHorarioLV.Location = new System.Drawing.Point(603, 674);
            this.labelHorarioLV.Name = "labelHorarioLV";
            this.labelHorarioLV.Size = new System.Drawing.Size(235, 21);
            this.labelHorarioLV.TabIndex = 23;
            this.labelHorarioLV.Text = "     Horarios: L-V / 8:00 a 17:00 ";
            // 
            // labelTelefonoContacto
            // 
            this.labelTelefonoContacto.AutoSize = true;
            this.labelTelefonoContacto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefonoContacto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelTelefonoContacto.Image = ((System.Drawing.Image)(resources.GetObject("labelTelefonoContacto.Image")));
            this.labelTelefonoContacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTelefonoContacto.Location = new System.Drawing.Point(603, 638);
            this.labelTelefonoContacto.Name = "labelTelefonoContacto";
            this.labelTelefonoContacto.Size = new System.Drawing.Size(288, 21);
            this.labelTelefonoContacto.TabIndex = 22;
            this.labelTelefonoContacto.Text = "     Teléfono de contacto: 900 000 000";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.labelDireccion.Image = ((System.Drawing.Image)(resources.GetObject("labelDireccion.Image")));
            this.labelDireccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDireccion.Location = new System.Drawing.Point(603, 606);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(397, 21);
            this.labelDireccion.TabIndex = 21;
            this.labelDireccion.Text = "     Dirección : Carrer de Monlau, 6, 08027 Barcelona";
            this.labelDireccion.Click += new System.EventHandler(this.label6_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(1251, 74);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(97, 81);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 20;
            this.pictureBoxLogo.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = global::Desktop_App.Properties.Resources.information;
            this.pictureBox6.Location = new System.Drawing.Point(14, 13);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // FormSoporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 765);
            this.Controls.Add(this.textBoxCaptcha);
            this.Controls.Add(this.labelTituloCaptcha);
            this.Controls.Add(this.labelCaptcha);
            this.Controls.Add(this.buttonAbrirWeb);
            this.Controls.Add(this.buttonVerMapaEnNavegador);
            this.Controls.Add(this.labelWeb);
            this.Controls.Add(this.labelHorarioSD);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.labelHorarioLV);
            this.Controls.Add(this.labelTelefonoContacto);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.buttonEnviar);
            this.Controls.Add(this.labelNuestrasOficinas);
            this.Controls.Add(this.labelTitulo2);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.webBrowserMapaContacto);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSoporte";
            this.Text = "FormSoporte";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label labelContrasenaOlvidada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.TextBox textBoxMensaje;
        private System.Windows.Forms.WebBrowser webBrowserMapaContacto;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelTitulo2;
        private System.Windows.Forms.Label labelNuestrasOficinas;
        private System.Windows.Forms.Button buttonEnviar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefonoContacto;
        private System.Windows.Forms.Label labelHorarioLV;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Label labelHorarioSD;
        private System.Windows.Forms.Label labelWeb;
        private System.Windows.Forms.Button buttonVerMapaEnNavegador;
        private System.Windows.Forms.Button buttonAbrirWeb;
        private System.Windows.Forms.Label labelCaptcha;
        private System.Windows.Forms.Label labelTituloCaptcha;
        private System.Windows.Forms.TextBox textBoxCaptcha;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}