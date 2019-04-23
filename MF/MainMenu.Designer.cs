namespace MF
{
    partial class MainMenu
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
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.p_hard = new System.Windows.Forms.PictureBox();
            this.p_medium = new System.Windows.Forms.PictureBox();
            this.p_easy = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MF.Properties.Resources.button_rekordy__1_;
            this.pictureBox6.Location = new System.Drawing.Point(412, 70);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(205, 52);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MF.Properties.Resources.button_vyxod;
            this.pictureBox5.Location = new System.Drawing.Point(412, 128);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(205, 52);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PictureBox5_Click);
            // 
            // p_hard
            // 
            this.p_hard.Image = global::MF.Properties.Resources.button_slozhnyj__1_;
            this.p_hard.Location = new System.Drawing.Point(278, 128);
            this.p_hard.Name = "p_hard";
            this.p_hard.Size = new System.Drawing.Size(112, 47);
            this.p_hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p_hard.TabIndex = 4;
            this.p_hard.TabStop = false;
            this.p_hard.Click += new System.EventHandler(this.P_hard_Click);
            // 
            // p_medium
            // 
            this.p_medium.Image = global::MF.Properties.Resources.button_slozhnyj;
            this.p_medium.Location = new System.Drawing.Point(278, 70);
            this.p_medium.Name = "p_medium";
            this.p_medium.Size = new System.Drawing.Size(112, 47);
            this.p_medium.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p_medium.TabIndex = 3;
            this.p_medium.TabStop = false;
            this.p_medium.Click += new System.EventHandler(this.P_medium_Click);
            // 
            // p_easy
            // 
            this.p_easy.Image = global::MF.Properties.Resources.button_legkij;
            this.p_easy.Location = new System.Drawing.Point(278, 12);
            this.p_easy.Name = "p_easy";
            this.p_easy.Size = new System.Drawing.Size(112, 47);
            this.p_easy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.p_easy.TabIndex = 2;
            this.p_easy.TabStop = false;
            this.p_easy.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MF.Properties.Resources.button_novaya_igra;
            this.pictureBox1.Location = new System.Drawing.Point(412, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(205, 52);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.PictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.PictureBox1_MouseLeave);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MF.Properties.Resources._583ac15f0f27d158a5835b56;
            this.ClientSize = new System.Drawing.Size(629, 776);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.p_hard);
            this.Controls.Add(this.p_medium);
            this.Controls.Add(this.p_easy);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox p_easy;
        private System.Windows.Forms.PictureBox p_medium;
        private System.Windows.Forms.PictureBox p_hard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}