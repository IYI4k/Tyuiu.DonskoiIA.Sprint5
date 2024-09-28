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
            string path = "C:\\Users\\User\\source\\repos\\Tyuiu.DonskoiIA.Sprint5\\Tyuiu.DonskoiIA.Sprint5.Task0.V17.Test\\bin\\Debug\\net8.0\\OutPutFileTask0.txt";
            var res = ds.SaveToFileTextData(0);
            Assert.AreEqual(path, res);
        }
    }
}