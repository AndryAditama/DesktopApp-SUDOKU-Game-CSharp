using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{

    public partial class Form1 : Form
    {
        TextBox[][] box;
        private static int detik = 0;
        private static int menit = 0;
        private static int jam = 0;
        private static int[][] soal;
        private static int[][] salah;
        private static int hasil = 0;

        private static int BK_split = 9 / 3;
        private static int Btemp = BK_split;
        private static int Ktemp = BK_split;
        private static bool problemState = true;
        private static int cekEror = 0;
        private static bool menang = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop();

            box = new TextBox[9][];
            soal = new int[9][];
            salah = new int[9][];

            int posY = 60;

            for (int i = 0; i < 9; i++ )
            {
                box[i] = new TextBox[9];
                soal[i] = new int[9];
                salah[i] = new int[9];
            }

            for (int b = 0; b < 9; b++)
            {
                int posX = 44;

                Ktemp = BK_split;
                for (int k = 0; k < box[b].Length; k++)
                {
                    soal[b][k] = 0;
                    salah[b][k] = 0;
                    box[b][k] = new TextBox();
                    box[b][k].Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular);
                    box[b][k].MaxLength = 1;

                    if ((b == Btemp) && (k == Ktemp))
                    {
                        box[b][k].Location = new System.Drawing.Point(posX + 3, posY + 3);
                    }
                    else if (b == Btemp)
                    {
                        box[b][k].Location = new System.Drawing.Point(posX, posY + 3);
                    }
                    else if (k == Ktemp)
                    {
                        box[b][k].Location = new System.Drawing.Point(posX + 3, posY);
                    }
                    else 
                    {
                        box[b][k].Location = new System.Drawing.Point(posX, posY);
                    }
                    box[b][k].Name = "box";
                    box[b][k].Size = new System.Drawing.Size(38, 38);
                    box[b][k].TabIndex = 2;
                    box[b][k].TabStop = false;
                    box[b][k].TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

                    Controls.Add(box[b][k]);

                    if (k == Ktemp)
                        Ktemp = Ktemp + (BK_split);
                    posX = posY + 37;
                }

                if (b == Btemp)
                    Btemp = Btemp + (BK_split);
                posY = posY + 37;
            }
        }

        private int RuleCheck(int barisY, int kolomX, char angkaTemp)
        {
            if (char.IsDigit(angkaTemp) != true)
            {
                cekEror++;
                salah[barisY][kolomX] = 99;
                hasil = hasil + 1;
                return hasil;
            }

            string tempData = char.ToString(angkaTemp);
            int angka = Convert.ToInt32(tempData);
            int counter;
            hasil = 0;

            if (!((angka >= 1) && (angka <= 9)))
            {
                cekEror++;
                salah[barisY][kolomX] = 99;
                hasil = hasil + 1;
            }

            counter = 0;
            for (int x = 0; x < 9; x++)
            {
                if(box[barisY][x].Text.All(char.IsDigit)==true)
                {
                    if (box[barisY][x].Text != "")
                    {
                    int temp = Convert.ToInt32(box[barisY][x].Text);
                    if (temp == angka)
                        counter++;
                    }
                } 
            }

        }

    }
}
