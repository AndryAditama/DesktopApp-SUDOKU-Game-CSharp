using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku2
{
    public partial class Form1 : Form
    {
        int mnt, dtk;
        int data = 0;
        TextBox[][] duaDimensi;
        bool[][] soal;
        int[][] salah;
        private static int hasil = 0;
        private static int BxK = 3;
        private static int baris = 9;
        private static int kolom = 9;
        private static int BxK_split = baris / BxK;
        private static int Btemp = BxK_split;
        private static int Ktemp = BxK_split;
        private static bool problem_state = true;
        private static int error;
        private static int errorCount = 0;
        private static bool win = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbmenit.Text = "0";
            lbdetik.Text = "0";
            duaDimensi = new TextBox[baris][];
            soal = new bool[baris][];
            salah = new int[baris][];
            int posY = 90;
            for (int i = 0; i < baris; i++)
            {
                duaDimensi[i] = new TextBox[kolom];
                soal[i] = new bool[kolom];
                salah[i] = new int[kolom];
            }

            for (int b = 0; b < baris; b++)
            {
                int posX = 66;
                Ktemp = BxK_split;
                for (int k = 0; k < duaDimensi[b].Length; k++)
                {
                    soal[b][k] = false;
                    salah[b][k] = 0;
                    duaDimensi[b][k] = new TextBox();
                    duaDimensi[b][k].Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    duaDimensi[b][k].MaxLength = 1;

                    if ((b == Btemp) && (k == Ktemp))
                    {
                        duaDimensi[b][k].Location = new System.Drawing.Point(posX + 3, posY + 3);
                    }
                    else if (b == Btemp)
                    {
                        duaDimensi[b][k].Location = new System.Drawing.Point(posX, posY + 3);
                    }
                    else if (k == Ktemp)
                    {
                        duaDimensi[b][k].Location = new System.Drawing.Point(posX + 3, posY);
                    }
                    else 
                    {
                        duaDimensi[b][k].Location = new System.Drawing.Point(posX, posY);
                    }

                    duaDimensi[b][k].Name = "map";
                    duaDimensi[b][k].Size = new System.Drawing.Size(38, 38);
                    duaDimensi[b][k].TabIndex = 2;
                    duaDimensi[b][k].TabStop = false;
                    duaDimensi[b][k].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    Controls.Add(duaDimensi[b][k]);

                    if (k == Ktemp)
                        Ktemp = Ktemp + (BxK_split);
                        posX = posX + 37;
                    
                }
                if (b == Btemp)
                    Btemp = Btemp + (BxK_split);
                posY = posY + 37;
            }
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            solvingToolStripMenuItem.Enabled = false;
            timer1.Start();
            notif.Text = "Game Dimulai COK!";

            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    duaDimensi[j][i].Enabled = true;
                }
            }
        }

        private void tbClear_Click(object sender, EventArgs e)
        {
            resettimer();
            hasil = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    duaDimensi[j][i].BackColor = System.Drawing.Color.White;
                    duaDimensi[j][i].ReadOnly = false;
                    duaDimensi[j][i].Text = "";
                }
            }
        }

        private void selesai()
        {
            int mari = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (duaDimensi[j][i].TextLength > 0)
                        mari++;
                }
            }
            if ((mari == 81) && (error == 0))
            {
                timer1.Enabled = false;
                MessageBox.Show("Selesai", "Game Selesai!");
            }
                
        }

        private void tbPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    duaDimensi[j][i].Enabled = false;
                }
            }
        }

        private void tbCheck_Click(object sender, EventArgs e)
        {
            error = 0;
            hasil = 0;

            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    duaDimensi[j][i].BackColor = System.Drawing.Color.White;
                    if (duaDimensi[j][i].Text != "")
                    {
                        char temp = Convert.ToChar(duaDimensi[j][i].Text);
                        hasil = periksarule(j, i, temp);
                        if ((hasil == 0) && (error == 0))
                        {
                            notif.Text = "Mantap Tod!";
                        }
                        if (hasil == 1)
                        {
                            notif.Text = "Salah Goblok!";
                        }
                        if ((hasil == 10) || (hasil == 110))
                        {
                            notif.Text = "Salah Tod!";
                        }
                        if ((hasil == 100) || (hasil == 110))
                        {
                            notif.Text = "Jancok, Salah Cok!";
                        }
                        if (hasil >= 1000)
                        {
                            notif.Text = "Anda Bego!";
                        }
                    }
                }
            }
            selesai();
        }

        private void solvingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btStart.Enabled = true;
            notif.Text = "Klik Mulai!";
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    duaDimensi[j][i].Enabled = false;
                    soal[j][i] = false;
                }
            }
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (duaDimensi[j][i].TextLength > 0)
                    {
                        duaDimensi[j][i].ReadOnly = true;
                        soal[j][i] = true;
                    }
                    
                }
            }
        }

        private int periksarule(int baris, int kolom, char angka1)
        {
            if (char.IsDigit(angka1) == false)
            {
                duaDimensi[baris][kolom].BackColor = System.Drawing.Color.Red;
                error++;
                hasil = hasil + 1;
                return hasil;
            }
            string tempAngka = Convert.ToString(angka1);
            int angka = Convert.ToInt32(tempAngka);
            int counter;

            counter = 0;
            for (int i = 0; i < 9; i++)
            {
                if (duaDimensi[baris][i].Text.All(char.IsDigit) == true)
                {
                    if (duaDimensi[baris][i].Text != "")
                    {
                        data = Convert.ToInt32(duaDimensi[baris][i].Text);
                        if (data == angka)
                        {
                            counter++;
                        }
                    }
                }
            }
            if (counter != 1)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (duaDimensi[baris][i].Text.All(char.IsDigit) == true)
                    {
                        if (duaDimensi[baris][i].Text != "")
                        {
                            data = Convert.ToInt32(duaDimensi[baris][i].Text);
                            if (data == angka)
                            {
                                duaDimensi[baris][i].BackColor = System.Drawing.Color.Red;
                            }

                        }
                        else
                        {
                            duaDimensi[baris][i].BackColor = System.Drawing.Color.LightPink;
                        }
                    }

                }
                hasil = hasil + 10;
                error++;
            }
            counter = 0;
            for (int j = 0; j < 9; j++)
            {
                if (duaDimensi[j][kolom].Text.All(char.IsDigit) == true)
                {
                    if (duaDimensi[j][kolom].Text != "")
                    {
                        int temp = Convert.ToInt32(duaDimensi[j][kolom].Text);
                        if (temp == angka)
                        {
                            counter++;
                        }

                    }
                }
            }
            if (counter != 1)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (duaDimensi[j][kolom].Text.All(char.IsDigit) == true)
                    {
                        if (duaDimensi[j][kolom].Text != "")
                        {
                            int temp = Convert.ToInt32(duaDimensi[j][kolom].Text);
                            if (temp == angka)
                            {
                                duaDimensi[j][kolom].BackColor = System.Drawing.Color.Red;
                            }

                        }
                        else
                        {
                            duaDimensi[j][kolom].BackColor = System.Drawing.Color.LightPink;
                        }
                    }
                }
                hasil = hasil + 100;
                error++;
            }
            int bariskotak = baris / 3;
            int kolomkotak = kolom / 3;
            int awalbaris = bariskotak * 3;
            int awalkolok = kolomkotak * 3;

            counter = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (duaDimensi[awalbaris + j][awalkolok + i].Text.All(char.IsDigit) == true)
                    {
                        if (duaDimensi[awalbaris + j][awalkolok + i].Text != "")
                        {
                            int temp = Convert.ToInt32(duaDimensi[awalbaris + j][awalkolok + i].Text);
                            if (temp == angka)
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
            if (counter != 1)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (duaDimensi[awalbaris + j][awalkolok + i].Text.All(char.IsDigit)==true)
                        {
                            if (duaDimensi[awalbaris + j][awalkolok + i].Text != "")
                            {
                                int temp = Convert.ToInt32(duaDimensi[awalbaris + j][awalkolok + i].Text);
                                if (temp == angka)
                                {
                                    duaDimensi[awalbaris + j][awalkolok + i].BackColor = System.Drawing.Color.Red;
                                }
                            }
                            else
                            {
                                duaDimensi[awalbaris + j][awalkolok + i].BackColor = System.Drawing.Color.LightPink;
                            }
                        }
                    }
                }
                hasil = hasil + 1000;
                error++;
            }
            notif.Text = Convert.ToString(hasil);
            return hasil;
        }


        private void resettimer()
        {
            mnt = 0;
            dtk = 0;
            lbmenit.Text = "";
            lbdetik.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                dtk++;
                if (dtk >= 60)
                {
                    mnt++;
                    dtk = 0;
                }
            }
            tampilan();
        }

        private void tampilan()
        {
            lbmenit.Text = dtk.ToString();
            lbdetik.Text = mnt.ToString();
        }

        private void tbStop_Click(object sender, EventArgs e)
        {
            resettimer();
            timer1.Enabled = false;
            hasil = 0;
            for (int j = 0; j < 9; j++)
            {
                for (int i = 0; i < 9; i++)
                {
                    duaDimensi[j][i].BackColor = System.Drawing.Color.White;
                    duaDimensi[j][i].ReadOnly = false;
                    duaDimensi[j][i].Text = "";
                }
            }
            selesai();
            solvingToolStripMenuItem.Enabled = true;
        }







    }
}
