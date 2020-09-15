using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alıştırma_2
{
    public partial class Form1 : Form
    {
        int soruno = 0,doğru=0,yanlış=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;





            soruno++;
            label4.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Atatürk hangi tarihte doğdu?";
                button1.Text = "1980";
                button2.Text = "1981";
                button3.Text = "1923";
                button4.Text = "1881";

                label8.Text = "1881";


            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Dünyanın etrafında dönen gezegen nedir?";
                button1.Text = "Satürn";
                button2.Text = "Ay";
                button3.Text = "Güneş";
                button4.Text = "Plüton";

                label8.Text = "Ay";


            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Sarıyla mavi karışınca hangi renk ortaya çıkar?";
                button1.Text = "Yeşil";
                button2.Text = "Mor";
                button3.Text = "Kırmızı";
                button4.Text = "Gri";

                label8.Text = "Yeşil";


            }

            if (soruno == 4)
            {
                richTextBox1.Text = "Playstation 4 hangi ylda çıkmıştır?";
                button1.Text = "2010";
                button2.Text = "2017";
                button3.Text = "2013";
                button4.Text = "2000";

                label8.Text = "2013";


            }

            if (soruno == 5)
            {
                richTextBox1.Text = "Unharted serisinin yapımcısı kimdir?";
                button1.Text = "EA Games";
                button2.Text = "Ubisoft";
                button3.Text = "Naughty Dog";
                button4.Text = "Activision";

                label8.Text = "Naughty Dog";
                button5.Enabled = false;


            }
            if(soruno==6)
            {
                MessageBox.Show("Doğru= " + doğru + "\n" + "Yanlış= " + yanlış);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label7.Text = button1.Text;
            if (label7.Text==label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label7.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label7.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            label7.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                doğru++;
                label5.Text = doğru.ToString();
            }
            else
            {
                yanlış++;
                label6.Text = yanlış.ToString();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
