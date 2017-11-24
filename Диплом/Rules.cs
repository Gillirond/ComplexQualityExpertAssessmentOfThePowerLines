using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Диплом
{
    class Rules
    {
        static public int finding_rule(double[] X, double[,] T, double[,] F, double[,] V)
        {
            int rule_numb = 0;
            double min_difference = 0;
            for (int i = 0; i < 6; i++)
                min_difference += Math.Pow(1 - C_means.gauss_func(0, i, X, T, F, V), 2);
            min_difference = Math.Sqrt(min_difference);

            for (int j=0;j<C_means.c;j++)
            {
                double difference = 0;
                for (int i = 0; i < 6; i++)
                    difference += Math.Pow(1 - C_means.gauss_func(j, i, X, T, F, V), 2);
                difference = Math.Sqrt(difference);
                if (difference < min_difference)
                {
                    rule_numb = j;
                    min_difference = difference;
                }
            }
            return rule_numb;
        }
    }
}
