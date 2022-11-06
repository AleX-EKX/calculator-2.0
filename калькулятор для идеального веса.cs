using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace начало2
{
    public partial class калькулятор_для_идеального_веса : Form
    {
        public калькулятор_для_идеального_веса()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните данные");
                return;
            }
            string a = (Math.Round(double.Parse(textBox1.Text) * 10000, 2) / (Math.Round(double.Parse(textBox2.Text), 2) * (Math.Round(double.Parse(textBox2.Text), 2)))).ToString("f2");
            string b = (Math.Round(double.Parse(textBox1.Text), 0) / (Math.Round(double.Parse(textBox2.Text), 2) * (Math.Round(double.Parse(textBox2.Text), 2)))).ToString("f2");
            if (Convert.ToDouble(textBox2.Text) %1 == 0)
            {
                label4.Text = "Ваше значение - " + a;
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
                label4.Text = "Ваше значение - " + b;
            }

            if (Convert.ToDouble(a) > 24 || Convert.ToDouble(b) > 24)
            {
                zhir.Visible = true;
                muskul.Visible = false;
                xudoy.Visible = false;
            }
            else if(Convert.ToDouble(a) > 18 && Convert.ToDouble(a) < 24 || Convert.ToDouble(b) > 18 && Convert.ToDouble(b) < 24)
            {
 
                muskul.Visible = true;
                zhir.Visible = false;
                xudoy.Visible = false;
            }
            else
            {
                muskul.Visible = false;
                zhir.Visible = false;
                xudoy.Visible = true;
            }

        }
        // rabo4iy label4.Text = " " + (Math.Round(double.Parse(textBox1.Text),2) / (Math.Round(double.Parse(textBox2.Text),2)* (Math.Round(double.Parse(textBox2.Text),2)))).ToString("f2"); // * float.Parse(textBox2.Text));//* float.Parse(textBox2.Text),2).ToString();
        //label4.Text = " " + Math.Round(int.Parse(textBox1.Text) / Math.Pow(float.Parse(textBox2.Text), float.Parse(textBox2.Text)));
        //Math.Pow(x, k)
        private void button2_Click(object sender, EventArgs e)
        {
            //Рабочий для индекса массы 18-25
            /*if (comboBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните данные");
                return;
            }
            if (Convert.ToDouble(textBox3.Text) % 1 == 0)
            {
                label5.Text = "   Идеальный вес для \nиндекса - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n             Вес - " + (int.Parse(comboBox1.Text) * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text) / 10000));
                comboBox1.Text = "";
                textBox3.Text = "";
            }
            else
            {
                label5.Text = "Идеальный вес для индекса - " + comboBox1.Text +" и роста - " + textBox3.Text + " Вес - " +(int.Parse(comboBox1.Text) * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)));
                comboBox1.Text = "";
                textBox3.Text = "";
            }*/

            if (comboBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните данные");
                return;
            }

            if (Convert.ToDouble(textBox3.Text) % 1 == 0)
            {
                
                if (comboBox1.Text == "Худощавый")
                {
                    float a = (18 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text) / 10000));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n             Вес - "+a;
                }
                if (comboBox1.Text == "Стройный")
                {
                    float a = (20 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text) / 10000));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n             Вес - "+a;
                }
                if (comboBox1.Text == "Крепкий")
                {
                    float a = (1/2 + (21) * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text) / 10000));
                    label5.Text = "Идеальный вес для \nкатегории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n             Вес - "+a;
                }
                if (comboBox1.Text == "Здоровый")
                {
                    float a = (23 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text) / 10000));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n             Вес - "+a;
                }

                comboBox1.Text = "";
                textBox3.Text = "";
            }
            else
            {
                
                if (comboBox1.Text == "Худощавый")
                {
                    float b = (18 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n                Вес - " + b;
                }
                if (comboBox1.Text == "Стройный")
                {
                    float b = (20 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n                Вес - " + b;
                }
                if (comboBox1.Text == "Крепкий")
                {
                    float b = (1/2+21 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n                Вес - " + b;
                }
                if (comboBox1.Text == "Здоровый")
                {
                    float b = (23 * (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)));
                    label5.Text = "Идеальный вес для категории\n - " + comboBox1.Text + " и роста - " + textBox3.Text + "м\n                Вес - " + b;
                }
                
                comboBox1.Text = "";
                textBox3.Text = "";
            }




            }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Lime;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Transparent;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Symbol = e.KeyChar.ToString();

            if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            {
                e.Handled = true;
            }
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

       

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.qweу;
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.qwe;
            
        }
    }
}
