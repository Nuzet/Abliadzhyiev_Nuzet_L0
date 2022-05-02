using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 11))
            {
                case 0: button2.BackColor = Color.Red; break;
                case 1: button2.BackColor = Color.Green; break;
                case 2: button2.BackColor = Color.White; break;
                case 3: button2.BackColor = Color.Yellow; break;
                case 4: button2.BackColor = Color.Gray; break;
                case 5: button2.BackColor = Color.Blue; break;
                case 6: button2.BackColor = Color.Cyan; break;
                case 7: button2.BackColor = Color.DarkBlue; break;
                case 8: button2.BackColor = Color.DarkCyan; break;
                case 9: button2.BackColor = Color.DarkGray; break;
                case 10: button2.BackColor = Color.DarkRed; break;
                case 11: button2.BackColor = Color.DarkGreen; break;
            }

            double num;
            bool isNum = double.TryParse(textBox1.Text, out num);
            bool isNum1 = double.TryParse(textBox2.Text, out num);
            bool isNum2 = double.TryParse(textBox5.Text, out num);
            bool isNum3 = double.TryParse(textBox3.Text, out num);
            if (isNum == false || isNum1 == false || String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text)||isNum2==false|| String.IsNullOrEmpty(textBox5.Text)||isNum3==false||String.IsNullOrEmpty(textBox3.Text))
            {
                textBox4.Text = Convert.ToString("Помилка! Введить коректні дані");
            }
            else
            {

                if (button2.BackColor == Color.Yellow)
                {
                    double y;

                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double x = Convert.ToDouble(textBox3.Text);
                    double c = Convert.ToDouble(textBox5.Text);

                    if (c == 0)
                    {
                        textBox4.Text = Convert.ToString("Помилка!");
                    }
                    else if (a == 3)
                    {
                        textBox4.Text = Convert.ToString("Помилка!");
                    }
                    else
                    {
                        y = ((Math.Sin(2 * a) / (a - 3)) + (Math.Atan(b) / c));
                        textBox4.Text = Convert.ToString(y);
                    }

                }
               else if(button2.BackColor == Color.White)
                {
                    
                    
                        double a = Convert.ToDouble(textBox1.Text);
                        double x = Convert.ToDouble(textBox3.Text);
                        double y;
                        if (Math.Sin(a) == 0)
                        {
                            textBox4.Text = Convert.ToString("Помилка!");
                        }
                        else if ((Math.Pow(x, 3) - 8) < 0)
                        {
                            textBox4.Text = Convert.ToString("Помилка!");
                        }
                        else
                        {
                            y = ((1 / Math.Sin(a)) + (Math.Log(Math.Pow(x, 3) + 8)));
                            textBox4.Text = Convert.ToString(y);

                        }
                    
                }
                else textBox4.Text = Convert.ToString("");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            switch (rand.Next(0, 11))
            {
                case 0: button1.BackColor = Color.Red; break;
                case 1: button1.BackColor = Color.Green; break;
                case 2: button1.BackColor = Color.White; break;
                case 3: button1.BackColor = Color.Yellow; break;
                case 4: button1.BackColor = Color.Gray; break;
                case 5: button1.BackColor = Color.Blue; break;
                case 6: button1.BackColor = Color.Cyan; break;
                case 7: button1.BackColor = Color.DarkBlue; break;
                case 8: button1.BackColor = Color.DarkCyan; break;
                case 9: button1.BackColor = Color.DarkGray; break;
                case 10: button1.BackColor = Color.DarkRed; break;
                case 11: button1.BackColor = Color.DarkGreen; break;
            }
            double num;
            bool isNum = double.TryParse(textBox1.Text, out num);
            bool isNum1 = double.TryParse(textBox3.Text, out num);
            bool isNum2 = double.TryParse(textBox2.Text, out num);
            bool isNum3 = double.TryParse(textBox5.Text, out num);
            if (isNum==false||isNum1==false||String.IsNullOrEmpty(textBox1.Text)|| String.IsNullOrEmpty(textBox3.Text)||isNum2==false|| String.IsNullOrEmpty(textBox2.Text)||isNum3==false|| String.IsNullOrEmpty(textBox3.Text))
            {
                textBox4.Text = "Помилка! Введить коректні дані";
            }

            else { 

                    if (button1.BackColor==Color.White)
                    {
                        double a = Convert.ToDouble(textBox1.Text);
                        double x = Convert.ToDouble(textBox3.Text);
                        double y;
                    if (Math.Sin(a) == 0)
                        {
                            textBox4.Text = Convert.ToString("Помилка!");
                        }
                        else if ((Math.Pow(x, 3) - 8) < 0)
                        {
                            textBox4.Text = Convert.ToString("Помилка!");
                        }
                        else
                        {
                            y = ((1 / Math.Sin(a))+ (Math.Log(Math.Pow(x,3)+8)));
                            textBox4.Text = Convert.ToString(y);
                        
                        }
                    }
                    else if(button1.BackColor == Color.Yellow)
                    {
                    double a = Convert.ToDouble(textBox1.Text);
                    double b = Convert.ToDouble(textBox2.Text);
                    double x = Convert.ToDouble(textBox3.Text);
                    double c = Convert.ToDouble(textBox5.Text);
                    double y;

                    if (c == 0)
                    {
                        textBox4.Text = Convert.ToString("Помилка!");
                    }
                    else if (a == 3)
                    {
                        textBox4.Text = Convert.ToString("Помилка!");
                    }
                    else
                    {
                        y = ((Math.Sin(2 * a) / (a - 3)) + (Math.Atan(b) / c));
                        textBox4.Text = Convert.ToString(y);
                    }
                    }
                    else textBox4.Text = Convert.ToString("");
                    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text=("Точно закрити?");
            
            switch(comboBox1.Text)
            {
                case "Так":
                    MessageBox.Show("Програма завершилась успішно!");
                    Close();
                    break;
                case "Ні":
                    Console.WriteLine("");
                    break;

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
