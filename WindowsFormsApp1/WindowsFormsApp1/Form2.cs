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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 b = new Form1();
            b.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Заполните поле!", "Ошибка");

            else
            {
                if (textBox2.Text == "")
                    MessageBox.Show("Заполните поле!", "Ошибка");
                else
                    if (textBox3.Text == "")
                    MessageBox.Show("Заполните поле!", "Ошибка");
                else
                    if (textBox4.Text == "")
                    MessageBox.Show("Заполните поле!", "Ошибка");
                else
                    if (textBox5.Text == "")
                    MessageBox.Show("Заполните поле!", "Ошибка");
                else
                    if (textBox6.Text == "")
                    MessageBox.Show("Заполните поле!", "Ошибка");

                else
                {
                    Form1 b = new Form1();
                    b.Show();
                    this.Hide();
                }
            }
        }
    }
}
