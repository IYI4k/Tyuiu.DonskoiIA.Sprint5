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
                double x = 0;
                int i = 0;
                double del = 0;

                while (i < line.Length)
                {
                    if (line[i] == '.' || line[i] == ',')
                    {
                        i++;
                        del = line.Length - i;
                        goto DOT;
                    }
                    x = x * 10 + line[i++] - '0';
                }

            DOT:
                while (i < line.Length)
                {
                    x = x * 10 + line[i++] - '0';
                }
                if (del > 0) x = x / Math.Pow(10, del);

                return Math.Round(Math.Pow((x * x) / Math.Sin(x), 3), 3);
            }
        }
    }
}