using System;
using Tyuiu.DonskoiIA.Sprint5.Task0.V17.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task0.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask0.txt" });
            var res = ds.SaveToFileTextData(0);
            Assert.AreEqual(path, res);
        }
    }
}