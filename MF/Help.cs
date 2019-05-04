using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace MF
{
    public partial class Help : MetroForm
    {
        public Help()
        {
            InitializeComponent();
            pictureBox3.Controls.Add(pictureBox1);
            pictureBox3.Controls.Add(pictureBox2);
            pictureBox3.Controls.Add(exit);
            pictureBox3.Controls.Add(label1);
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Silver;
            this.Resizable = false;
            this.ControlBox = false;
            this.DisplayHeader = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
