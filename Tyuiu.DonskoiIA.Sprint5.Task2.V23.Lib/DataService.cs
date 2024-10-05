using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DonskoiIA.Sprint5.Task2.V23.Lib
{
    public class DataService : ISprint5Task2V23
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string path = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask2.txt" });

            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                File.Delete(path);
            }


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    File.AppendAllText(path, (matrix[i, j] % 2 == 0) ? (matrix[i, j]) + ";" : "0;");
                }
                File.AppendAllText(path, (matrix[i, 2] % 2 == 0) ? (matrix[i, 2]) + "\n" : "0\n");
            }
            for (int j = 0; j < 2; j++)
            {
                File.AppendAllText(path, (matrix[2, j] % 2 == 0) ? (matrix[2, j]) + ";" : "0;");
            }
            File.AppendAllText(path, (matrix[2, 2] % 2 == 0) ? (matrix[2, 2]) + "" : "0");

            return path;
        }
    }
}