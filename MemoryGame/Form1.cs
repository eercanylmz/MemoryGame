using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rndm = new Random();
        int duration = 10;
        int numberoflines = 0;

        private void TextboxFalse()
        {
            // Form üzerindeki tüm kontrol öğelerini dolaş
            foreach (Control control in Controls)
            {
                // Eğer kontrol bir TextBox ise
                if (control is TextBox textBox)
                {
                    // TextBox'ın Enabled özelliğini false yap
                    textBox.Enabled = false;
                }
            }
        }

        private  void TextBoxTrue()
        {
            foreach (Control control in Controls)
            {
                if(control is TextBox textBox)
                {
                    textBox.Enabled = true;
                    
                }
            }
        }
        private void TextBoxClear()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();

                }
            }
        }
        private void randoom()
        {
            timer1.Start();
            int number1, number2, number3, number4, number5, number6, number7, number8, number9, number10, number11, number12;
            number1 = rndm.Next(0, 50);
            number2 = rndm.Next(0, 50);
            number3 = rndm.Next(0, 50);
            number4 = rndm.Next(0, 50);
            number5 = rndm.Next(0, 50);
            number6 = rndm.Next(0, 50);
            number7 = rndm.Next(0, 50);
            number8 = rndm.Next(0, 50);
            number9 = rndm.Next(0, 50);
            number10 = rndm.Next(0, 50);
            number11= rndm.Next(0, 50);
            number12 = rndm.Next(0, 50); 




            label1.Text = number1.ToString();
            label2.Text = number2.ToString();
            label3.Text = number3.ToString();
            label4.Text = number4.ToString();
            label5.Text = number5.ToString();
            label6.Text = number6.ToString();
            label7.Text = number7.ToString();
            label8.Text = number8.ToString();
            label9.Text = number9.ToString();
            label10.Text = number10.ToString();
            label11.Text = number11.ToString();
            label12.Text = number2.ToString();
        }
        private void TextboxColor()
        {
            if (textBox1.Text == label1.Text) { textBox1.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox1.ForeColor = Color.Red; }



            if (textBox2.Text == label2.Text) { textBox2.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox2.ForeColor = Color.Red; }



            if (textBox3.Text == label3.Text) { textBox3.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox3.ForeColor = Color.Red; }



            if (textBox4.Text == label4.Text) { textBox4.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox4.ForeColor = Color.Red; }


            if (textBox5.Text == label5.Text) { textBox5.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox5.ForeColor = Color.Red; }



            if (textBox6.Text == label6.Text) { textBox6.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox6.ForeColor = Color.Red; }



            if (textBox7.Text == label7.Text) { textBox7.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox7.ForeColor = Color.Red; }



            if (textBox8.Text == label8.Text) { textBox8.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox8.ForeColor = Color.Red; }


            if (textBox9.Text == label9.Text) { textBox9.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox9.ForeColor = Color.Red; }



            if (textBox10.Text == label10.Text) { textBox10.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox10.ForeColor = Color.Red; }



            if (textBox11.Text == label11.Text) { textBox11.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox11.ForeColor = Color.Red; }



            if (textBox12.Text == label12.Text) { textBox12.ForeColor = Color.Green; numberoflines++; label17.Text = numberoflines.ToString(); }
            else { textBox12.ForeColor = Color.Red; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            TextboxColor();
            duration = 10; 
            button3.Visible = false;
            randoom();
            groupBox1.Visible = true;
            TextBoxClear();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            TextboxFalse();
            button1.Visible = false;
            randoom();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            duration--;
            label13.Text = duration.ToString();
            if (duration == 0)
            {
                timer1.Stop(); 
                groupBox1.Visible = false;
                button1.Text = "SHOW AGAİN";
                button3.Visible  = true;
                TextBoxTrue();
                
            }
        }
    
        private void button3_Click(object sender, EventArgs e)
        {
   
            TextboxFalse();
            duration = 10;
            timer1.Start();
            groupBox1.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Visible  = false;
            groupBox1.Visible = true;
        }
    }
}
