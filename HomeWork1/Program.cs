using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greeting();
            summa();
        }

        static void Greeting()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Hello, {0} {1}!", name, surname);
        }

        static void summa()
        {
            int sum = 0;
            int y = 0;
            while (Int32.TryParse(Console.ReadLine(), out y))
            {
                sum += y;
            }
            Console.WriteLine(sum);
        }
    }
}



