using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Armstrong
{
    class Armstrong
    {
        public void FindingArmstrong()
        {

            int lengthOfnumber = 0, count = 0;
            Console.WriteLine("\nenter a number: ");

            string input = Console.ReadLine();

            char[] separation = new char[] { ',' };
            string[] separatedArray = input.Split(separation, StringSplitOptions.RemoveEmptyEntries);

            for (int index = 0; index < separatedArray.Length; index++)
            {
                lengthOfnumber++;
            }

            int[] number = new int[100000];

            for (int iteration = 0; iteration < lengthOfnumber; iteration++)
            {
                int sumOfDigits = 0;
                int maximum = separatedArray[iteration].Length;
                for (count = 0; count < maximum; count++)
                {
                    number[count] = separatedArray[iteration][count];
                }
                for (int index = 0; index < maximum; index++)
                {
                    int[] output = new int[maximum];
                    int originalNumber = number[index] - 48;
                    output[index] = (int)Math.Pow(originalNumber, maximum);
                    sumOfDigits = sumOfDigits + output[index];
                }
                string compareNumber = Convert.ToString(sumOfDigits);
                if (compareNumber == separatedArray[iteration])
                {
                    Console.Write("true ");
                }
                else
                {
                    Console.Write("False ");
                }
            }
        }
    }
}