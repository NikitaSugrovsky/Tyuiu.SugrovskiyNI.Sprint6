using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task4.V18.Lib
{
    public class DataService : ISprint6Task4V18
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                if (denominator != 0)
                {
                    y = Math.Round((2 * x - 3) / denominator + 5, 2);
                }
                else
                {
                    // Если знаменатель равен нулю, установить значение 0
                    y = 0;
                }

                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
