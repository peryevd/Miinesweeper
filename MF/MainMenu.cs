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
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
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
    }
}
