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
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Components;

namespace MF
{
    public partial class Form1 : MetroForm
    {
        int time = 0;
        int difficult = 0;
        int[,] masField;
        static int len = 10, heig = 10, bomb = 7;
        int k = 1;
        PictureBox[,] MasPicter;

        public Form1(int dif)
        {
            InitializeComponent();
            MetroStyleManager.Default.Style = MetroFramework.MetroColorStyle.Silver;
            this.Resizable = false;
            this.ControlBox = false;
            difficult = dif;
        }

        private void StartGame()
        {
            switch (difficult)
            {
                case 1:
                    len = 10;
                    heig = 10;
                    bomb = 10;
                    break;
                case 2:
                    len = 15;
                    heig = 15;
                    bomb = 15;
                    break;
                case 3:
                    len = 15;
                    heig = 15;
                    bomb = 30;
                    break;
            }          

            masField = new int[len, heig];
            MasPicter = new PictureBox[len, heig];
            Field mas = new Field(len, heig, bomb);
            masField = mas.get();

            CreateField();
            DrawField();
        }

        private void GameOver(string _status)
        {
            switch (_status)
            {
                case "lose":

                    for (int i = 0; i < len; i++)
                    {
                        for (int j = 0; j < heig; j++)
                        {
                            if (masField[Convert.ToInt32(MasPicter[i,j].Name), Convert.ToInt32(MasPicter[i, j].Tag)] == 10)
                            {
                                MasPicter[i, j].Image = Properties.Resources.bomb;
                                MasPicter[i, j].BackColor = Color.Red;
                            }
                        }
                    }

                    timer1.Stop();
                    DisableField(true);
                    //Application.Exit();
                    break;

                case "iswin":
                    bool flag = true;

                    for (int i = 0; i < len; i++)
                    {
                        for (int j = 0; j < heig; j++)
                        {
                            if (!(MasPicter[i, j].Text == "True")&&(masField[Convert.ToInt32(MasPicter[i, j].Name), Convert.ToInt32(MasPicter[i, j].Tag)] != 10)) { flag = false; }                          
                        }
                    }
                    if (flag == true)
                    {
                        DisableField(true);
                        timer1.Stop();
                        MessageBox.Show("Победа!");
                       

                        WriteToFile();

                        this.Close();
                        MainMenu newForm = new MainMenu();
                        newForm.Show();
                    }

                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.BackColor = Color.White;

            StartGame();

            bomb_count.Text = bomb.ToString();
                     
            timer1.Enabled = true;

            _time.Text = "0";
            _time.BackColor = Color.Transparent;

            //pictureBox10.Controls.Add(play);
            //pictureBox10.Controls.Add(settings);
            //pictureBox10.Controls.Add(exit);
            //pictureBox10.Controls.Add(pictureBox6);
            //pictureBox10.Controls.Add(pictureBox7);
            //pictureBox10.Controls.Add(bomb_count);
            //pictureBox10.Controls.Add(_time);
        }

        private void CreateField()
        {
            int k = 0;
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < heig; j++)
                {
                    PictureBox pct = new PictureBox();
                    switch (difficult)
                    {
                        case 1:
                            pct.Height = 50;
                            pct.Width = 50;
                            pct.Left = 20 + i * 60;
                            pct.Top = 20 + j * 60;
                            break;
                        case 2:
                            pct.Height = 33;
                            pct.Width = 33;
                            pct.Left = 15 + i * 40;
                            pct.Top = 15 + j * 40;
                            break;
                        case 3:
                            pct.Height = 33;
                            pct.Width = 33;
                            pct.Left = 15 + i * 40;
                            pct.Top = 15 + j * 40;
                            break;
                    }

                   
                    pct.Name = "" + i;
                    pct.Tag = j;
                    pct.Text = "false";
                    pct.MouseDown += new MouseEventHandler(Pct_MouseClick);                
                    k++;
                    pct.Image = Properties.Resources.kvd;
                    pct.SizeMode = PictureBoxSizeMode.StretchImage;
                    MasPicter[i, j] = pct;
                }
            }
        }

