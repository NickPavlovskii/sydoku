using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace WindowsFormsApp1
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            SetRoundedShape(panel1, 30);
            SetRoundedShape1(panel2, 30);


        }




        public void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        public void SetColorPurple()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.Navy;
                panel2.BackColor = Color.SlateBlue; 
                 button2.BackColor = Color.Plum;
                button3.BackColor = Color.Plum;
                button6.BackColor = Color.Plum;
                
            });
        
            this.Invoke(Invoker);
        }
        public void SetColorPink()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.Fuchsia;
                panel2.BackColor = Color.DeepPink;
                button2.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;
                button6.BackColor = Color.Pink;
            });

            this.Invoke(Invoker);
        }
        
        public void SetColorBlue()
        {
            MethodInvoker Invoker = new MethodInvoker(delegate
            {
                panel1.BackColor = Color.SteelBlue;
                panel2.BackColor = Color.DodgerBlue;
                button2.BackColor = Color.PaleTurquoise;
                button3.BackColor = Color.PaleTurquoise;
                button6.BackColor = Color.PaleTurquoise;

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

        static void SetRoundedShape1(Control contro2, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, contro2.Width - radius, 0);
            path.AddArc(contro2.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(contro2.Width, radius, contro2.Width, contro2.Height - radius);
            path.AddArc(contro2.Width - radius, contro2.Height - radius, radius, radius, 0, 80);
            path.AddLine(contro2.Width - radius, contro2.Height, radius, contro2.Height);
            path.AddArc(0, contro2.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, contro2.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            contro2.Region = new Region(path);
        }

        

        void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if(panel1.BackColor == Color.Navy)
            {
this.Hide();
Sudoku cr21 = new Sudoku();
           cr21.Show();
            cr21.SetColorPurple2();
            }
            else if(panel1.BackColor ==Color.Fuchsia)
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

        public void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            setting setting = new setting();
            setting.Show();

           

            //Делаем кнопку круглой
            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.button2.Width, this.button2.Height);
            Region Button_Region = new Region(Button_Path);
            this.button2.Region = Button_Region;


        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 0, 255));
            Pen pen = new Pen(linGrBrush);
            e.Graphics.FillRectangle(linGrBrush, 0, 0, button3.Width, button3.Height);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.button2.Width, this.button2.Height);
            Region Button_Region = new Region(Button_Path);
            this.button2.Region = Button_Region;
            button2.FlatAppearance.BorderSize = 0; button2.FlatStyle = FlatStyle.Flat;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            rules rules = new rules();
            rules.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load_1(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath Button_Path = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.button2.Width, this.button2.Height);
            Region Button_Region = new Region(Button_Path);
            this.button2.Region = Button_Region;
            button2.FlatAppearance.BorderSize = 0; 
            button2.FlatStyle = FlatStyle.Flat;

            System.Drawing.Drawing2D.GraphicsPath Button_Path1 = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.button3.Width, this.button3.Height);
            Region Button_Region1 = new Region(Button_Path);
            this.button3.Region = Button_Region;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;

            System.Drawing.Drawing2D.GraphicsPath Button_Path6 = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.button6.Width, this.button6.Height);
            Region Button_Region6 = new Region(Button_Path);
            this.button6.Region = Button_Region;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;

            System.Drawing.Drawing2D.GraphicsPath Button_Path4 = new System.Drawing.Drawing2D.GraphicsPath();
            Button_Path.AddEllipse(0, 0, this.button4.Width, this.button4.Height);
            Region Button_Region4 = new Region(Button_Path);
            this.button4.Region = Button_Region;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            
            var url = pictureBox4.Text; //адрес ссылки это значение свойства `Text`
           
            System.Diagnostics.Process.Start("https://vk.com/o_0niklad0_o");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            var url1 = pictureBox3.Text; //адрес ссылки это значение свойства `Text`

            System.Diagnostics.Process.Start("https://www.instagram.com/o__niklad__o/");
       
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var url2 = pictureBox5.Text; //адрес ссылки это значение свойства `Text`

            System.Diagnostics.Process.Start("https://github.com/NickPavlovskii/");
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }


    
}
