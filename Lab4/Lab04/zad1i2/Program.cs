using System;




namespace Lab04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ZADANIE 1
            string path = @"C:\Users\Nielm\Desktop\C#\Lab4\Lab04\wynik.txt";

            using var sw = new StreamWriter(path);
            sw.WriteLine("117806");

            Console.WriteLine("Nr albumu został zapisany");

            */
            //ZADANIE 2 
            string path = @"C:\Users\Nielm\Desktop\C#\Lab4\Lab04\wynik.txt";
           // string [] lines = File.ReadAllLines(path);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
    }
}