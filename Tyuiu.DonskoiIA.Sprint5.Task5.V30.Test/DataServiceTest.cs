using System;
using Tyuiu.DonskoiIA.Sprint5.Task5.V30.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task5.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask5V30.txt" });
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(17, res);
        }
    }
}