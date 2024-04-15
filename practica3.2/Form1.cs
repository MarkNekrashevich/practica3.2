using System;
using System.Linq;
using System.Windows.Forms;

namespace practica3._2
{
    public partial class Form1 : Form
    {
        int[] array;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int size = int.Parse(textBox1.Text);
                if (size < 1 || size > 10)
                {
                    MessageBox.Show("������: ������ ������� ������ ���� �� 1 �� 10.");
                    return;
                }
                array = new int[size];
                Random rnd = new Random();
                for (int i = 0; i < size; i++)
                {
                    array[i] = rnd.Next(100);
                }
                textBox2.Text = string.Join(" ", array.Select(num => num.ToString()));
            }
            catch (FormatException)
            {
                MessageBox.Show("������: ������� ����� ����� � ���� ��� ����� ������� �������.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (array == null || array.Length == 0)
            {
                MessageBox.Show("������: ������� ������������ ������.");
                return;
            }

            var result = Enumerable.Range(1, array.Length - 1)
                                   .Where(i => array[i] > array[i - 1])
                                   .Reverse()
                                   .ToArray();
            textBox3.Text = string.Join(" ", result);
            textBox4.Text = result.Length.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
