using System;
using Tyuiu.DonskoiIA.Sprint5.Task4.V20.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask4V20.txt" });
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(1.678, res);
        }
    }
}