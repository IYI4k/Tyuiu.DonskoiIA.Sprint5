using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.DonskoiIA.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {

            string path2 = Path.Combine(new string[] { "C:", "DataSprint5", "OutPutDataFileTask7V24.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            /*string s = "";
            bool check = false;
            string tempstr = Path.GetFullPath() + '\\';
            foreach(string i in path.Split('\\'))
            {
                tempstr+= i;
            }
            path = Path.Combine(tempstr.Split('\\'));*/

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (check) { s += "\n"; }
                    bool ru = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] >= 'а' && line[i] <= 'я')
                        {
                            ru = true;
                        }
                        else
                        {
                            if (ru)
                            {
                                ru = false;
                                s += "слово";
                            }
                            s += line[i];
                        }
                    }
                    if (ru)
                    {
                        s += "слово";
                    }
                    check = true;
                }
            }

            File.AppendAllText(path2, s);

            //return s;
            return path2;
        }
    }
}