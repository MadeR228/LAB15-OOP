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



namespace Lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0,0";
            textBox2.Text = "0,0";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0.0, y = 0.0;

            if (Double.TryParse(textBox1.Text, out double result)) { x = Convert.ToDouble(textBox1.Text); }
            else { textBox3.Text = "Введіть число у змінну x"; }
            if (Double.TryParse(textBox2.Text, out double result1)) { y = Convert.ToDouble(textBox2.Text); }
            else { textBox3.Text = "Введіть число у змінну y"; }

            if (Double.TryParse(textBox1.Text, out double result2) && Double.TryParse(textBox2.Text, out double result3))
            { textBox3.Text = Convert.ToString((x + y) / (y + 1) - (x * y - 12) / (34 + x)); }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox8.Text, out int n) && n > 0)
            {
                label10.Text = $"Дільники числа {n}: ";
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        label10.Text += i + " ";
                }
            }
            else { }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                double radians = Convert.ToDouble(textBox4.Text);
                double degrees = radians * (180 / Math.PI);
                double minutes = (degrees - Math.Floor(degrees)) * 60;
                double seconds = (minutes - Math.Floor(minutes)) * 60;
                textBox5.Text = $"Градуси: {Math.Floor(degrees)}";
                textBox6.Text = $"Хвилини: {Math.Floor(minutes)}";
                textBox7.Text = $"Секунди: {Math.Floor(seconds)}";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] array = textBox9.Text.Split(' ').Select(int.Parse).ToArray();
            int min = array.Min();
            int max = array.Max();
            label12.Text = $"Мінімальний елемент: {min}, Максимальний елемент: {max}";

            // Виведення цілих чисел з інтервалу (t, M), які не входять у масив
            string output = "";
            for (int i = min + 1; i < max; i++)
            {
                if (!array.Contains(i))
                    output += i + " ";
            }
            if (output != "")
                label13.Text = $"Відсутні числа: {output}";
            else
                label13.Text = "Немає відсутніх чисел";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string inputString = textBox10.Text;
            int asterisks = inputString.Count(c => c == '*');
            int semicolons = inputString.Count(c => c == ';');
            int colons = inputString.Count(c => c == ':');
            label15.Text = $"Кількість символів '*': {asterisks}, ';': {semicolons}, ':': {colons}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox11.Text, out int number) && number >= 100 && number <= 999)
            {
                int digit1 = number / 100;
                int digit2 = (number / 10) % 10;
                int digit3 = number % 10;

                int sum = digit1 + digit2 + digit3;

                int sumCubed = sum * sum * sum;

                bool result = (number * number == sumCubed);

                label16.Text = $"Висловлення є дійсним? : {result}";
            }
            else
            {
                MessageBox.Show("Будь ласка, введіть тризначне число.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double[] results = { 50.2, 49.8, 51.0 }; // Приклад результатів змагань
            double bestResult = results.Max();
            MessageBox.Show($"Кращий результат: {bestResult}. Переможець запливу!", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


