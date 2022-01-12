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
    public partial class map : Form
    {
        public map()
        {
            InitializeComponent();
        }

        
        private void map_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
                Form1.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form1 Form1 = new Form1();
                Form1.Show();
                Form1.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
            }
        
    }

        private void button2_Click(object sender, EventArgs e)
        {

            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
                Form1.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form1 Form1 = new Form1();
                Form1.Show();
                Form1.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form1 Form1 = new Form1();
                Form1.Show();
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
            
        }

        private void button3_Click(object sender, EventArgs e)
        {



            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form3 Form3 = new Form3();
                Form3.Show();
                Form3.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form3 Form3 = new Form3();
                Form3.Show();
                Form3.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form3 Form3 = new Form3();
                Form3.Show();
            }
        }

        public void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetColorPurple3()
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

        public void SetColorPink3()
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
