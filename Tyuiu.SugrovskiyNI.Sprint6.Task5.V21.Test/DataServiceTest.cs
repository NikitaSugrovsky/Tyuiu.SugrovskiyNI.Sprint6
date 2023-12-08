using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint6.Task5.V21.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask5V21.txt";

            double[] res = ds.LoadFromDataFile(path);

            double[] wait = { 2.5, -2.6, 5.7, -6.8, 9.9 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
