
namespace Desktop_App
{
    partial class FRegis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegis));
            this.buttonRegis = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAnsw = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxAsk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxConfPass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.timerOjo = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxOjo2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxOjo1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVolver = new System.Windows.Forms.PictureBox();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelMin = new System.Windows.Forms.Panel();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.pictureBoxIconoIniciarSesion = new System.Windows.Forms.PictureBox();
            this.panelClose = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.comboBoxSesionIniciada = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panelMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoIniciarSesion)).BeginInit();
            this.panelClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegis
            // 
            this.buttonRegis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonRegis.FlatAppearance.BorderSize = 0;
            this.buttonRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegis.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegis.ForeColor = System.Drawing.Color.White;
            this.buttonRegis.Location = new System.Drawing.Point(464, 405);
            this.buttonRegis.Name = "buttonRegis";
            this.buttonRegis.Size = new System.Drawing.Size(339, 71);
            this.buttonRegis.TabIndex = 31;
            this.buttonRegis.Text = "REGISTRARME";
            this.buttonRegis.UseVisualStyleBackColor = false;
            this.buttonRegis.Click += new System.EventHandler(this.buttonRegis_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.Location = new System.Drawing.Point(464, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 21);
            this.label9.TabIndex = 29;
            this.label9.Text = "Respuesta";
            // 
            // textBoxAnsw
            // 
            this.textBoxAnsw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnsw.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnsw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxAnsw.Location = new System.Drawing.Point(466, 242);
            this.textBoxAnsw.Name = "textBoxAnsw";
            this.textBoxAnsw.Size = new System.Drawing.Size(337, 35);
            this.textBoxAnsw.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.Location = new System.Drawing.Point(462, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Elige una pregunta de seguridad";
            // 
            // comboBoxAsk
            // 
            this.comboBoxAsk.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.comboBoxAsk.FormattingEnabled = true;
            this.comboBoxAsk.Items.AddRange(new object[] {
            "Animal Favorito?",
            "Donde hiciste primaria?"});
            this.comboBoxAsk.Location = new System.Drawing.Point(464, 143);
            this.comboBoxAsk.Name = "comboBoxAsk";
            this.comboBoxAsk.Size = new System.Drawing.Size(339, 38);
            this.comboBoxAsk.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(80, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 21);
            this.label7.TabIndex = 25;
            this.label7.Text = "Confirmar Contraseña";
            // 
            // textBoxConfPass
            // 
            this.textBoxConfPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfPass.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxConfPass.Location = new System.Drawing.Point(84, 327);
            this.textBoxConfPass.Name = "textBoxConfPass";
            this.textBoxConfPass.Size = new System.Drawing.Size(341, 35);
            this.textBoxConfPass.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(80, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Contraseña";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxPass.Location = new System.Drawing.Point(82, 242);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(341, 35);
            this.textBoxPass.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(63, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = "Volver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(80, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Usuario";
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxUser.Location = new System.Drawing.Point(84, 144);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(339, 35);
            this.textBoxUser.TabIndex = 21;
            // 
            // timerOjo
            // 
            this.timerOjo.Tick += new System.EventHandler(this.timerOjo_Tick);
            // 
            // pictureBoxOjo2
            // 
            this.pictureBoxOjo2.Image = global::Desktop_App.Properties.Resources.eyeCl;
            this.pictureBoxOjo2.Location = new System.Drawing.Point(392, 334);
            this.pictureBoxOjo2.Name = "pictureBoxOjo2";
            this.pictureBoxOjo2.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxOjo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOjo2.TabIndex = 33;
            this.pictureBoxOjo2.TabStop = false;
            this.pictureBoxOjo2.Click += new System.EventHandler(this.pictureBoxOjo2_Click);
            // 
            // pictureBoxOjo1
            // 
            this.pictureBoxOjo1.Image = global::Desktop_App.Properties.Resources.eyeCl;
            this.pictureBoxOjo1.Location = new System.Drawing.Point(391, 249);
            this.pictureBoxOjo1.Name = "pictureBoxOjo1";
            this.pictureBoxOjo1.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxOjo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOjo1.TabIndex = 32;
            this.pictureBoxOjo1.TabStop = false;
            this.pictureBoxOjo1.Click += new System.EventHandler(this.pictureBoxOjo1_Click);
            // 
            // pictureBoxVolver
            // 
            this.pictureBoxVolver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxVolver.Image")));
            this.pictureBoxVolver.Location = new System.Drawing.Point(26, 63);
            this.pictureBoxVolver.Name = "pictureBoxVolver";
            this.pictureBoxVolver.Size = new System.Drawing.Size(23, 21);
            this.pictureBoxVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVolver.TabIndex = 19;
            this.pictureBoxVolver.TabStop = false;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelSuperior.Controls.Add(this.panelMin);
            this.panelSuperior.Controls.Add(this.labelIniciarSesion);
            this.panelSuperior.Controls.Add(this.pictureBoxIconoIniciarSesion);
            this.panelSuperior.Controls.Add(this.panelClose);
            this.panelSuperior.Location = new System.Drawing.Point(-1, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(852, 54);
            this.panelSuperior.TabIndex = 34;
            // 
            // panelMin
            // 
            this.panelMin.Controls.Add(this.labelMin);
            this.panelMin.Location = new System.Drawing.Point(747, 0);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(47, 54);
            this.panelMin.TabIndex = 4;
            this.panelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.White;
            this.labelMin.Location = new System.Drawing.Point(12, 6);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(29, 40);
            this.labelMin.TabIndex = 1;
            this.labelMin.Text = "-";
            this.labelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
            // 
            // labelIniciarSesion
            // 
            this.labelIniciarSesion.AutoSize = true;
            this.labelIniciarSesion.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.labelIniciarSesion.Location = new System.Drawing.Point(63, 10);
            this.labelIniciarSesion.Name = "labelIniciarSesion";
            this.labelIniciarSesion.Size = new System.Drawing.Size(125, 32);
            this.labelIniciarSesion.TabIndex = 3;
            this.labelIniciarSesion.Text = "Registrar ";
            // 
            // pictureBoxIconoIniciarSesion
            // 
            this.pictureBoxIconoIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.pictureBoxIconoIniciarSesion.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxIconoIniciarSesion.Image")));
            this.pictureBoxIconoIniciarSesion.Location = new System.Drawing.Point(12, 5);
            this.pictureBoxIconoIniciarSesion.Name = "pictureBoxIconoIniciarSesion";
            this.pictureBoxIconoIniciarSesion.Size = new System.Drawing.Size(44, 44);
            this.pictureBoxIconoIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconoIniciarSesion.TabIndex = 2;
            this.pictureBoxIconoIniciarSesion.TabStop = false;
            // 
            // panelClose
            // 
            this.panelClose.Controls.Add(this.labelClose);
            this.panelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelClose.Location = new System.Drawing.Point(800, 3);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(49, 51);
            this.panelClose.TabIndex = 1;
            this.panelClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(11, 10);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(31, 32);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelEmail.Location = new System.Drawing.Point(80, 412);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 21);
            this.labelEmail.TabIndex = 35;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(115)))));
            this.textBoxEmail.Location = new System.Drawing.Point(82, 441);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(341, 35);
            this.textBoxEmail.TabIndex = 36;
            // 
            // comboBoxSesionIniciada
            // 
            this.comboBoxSesionIniciada.Font = new System.Drawing.Font("Segoe UI Light", 15.75F);
            this.comboBoxSesionIniciada.FormattingEnabled = true;
            this.comboBoxSesionIniciada.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.comboBoxSesionIniciada.Location = new System.Drawing.Point(466, 327);
            this.comboBoxSesionIniciada.Name = "comboBoxSesionIniciada";
            this.comboBoxSesionIniciada.Size = new System.Drawing.Size(337, 38);
            this.comboBoxSesionIniciada.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(464, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "¿Mantener la sesión iniciada?";
            // 
            // FRegis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSesionIniciada);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.pictureBoxOjo2);
            this.Controls.Add(this.pictureBoxOjo1);
            this.Controls.Add(this.buttonRegis);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAnsw);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxAsk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxConfPass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.pictureBoxVolver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRegis";
            this.Text = "FRegis";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOjo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVolver)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelMin.ResumeLayout(false);
            this.panelMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconoIniciarSesion)).EndInit();
            this.panelClose.ResumeLayout(false);
            this.panelClose.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOjo2;
        private System.Windows.Forms.PictureBox pictureBoxOjo1;
        private System.Windows.Forms.Button buttonRegis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAnsw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxAsk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxConfPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.PictureBox pictureBoxVolver;
        private System.Windows.Forms.Timer timerOjo;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBoxIconoIniciarSesion;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.ComboBox comboBoxSesionIniciada;
        private System.Windows.Forms.Label label1;
    }
}