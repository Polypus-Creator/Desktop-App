
namespace Desktop_App
{
    partial class FInfo
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FInfo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panelMin = new System.Windows.Forms.Panel();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.windowControlButtons = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            this.panelMin.SuspendLayout();
            this.windowControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            label1.Location = new System.Drawing.Point(3, 61);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(220, 37);
            label1.TabIndex = 8;
            label1.Text = "Polypus Creator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlText;
            label2.Location = new System.Drawing.Point(13, 10);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(145, 25);
            label2.TabIndex = 5;
            label2.Text = "Polypus Creator";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.ForeColor = System.Drawing.SystemColors.ControlText;
            label5.Location = new System.Drawing.Point(15, 60);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(167, 25);
            label5.TabIndex = 7;
            label5.Text = "© Polypus Creator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.SystemColors.ControlText;
            label4.Location = new System.Drawing.Point(13, 35);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(118, 25);
            label4.TabIndex = 6;
            label4.Text = "Versión 0.0.0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(label4);
            this.panel1.Controls.Add(label2);
            this.panel1.Location = new System.Drawing.Point(10, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 97);
            this.panel1.TabIndex = 7;
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelSuperior.Controls.Add(this.panelMin);
            this.panelSuperior.Controls.Add(this.pictureBox1);
            this.panelSuperior.Controls.Add(this.labelIniciarSesion);
            this.panelSuperior.Controls.Add(this.windowControlButtons);
            this.panelSuperior.Location = new System.Drawing.Point(-1, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(357, 54);
            this.panelSuperior.TabIndex = 10;
            // 
            // panelMin
            // 
            this.panelMin.Controls.Add(this.labelMin);
            this.panelMin.Location = new System.Drawing.Point(263, 1);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(41, 51);
            this.panelMin.TabIndex = 4;
            this.panelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.White;
            this.labelMin.Location = new System.Drawing.Point(6, 5);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(29, 40);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "-";
            this.labelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
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
            // 
            // windowControlButtons
            // 
            this.windowControlButtons.Controls.Add(this.labelClose);
            this.windowControlButtons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowControlButtons.Location = new System.Drawing.Point(307, 0);
            this.windowControlButtons.Name = "windowControlButtons";
            this.windowControlButtons.Size = new System.Drawing.Size(38, 51);
            this.windowControlButtons.TabIndex = 1;
            this.windowControlButtons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(3, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(31, 32);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
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
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Desktop_App.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(229, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(115, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // FInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 233);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FInfo";
            this.Text = "FInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelMin.ResumeLayout(false);
            this.panelMin.PerformLayout();
            this.windowControlButtons.ResumeLayout(false);
            this.windowControlButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Panel windowControlButtons;
        private System.Windows.Forms.Label labelClose;
    }
}