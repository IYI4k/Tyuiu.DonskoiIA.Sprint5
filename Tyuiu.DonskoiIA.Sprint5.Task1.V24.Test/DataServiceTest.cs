using System;
using Tyuiu.DonskoiIA.Sprint5.Task1.V24.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });
            var res = ds.SaveToFileTextData(-5, 5);
            Assert.AreEqual(path, res);
        }
    }
}