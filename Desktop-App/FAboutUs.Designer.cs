
namespace Desktop_App
{
    partial class FAboutUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAboutUs));
            this.webBrowserWeb = new System.Windows.Forms.WebBrowser();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMin = new System.Windows.Forms.Panel();
            this.labelMin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelIniciarSesion = new System.Windows.Forms.Label();
            this.panelClose = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelMin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelClose.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowserWeb
            // 
            this.webBrowserWeb.Location = new System.Drawing.Point(7, 63);
            this.webBrowserWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWeb.Name = "webBrowserWeb";
            this.webBrowserWeb.Size = new System.Drawing.Size(787, 370);
            this.webBrowserWeb.TabIndex = 3;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(48)))), ((int)(((byte)(45)))));
            this.panelHeader.Controls.Add(this.panelMin);
            this.panelHeader.Controls.Add(this.pictureBox1);
            this.panelHeader.Controls.Add(this.labelIniciarSesion);
            this.panelHeader.Controls.Add(this.panelClose);
            this.panelHeader.Location = new System.Drawing.Point(7, 3);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(795, 54);
            this.panelHeader.TabIndex = 11;
            // 
            // panelMin
            // 
            this.panelMin.Controls.Add(this.labelMin);
            this.panelMin.Location = new System.Drawing.Point(703, 0);
            this.panelMin.Name = "panelMin";
            this.panelMin.Size = new System.Drawing.Size(38, 51);
            this.panelMin.TabIndex = 4;
            this.panelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.Color.White;
            this.labelMin.Location = new System.Drawing.Point(3, 3);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(29, 40);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "-";
            this.labelMin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMin_MouseClick);
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
            // panelClose
            // 
            this.panelClose.Controls.Add(this.labelClose);
            this.panelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelClose.Location = new System.Drawing.Point(741, -1);
            this.panelClose.Name = "panelClose";
            this.panelClose.Size = new System.Drawing.Size(44, 51);
            this.panelClose.TabIndex = 1;
            this.panelClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(6, 9);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(31, 32);
            this.labelClose.TabIndex = 0;
            this.labelClose.Text = "X";
            this.labelClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelClose_MouseClick);
            // 
            // FAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.webBrowserWeb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAboutUs";
            this.Text = "FAboutUs";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMin.ResumeLayout(false);
            this.panelMin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelClose.ResumeLayout(false);
            this.panelClose.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserWeb;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMin;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelIniciarSesion;
        private System.Windows.Forms.Panel panelClose;
        private System.Windows.Forms.Label labelClose;
    }
}