using System;
using Tyuiu.DonskoiIA.Sprint5.Task2.V23.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });
            var res = ds.SaveToFileTextData(new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
            Assert.AreEqual(path, res);
        }
    }
}