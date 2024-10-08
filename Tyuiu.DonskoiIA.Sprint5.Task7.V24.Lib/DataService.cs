﻿using System;
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

            /*string path2 = "";
            string[] SplitedPath = path.Split('/');
            string[] SplitedPath2 = new string[SplitedPath.Length];
            for (int i = 0; i < SplitedPath.Length - 1; i++)
            {
                SplitedPath2[i] = SplitedPath[i];
            }
            SplitedPath2[SplitedPath.Length - 1] = "OutPutDataFileTask7V24.txt";

            path2 = Path.Combine(SplitedPath2);*/

            string path2 = Path.Combine(new string[] { Path.GetTempPath(), "OutPutDataFileTask7V24.txt" });

            FileInfo f = new FileInfo(path2);
            if (f.Exists)
            {
                File.Delete(path2);
            }

            //string temppath = Directory.GetCurrentDirectory() + '\\' + path;


            //path = Path.Combine(temppath.Split('\\'));

            string s = "";
            bool check = false;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (check) { s += "\n"; }
                    bool ru = false;
                    for (int i = 0; i < line.Length; i++)
                    {
                        if ((line[i] >= 'а' && line[i] <= 'я') || (line[i] >= 'А' && line[i] <= 'Я'))
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