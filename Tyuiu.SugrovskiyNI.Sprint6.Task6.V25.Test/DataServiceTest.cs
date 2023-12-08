using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SugrovskiyNI.Sprint6.Task6.V25.Lib;



namespace Tyuiu.SugrovskiyNI.Sprint6.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V25.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "ELHLVt EgQpG dsE jiUFMDjMsEervIz ZujmucpYQE QybRwHOetJ";

            Assert.AreEqual(wait, res);
        }
    }
}
