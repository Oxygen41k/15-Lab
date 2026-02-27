using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _15_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;

            if (double.TryParse(textBox1.Text, out x) &&
                double.TryParse(textBox2.Text, out y))
            {
                double result = x - Math.Pow(10, Math.Sin(x)) + Math.Cos(x - y);
                textBox3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Було уведене не правильне значення одного з чисел!!",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b;

            if (double.TryParse(textBoxA.Text, out a) &&
                double.TryParse(textBoxB.Text, out b))
            {
                double c = Math.Sqrt(a * a + b * b);

                double P = a + b + c;

                double S = (a * b) / 2;

                textBoxP.Text = P.ToString();
                textBoxS.Text = S.ToString();
            }
            else
            {
                MessageBox.Show("Було уведене не правильне значення одного з чисел!!",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N;

            if (int.TryParse(textBoxN.Text, out N) && N >= 100 && N <= 999)
            {
                
                int a = N / 100;        
                int b = (N / 10) % 10;  
                int c = N % 10;         

                
                bool result = (a + b == c) ||
                              (a + c == b) ||
                              (b + c == a);

                textBoxR.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Було введено неправильне тризначне натуральне число!",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b, c;

            if (double.TryParse(textBox5.Text, out a) &&
                double.TryParse(textBox6.Text, out b) &&
                double.TryParse(textBox7.Text, out c))
            {
                double max = Math.Max(a, Math.Max(b, c));
                double min = Math.Min(a, Math.Min(b, c));

                double sum = max + min;

                textBoxY.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Введіть коректні числові значення!",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int M, N;

            if (int.TryParse(textBoxM.Text, out M) &&
                int.TryParse(textBoxNu.Text, out N) &&
                M > 0 && M < 5 &&
                N >= 1 && N <= 30)
            {
                int count = 0;

                int start = (int)Math.Pow(10, M - 1);
                int end = (int)Math.Pow(10, M) - 1;

                for (int i = start; i <= end; i++)
                {
                    int number = i;
                    int position = 1;
                    int sum = 0;

                    while (number > 0)
                    {
                        int digit = number % 10;

                        if (position % 2 == 1) // непарний розряд
                        {
                            sum += digit;
                        }

                        number /= 10;
                        position++;
                    }

                    if (sum == N)
                    {
                        count++;
                    }
                }

                textBox10.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("Введіть коректні M (1-4) та N (1-30)",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double c, d;

            if (double.TryParse(textBoxC.Text, out c) &&
                double.TryParse(textBoxD.Text, out d))
            {
                string[] parts = textBoxNum.Text.Split(' ');

                string result = "";

                foreach (string item in parts)
                {
                    double number;

                    if (double.TryParse(item, out number))
                    {
                        if (number >= c && number <= d)
                        {
                            result += number + " ";
                        }
                    }
                    else
                    {
                        MessageBox.Show("У послідовності є неправильні значення!",
                                        "Помилка",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }
                }

                textBox8.Text = result;
            }
            else
            {
                MessageBox.Show("Введіть правильні значення c та d!",
                                "Помилка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string text = textBoxI.Text;

            string[] words = text.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                char[] letters = word.ToCharArray();
                Array.Reverse(letters);

                result += new string(letters) + " ";
            }

            textBox11.Text = result.Trim();
        }
    }
}
