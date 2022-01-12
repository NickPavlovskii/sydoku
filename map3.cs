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
    public partial class map3 : Form
    {
        public map3()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form7 Form7 = new Form7();
                Form7.Show();
                Form7.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form7 Form7 = new Form7();
                Form7.Show();
                Form7.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form7 Form7 = new Form7();
                Form7.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form8 Form8 = new Form8();
                Form8.Show();
                Form8.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form8 Form8 = new Form8();
                Form8.Show();
                Form8.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form8 Form8 = new Form8();
                Form8.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                this.Hide();
                Form9 Form9 = new Form9();
                Form9.Show();
                Form9.SetColorPr6();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                Form9 Form9 = new Form9();
                Form9.Show();
                Form9.SetColorPi6();
                this.Hide();
            }
            else
            {
                this.Hide();
                Form9 Form9 = new Form9();
                Form9.Show();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetColorPurple5()
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

        public void SetColorPink5()
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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
