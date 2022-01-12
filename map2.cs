using System;
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
    public partial class map2 : Form
    {
        public map2()
        {
            InitializeComponent();
        }

        private void map2_Load(object sender, EventArgs e)
        {
            //System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            //Button_Path.AddEllipse(0, 0, this.button2.Width, this.button2.Height);
            //Region Button_Region = new Region(Button_Path);
            //this.button2.Region = Button_Region;
            //button2.FlatAppearance.BorderSize = 0; button2.FlatStyle = FlatStyle.Flat;

            //System.Drawing.Drawing2D.GraphicsPath Button_Path1 = new System.Drawing.Drawing2D.GraphicsPath();
            //Button_Path.AddEllipse(0, 0, this.button1.Width, this.button1.Height);
            //Region Button_Region1 = new Region(Button_Path);
            //this.button1.Region = Button_Region;
            //button1.FlatAppearance.BorderSize = 0; button1.FlatStyle = FlatStyle.Flat;

            //System.Drawing.Drawing2D.GraphicsPath Button_Path3 = new System.Drawing.Drawing2D.GraphicsPath();
            //Button_Path.AddEllipse(0, 0, this.button3.Width, this.button3.Height);
            //Region Button_Region3 = new Region(Button_Path);
            //this.button3.Region = Button_Region;
            //button3.FlatAppearance.BorderSize = 0; button3.FlatStyle = FlatStyle.Flat;



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form5 Form5 = new Form5();
                Form5.Show();
                Form5.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form5 Form5 = new Form5();
                Form5.Show();
                Form5.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form5 Form5 = new Form5();
                Form5.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Sudoku cr21 = new Sudoku();
                cr21.Show();
                cr21.SetColorPurple2();
            }
            else if (panel1.BackColor == Color.HotPink)
            {
                this.Hide();
                Sudoku cr22 = new Sudoku();
                cr22.Show();
                cr22.SetColorPink2();

            }

            else
            {
                this.Hide();

                Sudoku LoginForm = new Sudoku();
                LoginForm.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form4 Form4 = new Form4();
                Form4.Show();
                Form4.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form4 Form4 = new Form4();
                Form4.Show();
                Form4.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form4 Form4 = new Form4();
                Form4.Show();
            }





        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form6 Form6 = new Form6();
                Form6.Show();
                Form6.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form6 Form6 = new Form6();
                Form6.Show();
                Form6.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form6 Form6 = new Form6();
                Form6.Show();
            };
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void SetColorPurple4()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.DarkMagenta;
                panel2.BackColor = Color.BlueViolet;
                panel3.BackColor = Color.MediumPurple;
                label1.BackColor = Color.BlueViolet;
                pictureBox1.BackColor = Color.DarkMagenta;
                label1.ForeColor = Color.DeepPink;

            });
            this.Invoke(Invoker);

        }

        public void SetColorPink4()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.HotPink;
                panel2.BackColor = Color.DeepPink;
                panel3.BackColor = Color.DeepPink;
                label1.BackColor = Color.DeepPink;
                label2.BackColor = Color.DeepPink;
                label1.ForeColor = Color.AliceBlue;
                pictureBox1.BackColor = Color.HotPink;
            });
            this.Invoke(Invoker);

        }

    }
}
