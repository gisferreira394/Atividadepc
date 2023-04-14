using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = true;
            this.pictureBox3.Visible = true;

            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
           
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox6.Visible = false;

            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Visible= true;
                this.pictureBox5.Visible= true;
                this.pictureBox6.Visible= true;

            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;

            this.pictureBox1.Visible = false;
this.pictureBox2.Visible= false;
            this.pictureBox3.Visible= false;

            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox3.Visible = true;

            this.label3.Visible = true;

            this.label2.Visible = false;
            this.label1.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;

            this.pictureBox2.Visible = false;
            this.pictureBox5.Visible = false; 
            this.pictureBox4.Visible = false;
            this.pictureBox1.Visible = false;
            this.pictureBox6.Visible = false;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox4.Visible = true;
            this.label4.Visible = true;

            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label1.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;

            this.pictureBox5.Visible = false; 
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
            this.pictureBox6.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox1.Visible= true;
            this.label1.Visible= true;

            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;

            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible= false;
            this.pictureBox6.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox2.Visible = true;
            this.label2.Visible = true;

            this.label1.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;

            this.pictureBox1.Visible = false;
            this.pictureBox3.Visible= false;    
            this.pictureBox4.Visible= false;
            this.pictureBox5.Visible= false;
            this.pictureBox6.Visible= false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox5.Visible = true;
            this.label5.Visible = true;

            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label1.Visible = false;
            this.label6.Visible = false;

            this.pictureBox4.Visible= false;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible=false;
            this.pictureBox3.Visible=false;
            this.pictureBox6.Visible = false;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            this.pictureBox6.Visible = true;
            this.label6.Visible = true;

            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label1.Visible = false;

            this.pictureBox5.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = false;
            this.pictureBox2.Visible = false;
            this.pictureBox3.Visible = false;
            this.pictureBox4.Visible = false;
            this.pictureBox5.Visible = false;
            this.pictureBox6.Visible = false;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.label6.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
              
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Visible = true;
            this.pictureBox2.Visible = true;
            this.pictureBox3.Visible = true;
            this.pictureBox4.Visible = true;
            this.pictureBox5.Visible = true;
            this.pictureBox6.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = true;
            this.radioButton1.Visible = true;
            this.radioButton2.Visible = true;
            this.radioButton3.Visible = true;
            this.radioButton4.Visible = true;
            this.radioButton5.Visible = true;
            this.radioButton6.Visible = true;
            this.radioButton7.Visible = true;
            this.radioButton8.Visible = true;
        }
    }
}
