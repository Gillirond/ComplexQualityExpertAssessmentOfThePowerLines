using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Диплом
{
    class Defuzzification
    {
        //Двумерный массив соответствия словесных лингвистических переменных диапазону
        //Минимальное значение диапазона-максимальное-словесное значение
        static private string[,] OutLingvMas =
        {
            { "0","1","30","60"},
            { "1","30","60","100"},
            { "хороше","задовільне","незадовільне","непридатне"}
        };

        static public string FromDoubleToStr(double y)
        {
            string text=null;
            //Проверка выходного параметра на принадлежность диапазону
            if (y < Convert.ToDouble(OutLingvMas[0, 0]) || y > Convert.ToDouble(OutLingvMas[1, OutLingvMas.GetLength(1) - 1]))
                return "Y>100|Y<0";
            //
            for(int k = 0; k < OutLingvMas.GetLength(1); k++)
            {
                if (Convert.ToDouble(OutLingvMas[0, k]) == Convert.ToDouble(OutLingvMas[1, k]))
                {
                    if (y == Convert.ToDouble(OutLingvMas[0, k]))
                        text = OutLingvMas[2, k];
                }
                else if(y >= Convert.ToDouble(OutLingvMas[0, k]) && y <= Convert.ToDouble(OutLingvMas[1, k]))
                    text = OutLingvMas[2, k];
            }
            return text;
        }
    }
}
