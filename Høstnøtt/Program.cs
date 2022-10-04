using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Høstnøtt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 10000; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0 || j == 2)
                    {
                        Console.WriteLine("________________");
                        Console.WriteLine("|     ||||     |");
                        Console.WriteLine("|     ||||     |");
                        Console.WriteLine("|     ||||     |");
                        Console.WriteLine("|     OOOO     |");
                        Thread.Sleep(300);
                        Console.Clear();
                    }
                    else if (j == 1)
                    {
                        Console.WriteLine("________________");
                        Console.WriteLine("|     ||||     |");
                        Console.WriteLine("|    / |||     |");
                        Console.WriteLine("|   O  |||     |");
                        Console.WriteLine("|      OOO     |");
                        Thread.Sleep(300);
                        Console.Clear();
                    }
                    else if (j == 3)
                    {
                        Console.WriteLine("________________");
                        Console.WriteLine("|     ||||     |");
                        Console.WriteLine("|     ||| \\    |");
                        Console.WriteLine("|     |||  O   |");
                        Console.WriteLine("|     OOO      |");
                        Thread.Sleep(300);
                        Console.Clear();
                    }
                }
            }
        }
    }
}
