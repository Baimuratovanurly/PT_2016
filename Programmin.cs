using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace min
{
    class Program
    {
        static bool is_Prime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
                if (i == n || i > Math.Sqrt(n))
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Пользователь\Desktop.txt");
            using (StreamWriter sw = new StreamWriter(@"output.txt"))
            {
                int curr_line = int.Parse(sr.ReadLine());
                int minn = curr_line;
                string t_line;
                while ((t_line = sr.ReadLine()) != null)
                {
                    curr_line = int.Parse(t_line);
                    if (is_Prime(curr_line) && minn > curr_line)
                    {
                        minn = curr_line;
                    }
                }
                sw.WriteLine(minn);
            }
            Console.ReadKey();
        }
    }
}