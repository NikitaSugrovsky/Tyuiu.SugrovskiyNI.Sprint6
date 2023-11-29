﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
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
                if (x - 0.4 == 0)
                {
                    y = 0;
                }

                else
                {
                    y = (Math.Cos(x) / (x - 0.4)) + (Math.Sin(x) * 8 * x) + 2;
                }

                y = Math.Round(y, 2);

                valueArray[count] = y;
                count++;
            }

            return valueArray;
        }
    }
}
