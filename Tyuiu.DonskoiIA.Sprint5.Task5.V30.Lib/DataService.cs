using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DonskoiIA.Sprint5.Task5.V30.Lib
{
    public class DataService : ISprint5Task5V30
    {

        public double LoadFromDataFile(string path)
        {
            double ans = double.MinValue;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    int value = Convert.ToInt32(line);

                    if (value == 2)
                    {
                        ans = Math.Max(ans, value);
                        continue;
                    }

                    if (value > ans) {
                        bool temp = true;
                        for (int i = 2; i < Math.Pow(value, 0.5) + 1; i++)
                        {
                            if (value % i == 0)
                            {
                                temp = false;
                                break;
                            }
                        }
                        if (temp) ans = value;
                    }
                }
            }
            return Math.Round(ans, 3);
        }
    }
}