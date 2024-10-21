using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DonskoiIA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {

        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                double x = Convert.ToDouble(line);
                return Math.Round(Math.Pow((x * x) / Math.Sin(x), 3), 3);
            }
        }
    }
}