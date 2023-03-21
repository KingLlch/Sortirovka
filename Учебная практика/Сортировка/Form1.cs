using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сортировка
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int ValueArray;
        string Data;
        int time = 10;

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1;
            textBox4.Text = time.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = null;
            textBox3.Text = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            time = 10;
            timer1.Start();
            ValueArray = int.Parse(textBox1.Text);

            textBox3.Text = null;
            Data = textBox2.Text;
            string[] ArrayString = new string[ValueArray];
            ArrayString = Data.Split();

            float[] Array = new float[ValueArray];
            try
            {

                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = float.Parse(ArrayString[i]);

                }
            }

            catch { errorProvider1.SetError(textBox2,"Количество элементов не совпадает с количеством указанным ранее"); return; }
            for (int i = 0; i < Array.Length-1; i++)
            {
                for (int j = 0; j < Array.Length-1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        Array[j] += Array[j + 1];
                        Array[j+1] = Array[j]  - Array[j + 1];
                        Array[j] -= Array[j + 1];

                    }

                }

            }

            for (int i = 0; i < Array.Length; i++)
            {
                textBox3.Text += Array[i] + " ";
            }

            errorProvider1.SetError(textBox2, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            time = 10;
            timer1.Start();
            ValueArray = int.Parse(textBox1.Text);

            textBox3.Text = null;
            Data = textBox2.Text;
            string[] ArrayString = new string[ValueArray];
            ArrayString = Data.Split();

            float[] Array = new float[ValueArray];
            try
            {

                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = float.Parse(ArrayString[i]);

                }
            }

            catch { errorProvider1.SetError(textBox2, "Количество элементов не совпадает с количеством указанным ранее"); return; }
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        Array[j] += Array[j + 1];
                        Array[j + 1] = Array[j] - Array[j + 1];
                        Array[j] -= Array[j + 1];

                    }

                }

                for (int j = Array.Length - 1; j > 0; j--)
                {
                    if (Array[j] < Array[j - 1])
                    {
                        Array[j] += Array[j - 1];
                        Array[j - 1] = Array[j] - Array[j - 1];
                        Array[j] -= Array[j - 1];

                    }

                }

            }

            for (int i = 0; i < Array.Length; i++)
            {
                textBox3.Text += Array[i] + " ";
            }

            errorProvider1.SetError(textBox2, null);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            time = 10;
            timer1.Start();
            ValueArray = int.Parse(textBox1.Text);

            textBox3.Text = null;
            Data = textBox2.Text;
            string[] ArrayString = new string[ValueArray];
            ArrayString = Data.Split();

            float[] Array = new float[ValueArray];
            try
            {

                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = float.Parse(ArrayString[i]);

                }
            }

            catch { errorProvider1.SetError(textBox2, "Количество элементов не совпадает с количеством указанным ранее"); return; }

            for (var i = 0; i < Array.Length; i++)
            {
                var key = Array[i];
                var j = i;
                while ((j > 0) && (Array[j - 1] > key))
                {
                    Array[j-1] += Array[j];
                    Array[j] = Array[j-1] - Array[j];
                    Array[j-1] -= Array[j];
                    j--;
                }

                Array[j] = key;
            }

            for (int i = 0; i < Array.Length; i++)
            {
                textBox3.Text += Array[i] + " ";
            }

            errorProvider1.SetError(textBox2, null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            time = 10;
            timer1.Start();
            ValueArray = int.Parse(textBox1.Text);

            textBox3.Text = null;
            Data = textBox2.Text;
            string[] ArrayString = new string[ValueArray];
            ArrayString = Data.Split();

            float[] Array = new float[ValueArray];
            try
            {

                for (int i = 0; i < Array.Length; i++)
                {
                    Array[i] = float.Parse(ArrayString[i]);

                }
            }

            catch { errorProvider1.SetError(textBox2, "Количество элементов не совпадает с количеством указанным ранее"); return; }
                
            var d = Array.Length / 2;
            while (d >= 1)
            {
                for (var i = d; i < Array.Length; i++)
                {
                    var j = i;
                    while ((j >= d) && (Array[j - d] > Array[j]))
                    {
                        Array[j] += Array[j-d];
                        Array[j-d] = Array[j] - Array[j-d];
                        Array[j] -= Array[j-d];
                        j = j - d;
                    }
                }

                d = d / 2;
            }
           

            for (int i = 0; i < Array.Length; i++)
            {
                textBox3.Text += Array[i] + " ";
            }
            errorProvider1.SetError(textBox2, null);

        }


    }
}
