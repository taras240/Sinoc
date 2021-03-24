using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(50, 20);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("СИНОК ВВЕДИ ЧИСЛО");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int a = 0; a < i; a++)
            {
                Console.WriteLine("___С И Н О К___");
                System.Threading.Thread.Sleep(500/(a+1));
            }
            Console.ReadKey();
        }
    }
}
