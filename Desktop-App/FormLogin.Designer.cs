
namespace Desktop_App
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.pictureBoxIconoIniciarSesion = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMinimize = new System.Windows.Forms.Label();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelContrasena = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.linkLabelContasenaOlvidada = new System.Windows.Forms.LinkLabel();
            this.linkLabelRegistrarte = new System.Windows.Forms.LinkLabel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoIniciarSesion)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelSuperior.Controls.Add(this.labelIniciarSesion);
            this.panelSuperior.Controls.Add(this.pictureBoxIconoIniciarSesion);
            this.panelSuperior.Controls.Add(this.panel2);
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(533, 54);
            this.panelSuperior.TabIndex = 0;
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.labelIniciarSesion.Location = new System.Drawing.Point(44, 13);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(166, 32);
            this.labelIniciarSesion.TabIndex = 3;
            this.labelIniciarSesion.Text = "Iniciar sesión";
            // 
            // pictureBoxIconoIniciarSesion
            // 
            this.pictureBoxIconoIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.pictureBoxIconoIniciarSesion.Image = global::Desktop_App.Properties.Resources.padlockIcon;
            this.pictureBoxIconoIniciarSesion.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxIconoIniciarSesion.Name = "pictureBoxIconoIniciarSesion";
            this.pictureBoxIconoIniciarSesion.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxIconoIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconoIniciarSesion.TabIndex = 2;
            this.pictureBoxIconoIniciarSesion.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelMinimize);
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(425, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(105, 51);
            this.panel2.TabIndex = 1;
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
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(52, 159);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(88, 30);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelContrasena
            // 
            this.labelContrasena.AutoSize = true;
            this.labelContrasena.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasena.Location = new System.Drawing.Point(52, 261);
            this.labelContrasena.Name = "labelContrasena";
            this.labelContrasena.Size = new System.Drawing.Size(123, 30);
            this.labelContrasena.TabIndex = 3;
            this.labelContrasena.Text = "Contraseña";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsuario.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxUsuario.Location = new System.Drawing.Point(57, 198);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(384, 35);
            this.textBoxUsuario.TabIndex = 4;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContrasena.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxContrasena.Location = new System.Drawing.Point(57, 305);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(384, 35);
            this.textBoxContrasena.TabIndex = 5;
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonIniciarSesion.FlatAppearance.BorderSize = 0;
            this.buttonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonIniciarSesion.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.buttonIniciarSesion.Location = new System.Drawing.Point(57, 380);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(384, 77);
            this.buttonIniciarSesion.TabIndex = 6;
            this.buttonIniciarSesion.Text = "INICIAR SESIÓN";
            this.buttonIniciarSesion.UseVisualStyleBackColor = false;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // linkLabelContasenaOlvidada
            // 
            this.linkLabelContasenaOlvidada.AutoSize = true;
            this.linkLabelContasenaOlvidada.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelContasenaOlvidada.LinkColor = System.Drawing.Color.Red;
            this.linkLabelContasenaOlvidada.Location = new System.Drawing.Point(160, 477);
            this.linkLabelContasenaOlvidada.Name = "linkLabelContasenaOlvidada";
            this.linkLabelContasenaOlvidada.Size = new System.Drawing.Size(167, 17);
            this.linkLabelContasenaOlvidada.TabIndex = 7;
            this.linkLabelContasenaOlvidada.TabStop = true;
            this.linkLabelContasenaOlvidada.Text = "He olvidado mi contraseña";
            this.linkLabelContasenaOlvidada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContasenaOlvidada_LinkClicked);
            // 
            // linkLabelRegistrarte
            // 
            this.linkLabelRegistrarte.AutoSize = true;
            this.linkLabelRegistrarte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelRegistrarte.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.linkLabelRegistrarte.Location = new System.Drawing.Point(93, 510);
            this.linkLabelRegistrarte.Name = "linkLabelRegistrarte";
            this.linkLabelRegistrarte.Size = new System.Drawing.Size(307, 17);
            this.linkLabelRegistrarte.TabIndex = 8;
            this.linkLabelRegistrarte.TabStop = true;
            this.linkLabelRegistrarte.Text = "Si no tienes un usuario pulsa aquí para registrarte";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pictureBoxLogo);
            this.panelPrincipal.Controls.Add(this.linkLabelRegistrarte);
            this.panelPrincipal.Controls.Add(this.buttonIniciarSesion);
            this.panelPrincipal.Controls.Add(this.linkLabelContasenaOlvidada);
            this.panelPrincipal.Controls.Add(this.labelUsuario);
            this.panelPrincipal.Controls.Add(this.labelContrasena);
            this.panelPrincipal.Controls.Add(this.textBoxContrasena);
            this.panelPrincipal.Controls.Add(this.textBoxUsuario);
            this.panelPrincipal.Location = new System.Drawing.Point(12, 71);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(502, 551);
            this.panelPrincipal.TabIndex = 9;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(83, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(327, 144);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 9;
            this.pictureBoxLogo.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 639);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "Form";
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoIniciarSesion)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.PictureBox pictureBoxIconoIniciarSesion;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelContrasena;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.LinkLabel linkLabelContasenaOlvidada;
        private System.Windows.Forms.LinkLabel linkLabelRegistrarte;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Label labelMinimize;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

