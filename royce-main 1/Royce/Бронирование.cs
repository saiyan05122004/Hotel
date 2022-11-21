using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Royce
{
    public partial class Бронирование : Form
    {
        int a = 0;//общая сумма
        int n;
        int vip = 5000;
        int standart = 2500;
        

        public Бронирование()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (comboBox1.SelectedIndex == 1)
            {
                a = vip;
                label10.Text = a.ToString();
            }
            else
            {
                a = standart;
                label10.Text = a.ToString();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numericUpDown1.Value;
            
                a = a * n;
                label10.Text = a.ToString();
            if (n>1)
            {
                if (comboBox1.SelectedIndex == 1)
                {
                    a = vip;
                    a = a * n;
                    label10.Text = a.ToString();
                }
                else
                {
                    a = standart;
                    a = a * n;
                    label10.Text = a.ToString();
                }
            }
            



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                a = a + 2000;
                label10.Text = a.ToString();
                
            }
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                a = a + 4000;
                label10.Text = a.ToString();
               
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = a.ToString();
            
        }

        private void Бронирование_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            a = 0;
            n = 0;
            label10.Text = a.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Успешно! Вы забронировали номер.");
        }
    }
}
