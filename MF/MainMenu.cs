using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MF
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            p_easy.Visible = false;
            p_medium.Visible = false;
            p_hard.Visible = false;
            this.CenterToScreen();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1(1);
            newForm.Show();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            p_easy.Visible = true;
            p_medium.Visible = true;
            p_hard.Visible = true;

            pictureBox1.Image = Properties.Resources.NewGame1P;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.NewGame1;
            //p_easy.Visible = false;
            //p_medium.Visible = false;
            //p_hard.Visible = false;
        }

        private void P_medium_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1(2);
            newForm.Show();
        }

        private void P_hard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm = new Form1(3);
            newForm.Show();
        }

        private void PictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.ResultsP;
        }

        private void PictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.Results;
        }

        private void PictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.ExitP;
        }

        private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Exit;
        }

        private void P_medium_MouseEnter(object sender, EventArgs e)
        {
            p_medium.Image = Properties.Resources.mediumP;
        }

        private void P_medium_MouseLeave(object sender, EventArgs e)
        {
            p_medium.Image = Properties.Resources.medium;
        }

        private void P_easy_MouseEnter(object sender, EventArgs e)
        {
            p_easy.Image = Properties.Resources.EasyP;
        }

        private void P_easy_MouseLeave(object sender, EventArgs e)
        {
            p_easy.Image = Properties.Resources.Easy;
        }

        private void P_hard_MouseEnter(object sender, EventArgs e)
        {
            p_hard.Image = Properties.Resources.hardP;
        }

        private void P_hard_MouseLeave(object sender, EventArgs e)
        {
            p_hard.Image = Properties.Resources.hard;
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Results newForm = new Results();
            newForm.Show();
        }
    }
}
