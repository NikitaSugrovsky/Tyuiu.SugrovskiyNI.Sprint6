using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint6.Task4.V18.Lib;
using System.IO;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            string path = @"C:\DataSprint5\OutPutFileTask4.txt";
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 7.76;
            valueWaitArray[1] = 7.36;
            valueWaitArray[2] = 7.26;
            valueWaitArray[3] = 7.9;
            valueWaitArray[4] = 15.88;
            valueWaitArray[5] = 2;
            valueWaitArray[6] = 4.35;
            valueWaitArray[7] = 5.63;
            valueWaitArray[8] = 6.49;
            valueWaitArray[9] = 6.49;
            valueWaitArray[10] = 6.32;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);

            // Округляем значения функции в массиве valueWaitArray перед сравнением с массивом res
            for (int i = 0; i < valueWaitArray.Length; i++)
            {
                valueWaitArray[i] = Math.Round(valueWaitArray[i], 2);
            }        
        }
    }
}
