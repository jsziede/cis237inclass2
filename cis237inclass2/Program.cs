using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for factorials or 2 for Tower of Hanoi.");
            string userInput = Console.ReadLine();
            switch(userInput)
            {
                case "1":
                    Factorial factorial = new Factorial();
                    break;
                case "2":
                    Console.WriteLine("Enter number of disks on tower:");
                    userInput = Console.ReadLine();
                    try
                    {
                        Hanoi hanoi = new Hanoi();
                        hanoi.moveDisks(Int32.Parse(userInput), 'A', 'B', 'C');
                    }
                    catch
                    {
                        Console.WriteLine("Please use an integer.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    break;
            }
        }
    }
}
