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

namespace MF
{
    public partial class Results : Form
    {
        public Results()
        {
            InitializeComponent();
        }

        public void ReadFile()
        {
            StreamReader sr = new StreamReader("results.txt", System.Text.Encoding.Default);

            string line;
            while ((line = sr.ReadLine()) != null)
            {
                
                string[] linem = line.Split(';');
             
                switch (line[0]) {
                    case '1':  _easy.Rows.Add(linem[1]);  break;
                    case '2': _medium.Rows.Add(linem[1]);  break;
                    case '3': _hard.Rows.Add(linem[1]);  break;
                }
            }
        }
        private void Results_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            ReadFile();
        }
    }
}
