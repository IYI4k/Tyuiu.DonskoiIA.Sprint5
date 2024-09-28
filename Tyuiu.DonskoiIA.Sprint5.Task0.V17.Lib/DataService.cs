using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DonskoiIA.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(new string[] { Directory.GetCurrentDirectory(), "OutPutFileTask0.txt" });
            File.WriteAllText(path, Math.Round(2.4 * x * x * x + 0.4 * x * x - 1.4 * x + 4.1, 3) + "");
            return path;
        }
    }
}