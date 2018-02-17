using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                Armstrong number = new Armstrong();
                number.FindingArmstrong();
                Console.WriteLine("\nDo you want to continue? y/n");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    number.FindingArmstrong();
                }
                else {
                    break;
                }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    Console.WriteLine("Enter Valid Inputs.");
                }
            }
        }
    }
}
