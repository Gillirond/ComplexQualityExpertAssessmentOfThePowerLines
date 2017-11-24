using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Диплом
{
    class C_means
    {
        static public int c = 12;//2<=c<=M-1 - число кластеров
        static public double ee = 0.0000001;//точность останова
        static public double m = 2;//эмпирическое число >=1, обычно равное 2
        static public int max_iterations = 10000;//максимальное количество итераций цикла

        static public void C_meansMethod(double[,] T, out double[,] F, out double[,] V)
        {
            int M = T.GetLength(0);//число наблюдений
            int n = T.GetLength(1)-1;//число входных переменных
            
            //создадим матрицу нечеткого разбиения F
            bool check = false;
            int iteration_counter = 0;
            double[,] F_old = new double[M,c];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < c; j++)
                    F_old[i, j] = 0;
            F = new double[M, c];
            do
            {
                Random rnd = new Random();
                for (int i = 0; i < M; i++)
                {
                    //создаём строку рандомных значений
                    double sum = 0;
                    for (int j = 0; j < c; j++)
                    {
                        F[i, j] = rnd.Next(0, M);
                        sum += F[i, j];
                    }
                    //делаем так, чтобы сумма всех значений в строке была равна 1
                    for (int j = 0; j < c; j++)
                        F[i, j] /= sum;
                    //проверяем на равенство единице и в случае неравенства изменяем последний элемент
                    sum = 0;
                    for (int j = 0; j < c - 1; j++)
                        sum += F[i, j];
                    if (sum + F[i, c-1] != 1)
                        F[i, c-1] = 1 - sum;
                }
                //проверим, что сумма элементов по вертикали больше нуля и меньше M
                for (int j = 0; j < c; j++)
                {
                    double sum = 0;
                    for (int i = 0; i < M; i++)
                    {
                        sum += F[i, j];
                    }
                    if (sum > 0 && sum < M)
                        check = true;
                }

            } while (!check);


            bool check2 = true;
            V = new double[c, n + 1];
            do
            {
                iteration_counter++;
                //найдём вектора центров кластеров V
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < n+1; j++)
                    {
                        V[i, j] = 0;
                        for (int q = 0; q < M; q++)
                        {
                            V[i, j] += Math.Pow(F[q, i], m) * T[q, j];
                        }
                        double div = 0;
                        for (int q = 0; q < M; q++)
                        {
                            div += Math.Pow(F[q, i], m);
                        }
                        V[i, j] /= div;
                    }

                }
                //Мы нашли вектор центров кластеров V
                //найдём матрицу Dki расстояний между k-м наблюдением из матрицы T и i-м центром кластера
                double[,] D = new double[M, c];
                for (int i = 0; i < M; i++)
                    for (int j = 0; j < c; j++)
                    {
                        D[i, j] = 0;
                        for (int q = 0; q < n+1; q++)
                            D[i, j] += Math.Pow(T[i, q] - V[j, q], 2);
                        D[i, j] = Math.Sqrt(D[i, j]);
                    }

                //Рассчитаем очередное приближение матрицы F
                for (int i = 0; i < M; i++)
                    for (int j = 0; j < c; j++)
                    {
                        if (D[i, j] > 0)
                        {
                            double sum = 0;
                            for (int q = 0; q < c; q++)
                                sum += 1 / (D[i, q] * D[i, q]);
                            F[i, j] = Math.Pow(D[i, j] * D[i, j] * sum, (-1 / (m - 1)));
                        }
                        else
                        {
                            for (int q = 0; q < c; q++)
                                if (q == j)
                                    F[i, j] = 0;
                                else F[i, j] = 1;
                        }

                    }
                //Проверим условие завершения цикла
                if(iteration_counter>1)
                {
                    double check2_value = 0;
                    for (int i = 0; i < M; i++)
                        for (int j = 0; j < c; j++)
                            check2_value += Math.Pow(F[i, j] - F_old[i, j], 2);

                    if (check2_value < ee)
                        check2 = false;
                }
                //Заполним матрицу нечеткого разбиения, полученной на предыдущей итерации алгоритма
                for (int i = 0; i < M; i++)
                    for (int j = 0; j < c; j++)
                        F_old[i, j] = F[i, j];


            } while (check2 && iteration_counter<=max_iterations);

            
            return;
        }
        
        //Гауссова функция принадлежности
        static public double gauss_func(int j, int i, double[] X, double[,] T, double [,] F, double [,] V)
        {
            int M = T.GetLength(0);//число наблюдений
            double a = V[j, i];
            double sigma2 = 0;
            for (int q = 0; q < M; q++)
            {
                sigma2 += Math.Pow(F[q, i], m) * Math.Pow((T[q, i] - V[j, i]), 2);
            }
            double div = 0;
            for (int q = 0; q < M; q++)
            {
                div += Math.Pow(F[q, i], m);
            }
            sigma2 /= div;

            return Math.Exp(-(Math.Pow(X[i] - a, 2) / (2 * sigma2)));
        }
    }
}
