using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Class1
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nielm\Desktop\C#\Lab4\Lab04\zad3\pesels.txt";
            int x = 0;
            List<string> list = new List<string>();
            list = File.ReadAllLines(path).ToList();
            foreach (string line in list)
            {
                if ((line[9]-'0')% 2 == 0)
                {
                    x++;
                }
            }
            Console.WriteLine("K*biet jest: "+x);

        }
    }
}
