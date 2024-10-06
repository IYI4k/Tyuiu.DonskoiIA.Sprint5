using System;
using Tyuiu.DonskoiIA.Sprint5.Task6.V17.Lib;

namespace Tyuiu.DonskoiIA.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask6V17.txt " });
            var res = ds.LoadFromDataFile(path);
            Assert.AreEqual(8, res);
        }

        /*[TestMethod]
        public void ValidExpression2() {
            string path = Path.Combine(new string[] { "C:", "DataSprint5", "InPutDataFileTask6V17.txt " });

        }*/
    }
}