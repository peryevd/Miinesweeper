using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
using MetroFramework.Components;
using System;
using System.Collections;


namespace MF
{

    public partial class Results : MetroForm
    {
        List<string> es = new List<string>();
        List<string> md = new List<string>();
        List<string> hd = new List<string>();
        public Results()
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Black;
            this.Resizable = false;
            this.ControlBox = false;
        }

        public void ReadFile()
        {
            StreamReader sr = new StreamReader("results.txt", System.Text.Encoding.Default);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                
                string[] linem = line.Split(';');
             
                switch (line[0]) {
                    case '1':  es.Add(linem[1]);  break;
                    case '2': md.Add(linem[1]);  break;
                    case '3': hd.Add(linem[1]);  break;
                }
                
            }

            YearComparer yc = new YearComparer();
            es.Sort(yc);
            md.Sort(yc);
            hd.Sort(yc);

            es.ForEach(delegate (String name)
            {
                _easy.Rows.Add(name);
            });
            md.ForEach(delegate (String name)
            {
                _medium.Rows.Add(name);
            });
            hd.ForEach(delegate (String name)
            {
                _hard.Rows.Add(name);
            });


        }
        private void Results_Load(object sender, EventArgs e)
        {
            pictureBox3.Controls.Add(pictureBox2);    
            pictureBox3.Controls.Add(pictureBox1);
            pictureBox3.Controls.Add(label1);
            this.CenterToScreen();
            ReadFile();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu newForm = new MainMenu();
            newForm.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void _hard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void _medium_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

class YearComparer : IComparer<string>
{
    public int Compare(string o1, string o2)
    {
        int a = Convert.ToInt32(o1);
        int b = Convert.ToInt32(o2);

        if (a > b)
        {
            return 1;
        }
        else if (a < b)
        {
            return -1;
        }

        return 0;
    }
}