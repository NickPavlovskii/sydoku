﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            GenerateMap();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        const int n = 2;
        const int sizeButton2 = 50;
        public int[,] map = new int[n * n, n * n];
        public Button[,] buttons = new Button[n * n, n * n];

        public void SetColorPr6()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {

                button1.ForeColor = Color.Indigo;
                button2.ForeColor = Color.Indigo;
            });
            this.Invoke(Invoker);

        }
        public void SetColorPi6()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {

                button1.ForeColor = Color.Crimson;
                button2.ForeColor = Color.Crimson;
            });
            this.Invoke(Invoker);

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }






        public void GenerateMap()
        {

            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    map[i, j] = (i * n + i / n + j) % (n * n) + 1;
                    Button button = new Button();
                    buttons[i, j] = button;
                    button.Size = new Size(sizeButton2, sizeButton2);
                    button.Text = map[i, j].ToString();
                    button.Click += OnCellPressed;
                    button.Location = new Point(j * sizeButton2, i * sizeButton2);
                    this.Controls.Add(button);

                }
            }

            //MatrixTransposition();
            //SwapRowsInBlock();
            //SwapColumnsInBlock();

            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                ShuffleMap(r.Next(0, 5));
            }

            CreateMap();
            HideCells();



        }

        public void HideCells()
        {
            int N = 6;
            Random r = new Random();
            while (N > 0)
            {
                for (int i = 0; i < n * n; i++)
                {
                    for (int j = 0; j < n * n; j++)
                    {
                        if (!string.IsNullOrEmpty(buttons[i, j].Text))
                        {
                            int a = r.Next(0, 3);
                            buttons[i, j].Text = a == 0 ? "" : buttons[i, j].Text;
                            buttons[i, j].Enabled = a == 0 ? true : false;

                            if (a == 0)
                                N--;
                            if (N <= 0)
                                break;
                        }
                    }
                    if (N <= 0)
                        break;
                }
            }


        }
        public void ShuffleMap(int i)
        {
            switch (i)
            {
                case 0:
                    MatrixTransposition();
                    break;
                case 1:
                    SwapRowsInBlock();
                    break;
                case 2:
                    SwapColumnsInBlock();
                    break;
                case 3:
                    SwapBlocksInRow();
                    break;
                case 4:
                    SwapBlocksInColumn();
                    break;
                default:
                    MatrixTransposition();
                    break;
            }
        }

        public void SwapBlocksInColumn()
        {
            Random r = new Random();
            var block1 = r.Next(0, n);
            var block2 = r.Next(0, n);
            while (block1 == block2)
                block2 = r.Next(0, n);
            block1 *= n;
            block2 *= n;
            for (int i = 0; i < n * n; i++)
            {
                var k = block2;
                for (int j = block1; j < block1 + n; j++)
                {
                    var temp = map[i, j];
                    map[i, j] = map[i, k];
                    map[i, k] = temp;
                    k++;
                }
            }
        }

        public void SwapBlocksInRow()
        {
            Random r = new Random();
            var block1 = r.Next(0, n);
            var block2 = r.Next(0, n);
            while (block1 == block2)
                block2 = r.Next(0, n);
            block1 *= n;
            block2 *= n;
            for (int i = 0; i < n * n; i++)
            {
                var k = block2;
                for (int j = block1; j < block1 + n; j++)
                {
                    var temp = map[j, i];
                    map[j, i] = map[k, i];
                    map[k, i] = temp;
                    k++;
                }
            }
        }
        public void SwapRowsInBlock()
        {
            Random r = new Random();
            var block = r.Next(0, n);
            var row1 = r.Next(0, n);
            var line1 = block * n + row1;
            var row2 = r.Next(0, n);
            while (row1 == row2)
                row2 = r.Next(0, n);
            var line2 = block * n + row2;
            for (int i = 0; i < n * n; i++)
            {
                var temp = map[line1, i];
                map[line1, i] = map[line2, i];
                map[line2, i] = temp;
            }
        }

        public void SwapColumnsInBlock()
        {
            Random r = new Random();
            var block = r.Next(0, n);
            var row1 = r.Next(0, n);
            var line1 = block * n + row1;
            var row2 = r.Next(0, n);
            while (row1 == row2)
                row2 = r.Next(0, n);
            var line2 = block * n + row2;
            for (int i = 0; i < n * n; i++)
            {
                var temp = map[i, line1];
                map[i, line1] = map[i, line2];
                map[i, line2] = temp;
            }
        }

        public void MatrixTransposition()
        {
            int[,] tMap = new int[n * n, n * n];
            for (int i = 0; i < n * n; i++)
            {
                for (int j = 0; j < n * n; j++)
                {
                    tMap[i, j] = map[j, i];
                }
            }
            map = tMap;
        }
        public void CreateMap()
        {

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {



                    Button button = new Button();

                    button.Size = new Size(sizeButton2, sizeButton2);
                    button.Text = map[i, j].ToString();

                    button.Location = new Point(j * sizeButton2, i * sizeButton2);
                    this.Controls.Add(button);
                }
            }



        }

        public void OnCellPressed(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string buttonText = pressedButton.Text;
            if (string.IsNullOrEmpty(buttonText))
            {
                pressedButton.Text = "1";
            }
            else
            {
                int num = int.Parse(buttonText);
                num++;
                if (num == 5)
                    num = 1;
                pressedButton.Text = num.ToString();
            }

        }





        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (button1.ForeColor == Color.Indigo)
            {
                map2 cr23 = new map2();
                // Sudoku cr21 = new Sudoku();
                this.Hide();

                cr23.Show();
                cr23.SetColorPurple4();
            }
            else if (button1.ForeColor == Color.Pink)
            {
                map2 cr33 = new map2();
                cr33.Show();
                cr33.SetColorPink4();
                this.Hide();

            }


            else
            {

                this.Hide();
                map2 map2 = new map2();
                map2.Show();
            };
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var btnText = buttons[i, j].Text;
                   
                    if (btnText != map[i, j].ToString())
                    {
                        MessageBox.Show("Неверно!");
                        return;
                    }
                    else MessageBox.Show("Верно!");

                }
            }
           
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            var x = r.Next(0, n);
            var y = r.Next(0, n);



            if (buttons[x, y].Text == "")
            {

                buttons[x, y].Text = map[x, y].ToString();
                return;

            }
            else
            {
                x = r.Next(0, n);
                y = r.Next(0, n);
                buttons[x, y].Text = map[x, y].ToString();
                return;
            }



        }
                    
                
            
        
    } 
}
  
