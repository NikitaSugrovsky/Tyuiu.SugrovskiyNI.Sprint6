using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint6.Task3.V29.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint6.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {
                                          { -2, -13, -15, -9, -17 },
                                          { 13, -20, -15, 27, 18 },
                                          { -12, -1, -20, 13, 0 },
                                          { 15, 32, 18, -12, -18 },
                                          { 16, 5, 3, -5, -8 }
                                                                   };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = new int[5, 5] {
                                          { -8, -5, 3, -12, 16 },
                                          { -5, -1, -20, 13, 15 },
                                          { -9, -13, -15, 27, 18 },
                                          { -12, -20, -15, 18, 32 },
                                          { -17, -20, -18, -12, 13 }
                                                                   };
            Assert.AreEqual(wait, res);
        }
    }
}