        //Отрисовка поля
        private void DrawField()
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < heig; j++)
                {
                    Controls.Add(MasPicter[i,j]);
                    MasPicter[i, j].BringToFront();
                    MasPicter[i, j].BackColor = Color.Transparent;
                    //pictureBox10.Controls.Add(MasPicter[i, j]);
                }
            }
        }

        private void WriteToFile()
        {
            string fileName = "results.txt";
            FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);
            aFile.Seek(0, SeekOrigin.End);
            sw.WriteLine(difficult + ";" + time/10);
            sw.Close();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if (k % 2 == 0)
            {
                play.Image = Properties.Resources.pause;
                timer1.Start();
                DisableField(false);
            }
            else
            {
                play.Image = Properties.Resources.play;
                timer1.Stop();
                DisableField(true);
            }

            k++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time % 10 == 0)
            {
                _time.Text = (time/10).ToString();
            }
        }

        private void WhiteBoom(object sender, MouseEventArgs e)
        {
            var pct = sender as PictureBox;

            if (Convert.ToUInt32(pct.Name) > 0 && Convert.ToUInt32(pct.Tag) > 0)  Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name)-1, Convert.ToUInt32(pct.Tag) - 1], e);//ЛВ
            if (Convert.ToUInt32(pct.Tag) > 0) Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name), Convert.ToUInt32(pct.Tag) - 1], e);//СВ
            if (Convert.ToUInt32(pct.Name) < len - 1 && Convert.ToUInt32(pct.Tag) > 0)  Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name) + 1, Convert.ToUInt32(pct.Tag) - 1], e);//ПВ

            if (Convert.ToUInt32(pct.Name) > 0) Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name) - 1, Convert.ToUInt32(pct.Tag)], e);//ЛС
            if (Convert.ToUInt32(pct.Name) < len - 1)  Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name) + 1, Convert.ToUInt32(pct.Tag)], e);//ПС

            if (Convert.ToUInt32(pct.Name) > 0 && Convert.ToUInt32(pct.Tag) < heig - 1)  Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name) - 1, Convert.ToUInt32(pct.Tag) + 1], e);//ЛН
            if (Convert.ToUInt32(pct.Tag) < len - 1)Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name), Convert.ToUInt32(pct.Tag) + 1], e);//СН
            if (Convert.ToUInt32(pct.Name) < len - 1 && Convert.ToUInt32(pct.Tag) < heig - 1)  Pct_MouseClick(MasPicter[Convert.ToUInt32(pct.Name) + 1, Convert.ToUInt32(pct.Tag) + 1], e);//ПН    

        }

        private void PictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu newForm = new MainMenu();
            newForm.Show();
        }

        private void Play_MouseEnter(object sender, EventArgs e)
        {
            play.Height += 10;
            play.Width += 10;
            //play.Location = new Point(play.Location.X - 10, play.Location.X - 10);
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            play.Height -= 10;
            play.Width -= 10;
        }

        private void settings_MouseEnter(object sender, EventArgs e)
        {
            settings.Height += 10;
            settings.Width += 10;
        }

        private void settings_MouseLeave(object sender, EventArgs e)
        {
            settings.Height -= 10;
            settings.Width -= 10;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            exit.Height += 10;
            exit.Width += 10;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            exit.Height -= 10;
            exit.Width -= 10;
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Help newForm = new Help();
            newForm.Show();
        }

        private void PictureBox7_Click_1(object sender, EventArgs e)
        {

        }

        private void _time_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Pct_MouseClick(object sender, MouseEventArgs e)
        {
            var pct = sender as PictureBox;
            var color = Color.Transparent;
            if (e != null && e.Button == MouseButtons.Left)
            {
                if (pct.Text == "false")
                {
                    switch (masField[Convert.ToInt32(pct.Name), Convert.ToInt32(pct.Tag)])
                    {
                        case 0: pct.Visible = false; break;
                        case 1: pct.Image = Properties.Resources._1; pct.BackColor = color; ; break;
                        case 2: pct.Image = Properties.Resources._2; pct.BackColor = color; break;
                        case 3: pct.Image = Properties.Resources._3; pct.BackColor = color; break;
                        case 4: pct.Image = Properties.Resources._4; pct.BackColor = color; break;
                        case 5: pct.Image = Properties.Resources._5; pct.BackColor = color; break;
                        case 6: pct.Image = Properties.Resources._6; pct.BackColor = color; break;
                        case 7: pct.Image = Properties.Resources._7; pct.BackColor = color; break;
                        case 8: pct.Image = Properties.Resources._8; pct.BackColor = color; break;
                        case 9: pct.Image = Properties.Resources._9; pct.BackColor = color; break;
                        case 10: pct.Image = Properties.Resources.bomb; GameOver("lose"); pct.BackColor = Color.Red; break;
                    }

                    pct.Text = "True";

                    if ((masField[Convert.ToUInt32(pct.Name), Convert.ToUInt32(pct.Tag)] == 0))
                    {
                        WhiteBoom(pct, null);
                    }
                }
            }
            else if (e != null && e.Button == MouseButtons.Right)
            {
                pct.BackColor = color;
                pct.Image = Properties.Resources.flag;
                bomb--;
                bomb_count.Text = bomb.ToString();
            }
            else
            {
                if (pct.Text == "false")
                {
                    switch (masField[Convert.ToInt32(pct.Name), Convert.ToInt32(pct.Tag)])
                    {
                        case 0: pct.Visible = false; break;
                        case 1: pct.Image = Properties.Resources._1; pct.BackColor = color; ; break;
                        case 2: pct.Image = Properties.Resources._2; pct.BackColor = color; break;
                        case 3: pct.Image = Properties.Resources._3; pct.BackColor = color; break;
                        case 4: pct.Image = Properties.Resources._4; pct.BackColor = color; break;
                        case 5: pct.Image = Properties.Resources._5; pct.BackColor = color; break;
                        case 6: pct.Image = Properties.Resources._6; pct.BackColor = color; break;
                        case 7: pct.Image = Properties.Resources._7; pct.BackColor = color; break;
                        case 8: pct.Image = Properties.Resources._8; pct.BackColor = color; break;
                        case 9: pct.Image = Properties.Resources._9; pct.BackColor = color; break;
                        case 10: pct.Image = Properties.Resources.bomb; pct.BackColor = color; break;
                    }

                    pct.Text = "True";

                    if ((masField[Convert.ToUInt32(pct.Name), Convert.ToUInt32(pct.Tag)] == 0))
                    {
                        WhiteBoom(pct, null);
                    }
                }
            }

            GameOver("iswin");

        }

        private void DisableField(bool tf)
        {
            if (tf == true)
            {
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < heig; j++)
                    {
                        MasPicter[i, j].Enabled = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < len; i++)
                {
                    for (int j = 0; j < heig; j++)
                    {
                        MasPicter[i, j].Enabled = true;
                    }
                }
            }

        }
    }
}
