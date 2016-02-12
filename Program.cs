using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ProgrammingTechnologies
{
    public class FileReader
    {
        public void PrintMaxMin(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                StringBuilder sb = new StringBuilder();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    sb.Append(line);
                }
                var temp = sb.ToString();
                int[] arrayInt = new int[temp.Length];
                for (int i = 0, j = 0; i < temp.Length; i += 2, j++)
                {
                    arrayInt[j] = (int)Char.GetNumericValue(temp[i]);
                }

                int max = arrayInt[0]; int min = arrayInt[0];
                for (int i = 1; i < arrayInt.Length; i++)
                {
                    if (arrayInt[i] > max)
                    {
                        max = arrayInt[i];
                    }
                    if (arrayInt[i] < min)
                    {
                        min = arrayInt[i];
                    }
                }
                Console.WriteLine(String.Format("MAX = {0}, MIN = {1}", max, min));


            }
        }
    }
}

