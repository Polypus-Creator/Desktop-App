
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
            this.webBrowserWeb = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserWeb
            // 
            this.webBrowserWeb.Location = new System.Drawing.Point(7, 40);
            this.webBrowserWeb.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserWeb.Name = "webBrowserWeb";
            this.webBrowserWeb.Size = new System.Drawing.Size(787, 370);
            this.webBrowserWeb.TabIndex = 3;
            // 
            // FAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowserWeb);
            this.Name = "FAboutUs";
            this.Text = "FAboutUs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserWeb;
    }
}