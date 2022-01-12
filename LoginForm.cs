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
    public partial class Sudoku : Form
    {
        public Sudoku()
        {
            InitializeComponent();
            SetRoundedShape(panel3, 30);
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
            

        }
        public void SetColorPurple2()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.DarkMagenta;
                panel3.BackColor = Color.BlueViolet;
                panel2.BackColor = Color.MediumPurple;
                label1.BackColor = Color.BlueViolet;
               
                label1.ForeColor = Color.DeepPink;

            });
            this.Invoke(Invoker);

        }

        public void SetColorPink2()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.HotPink;
                panel3.BackColor = Color.DeepPink;
                panel2.BackColor = Color.DeepPink;
                label1.BackColor = Color.DeepPink;
                label3.BackColor = Color.DeepPink;
                label1.ForeColor = Color.AliceBlue;

            });
            this.Invoke(Invoker);

        }
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 80);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                map2 cr23 = new map2();
                // Sudoku cr21 = new Sudoku();
                this.Hide();

                cr23.Show();
                cr23.SetColorPurple4();
            }
            else if (panel3.BackColor == Color.DeepPink)
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (panel1.BackColor == Color.DarkMagenta)
            {
                map cr23 = new map();
                // Sudoku cr21 = new Sudoku();
                this.Hide();
                
                cr23.Show();
                cr23.SetColorPurple3();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                map cr31 = new map();
                cr31.Show();
                cr31.SetColorPink3();
                this.Hide();

            }


            else
            {
                
            this.Hide();
            map map = new map();
            map.Show();
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                map3 cr23 = new map3();
                // Sudoku cr21 = new Sudoku();
                this.Hide();

                cr23.Show();
                cr23.SetColorPurple5();
            }
            else if (panel3.BackColor == Color.DeepPink)
            {
                map3 cr31 = new map3();
                cr31.Show();
                cr31.SetColorPink5();
                this.Hide();

            }


            else
            {

                this.Hide();
                map3 map3 = new map3();
                map3.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.DarkMagenta)
            {
                main cr2 = new main();
                // Sudoku cr21 = new Sudoku();
                this.Hide();
                //cr21.Show();
                cr2.Show();
                cr2.SetColorPurple();
            }
             else if(panel3.BackColor == Color.DeepPink)
                {
                main cr3 = new main();
                cr3.Show();
                cr3.SetColorPink();
                this.Hide();

            }

            
            else
            {
                main cr1 = new main();
                cr1.Show();
                cr1.SetColorBlue();
                this.Hide();
            }

        }
    }
}
