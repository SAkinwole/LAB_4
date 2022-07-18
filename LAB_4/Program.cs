using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum, secondNum, sum;

            Console.WriteLine("Kindy enter your first number: ");
            firstNum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kindly enter your second number: ");
            secondNum = Int32.Parse(Console.ReadLine());

            //sum = firstNum + secondNum;

            //if (sum < 100)
            //{
            //    Console.WriteLine("True");
            //}
            //else
            //{
            //    Console.WriteLine("False");
            //}

            if (firstNum + secondNum < 100)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadKey();
        }
    }
}
