using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Диплом
{
    class Fuzzification
    {
        //Двумерный массив соответствия словесных лингвистических переменных диапазону
        //"от предыдущего диапазона<диапазон<=верхняя грань, заданная в массиве"
        static private string[,] OutLingvMas = 
        {
            { "0","15","45","70"},
            { "хороше","задовільне","незадовільне","непридатне"}
        };

        //Метод конвертирования таблицы из формата DataTable в string[,]
        static public string[,]  ConvertFromDataTableToTable(DataTable DT)
        {
            int T_width = DT.Columns.Count;
            int T_height = DT.Rows.Count;
            string[,] T_string = new string[T_height, T_width];
            for (int i = 0; i < T_height; i++)
            {
                DataRow Row = DT.Rows[i];
                for (int j = 0; j < T_width; j++)
                    T_string[i, j] = Row[j].ToString();
            }
            return T_string;
        }

        //Метод конвертирования таблицы из формата String[,] в double[,], замена словесных лингвистических переменных нечеткими числовыми
        static public double[,] FuzzyTable(string[,] T_string)
        {
            int T_width = T_string.GetLength(1);
            int T_height = T_string.GetLength(0);
            //Заменяем словесные лингв.переменные числовыми
            for(int i=0;i<T_height;i++)
                for(int j=0;j<T_width;j++)
                {
                    for (int k = 0; k < OutLingvMas.GetLength(1); k++)
                        if (T_string[i, j] == OutLingvMas[1, k])
                            T_string[i, j] = OutLingvMas[0, k];
                }
            
            double[,] T = new double[T_height, T_width];
            for (int i = 0; i < T_height; i++)
                for (int j = 0; j < T_width; j++)
                    T[i, j] = Convert.ToDouble(T_string[i,j]);

            return T;
        }
    }
}
