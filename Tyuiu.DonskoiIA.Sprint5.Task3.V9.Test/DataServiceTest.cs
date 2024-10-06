using System;
using Tyuiu.DonskoiIA.Sprint5.Task3.V9.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask3.bin" });
            var res = ds.SaveToFileTextData(2);
            Assert.AreEqual(path, res);
        }
    }
}