namespace Supermarket
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.splash_progressBar1 = new System.Windows.Forms.ProgressBar();
            this.splash_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splash_timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splash_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splash_progressBar1
            // 
            this.splash_progressBar1.BackColor = System.Drawing.Color.ForestGreen;
            this.splash_progressBar1.Location = new System.Drawing.Point(0, 430);
            this.splash_progressBar1.Name = "splash_progressBar1";
            this.splash_progressBar1.Size = new System.Drawing.Size(802, 23);
            this.splash_progressBar1.TabIndex = 26;
            this.splash_progressBar1.Click += new System.EventHandler(this.splash_progressBar1_Click);
            // 
            // splash_pictureBox1
            // 
            this.splash_pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("splash_pictureBox1.Image")));
            this.splash_pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.splash_pictureBox1.Name = "splash_pictureBox1";
            this.splash_pictureBox1.Size = new System.Drawing.Size(802, 424);
            this.splash_pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.splash_pictureBox1.TabIndex = 27;
            this.splash_pictureBox1.TabStop = false;
            this.splash_pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // splash_timer1
            // 
            this.splash_timer1.Tick += new System.EventHandler(this.splash_timer1_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splash_pictureBox1);
            this.Controls.Add(this.splash_progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splash_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ProgressBar splash_progressBar1;
        private System.Windows.Forms.PictureBox splash_pictureBox1;
        private System.Windows.Forms.Timer splash_timer1;
    }
}