using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Диплом
{
    public partial class Form2 : Form
    {
        static public int c = C_means.c;//2<=c<=M-1 - число кластеров
        int cmax;
        static public double ee = C_means.ee;//точность останова
        static public double m = C_means.m;//эмпирическое число >=1, обычно равное 2
        static public int max_iterations = C_means.max_iterations;
        public Form2()
        {
            InitializeComponent();
            Form1 main = this.Owner as Form1;
            cmax = ConvertExcel.FromExcel(Form1.filePath, Form1.maxcolumns).Rows.Count - 1;
            label4.Text = "кількість кластерів 2<=c<="+ Convert.ToString(cmax);
            textBox1.Text = C_means.c.ToString();
            textBox2.Text = C_means.m.ToString();
            textBox3.Text = Convert.ToString(C_means.ee);
            textBox4.Text = C_means.max_iterations.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(44) && textBox2.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8) && e.KeyChar != Convert.ToChar(44))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(44) && textBox2.Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) >= 2 && Convert.ToDouble(textBox2.Text) >= 1 && Convert.ToInt32(textBox1.Text) <= cmax)
            {
                c = Convert.ToInt32(textBox1.Text);
                m = Convert.ToDouble(textBox2.Text);
                ee = Convert.ToDouble(textBox3.Text);
                max_iterations = Convert.ToInt32(textBox4.Text);
                C_means.c = c;
                C_means.m = m;
                C_means.ee = ee;
                C_means.max_iterations = max_iterations;
                this.Hide();
            }
            else MessageBox.Show("Невірно введені дані!");
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
