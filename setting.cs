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
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void Set()
        {
            int i = 0;
        }

        public void button1_Click(object sender, EventArgs e)
        
        {
           
            switch(comboBox1.SelectedIndex)
            {
        
                case 0:
                    main cr1 = new main();
                    cr1.Show();
                    cr1.SetColorBlue();
                    this.Hide();
                   
                    break;
                    
                 
                case 1: 
                    main cr2 = new main();
                   // Sudoku cr21 = new Sudoku();
                this.Hide();
                    //cr21.Show();
                    cr2.Show();
                    cr2.SetColorPurple();
                    //cr21.SetColorPurple2();



                    break;
                case 2:

                    main cr3 = new main();
                    cr3.Show();
                    cr3.SetColorPink();
                    this.Hide();
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main main = new main();
            main.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
