using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Диплом
{
    public partial class Form1 : Form
    {
        static public string filePath;
        static public int maxcolumns = 7;//задаём количество интересующих нас колонок в таблице Excel
        double[,] F;
        double[,] V;
        double[,] T;
        bool rules_ready = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void MethodButton_Click(object sender, EventArgs e)
        {
            //проводим проверку, что путь к файлу введён правильно
            if(!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Неправильно введений шлях до файлу!");
                return;
            }
            ///
            /// получаем из EXCEL матрицу T в виде DataTable
            ///

            DataTable ExcelTable = new DataTable();
            ExcelTable = ConvertExcel.FromExcel(filePath, maxcolumns);//2ой параметр - число колонок. В нашем случае - 7
            //конвертируем таблицу из формата DataTable в string
            int T_width = ExcelTable.Columns.Count;
            int T_height = ExcelTable.Rows.Count;
            string[,] T_string = Fuzzification.ConvertFromDataTableToTable(ExcelTable);
            //Проводим фаззификацию - замену нечисловых лингв.переменных на числовые
            T = Fuzzification.FuzzyTable(T_string);
            C_means.C_meansMethod(T, out F, out V);
            FindYButton.Enabled = true;
            rules_ready = true;
        }

        private void FindYButton_Click(object sender, EventArgs e)
        {
            double[] X = new double[6];

            if (!(Double.TryParse(textBox1.Text, out X[0]) && Double.TryParse(textBox2.Text, out X[1]) &&
                    Double.TryParse(textBox3.Text, out X[2]) && Double.TryParse(textBox4.Text, out X[3]) &&
                    Double.TryParse(textBox5.Text, out X[4]) && Double.TryParse(textBox6.Text, out X[5])))
            { MessageBox.Show("Введіть дані коректно"); return; }

            int j = Rules.finding_rule(X, T, F, V);
            double y = V[j, 6];
            textBox7.Text = Defuzzification.FromDoubleToStr(y);


            if (!String.IsNullOrEmpty(textBox7.Text) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))
                ExcelAddButton.Enabled = true;
            else ExcelAddButton.Enabled = false;
        }

        private void ExcelFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Виберіть файл";
            openFileDialog1.InitialDirectory = "C:\\Users\\Igor\\Desktop\\Диплом";
            openFileDialog1.Filter = "Excel-файли(*.xlsx)|*.xlsx";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog1.FileName;
                filePathTextBox.Text = filePath;
                if (!String.IsNullOrEmpty(filePath))
                    MethodButton.Enabled = true;
                else MethodButton.Enabled = false;
            }
        }


        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {
            FindYButton.Enabled = false;
            rules_ready = false;
            filePath = filePathTextBox.Text;
            if (!String.IsNullOrEmpty(filePath))
                MethodButton.Enabled = true;
            else MethodButton.Enabled = false;

            if (!String.IsNullOrEmpty(filePath))
            {
                AlterParamsButton.Enabled = true;
                AlterParamsButton.Visible = true;
            }
            if (String.IsNullOrEmpty(filePath))
            {
                AlterParamsButton.Enabled = false;
                AlterParamsButton.Visible = false;
            }
            //Смена цвета текста в зависимости от правильности ввода пути
            if (System.IO.File.Exists(filePath))
                filePathTextBox.ForeColor = Color.Black;
            else filePathTextBox.ForeColor = Color.Red;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Формування комплексної експертної оцінки стану ліній електропередач методами нечіткої логіки.\n" +
                "Позначення:\n   " + 
                "КДО – коефіцієнт дефектності опор;\n   " + 
                "КДФ – коефіцієнт дефектності фундаментів;\n   " + 
                "КДП – коефіцієнт дефектності проводів;\n   " +
                "КДТ – коефіцієнт дефектності тросів;\n   " +
            "КДІ – коефіцієнт дефектності ізоляторів;\n   " +
            "КДА – коефіцієнт дефектності арматури.\n   " + 
            "КДПЛ - коефіцієнт дефектності високовольтних повітряних ліній\n\n" + 
            "Для роботи програми потрібно обрати шлях до .xlsx Excel-файлу, за бажанням змінити параметри алгоритму,\n" + 
            "побудувати правила нечіткої бази та ввести необхідні 6 значень в текстові поля.\nВ нижньому полі Ви отримаєте імовірну комплексну оцінку КДПЛ\n\n" +
            "                                                                Розроблено Ігорем Богунковим,\n" + 
            "                                                                                             ТЕФ ТР-32 2017р.\n\n" +
            "                                                         На основі статті Ходашинського І.О.:\n" +
            "                    'Идентификация нечетких систем: методы и алгоритмы'\n",
            "Довідка програми", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void ExcelAddButton_Click(object sender, EventArgs e)
        {
            ConvertExcel.AddToExcel(filePath, textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);
            MessageBox.Show("Отриманий рядок доданий до excel-файлу");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox7.Text) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text))
                ExcelAddButton.Enabled = true;
            else ExcelAddButton.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text) 
                && rules_ready==true)
                FindYButton.Enabled = true;
            else FindYButton.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                && rules_ready == true)
                FindYButton.Enabled = true;
            else FindYButton.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                && rules_ready == true)
                FindYButton.Enabled = true;
            else FindYButton.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                && rules_ready == true)
                FindYButton.Enabled = true;
            else FindYButton.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                 && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                 && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                 && rules_ready == true)
                FindYButton.Enabled = true;
            else FindYButton.Enabled = false;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(filePath) && !String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(textBox3.Text) && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox5.Text) && !String.IsNullOrEmpty(textBox6.Text)
                && rules_ready == true)
                FindYButton.Enabled = true;
            else FindYButton.Enabled = false;
        }

        private void AlterParamsButton_Click(object sender, EventArgs e)
        {
            //проводим проверку, что путь к файлу введён правильно
            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Неправильно введений шлях до файлу!");
                return;
            }
            Form f2 = new Form2();
            f2.Owner = this;
            f2.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length == 3 && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox1.Text.Length == 2 && textBox1.Text != "10" && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox2.Text.Length == 3 && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox2.Text.Length == 2 && textBox2.Text != "10" && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox3.Text.Length == 3 && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox3.Text.Length == 2 && textBox3.Text != "10" && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox4.Text.Length == 3 && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox4.Text.Length == 2 && textBox4.Text != "10" && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox5.Text.Length == 3 && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox5.Text.Length == 2 && textBox5.Text != "10" && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox6.Text.Length == 3 && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
            if (textBox6.Text.Length == 2 && textBox6.Text != "10" && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }


    }
}