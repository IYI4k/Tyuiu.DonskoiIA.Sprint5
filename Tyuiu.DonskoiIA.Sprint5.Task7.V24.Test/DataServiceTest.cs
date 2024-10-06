using System;
using Tyuiu.DonskoiIA.Sprint5.Task7.V24.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask7V24.txt" });
            var res = ds.LoadDataAndSave(path);
            Assert.AreEqual(Path.Combine(new string[] { "C:", "DataSprint5", "OutPutDataFileTask7V24.txt" }), res);
        }
    }
}