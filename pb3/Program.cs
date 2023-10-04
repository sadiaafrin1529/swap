using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pb3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a c# shrap program to swap two  numbers
            int num1, num2, temp;
            Console.Write("Input the First Number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter swapping:");
            Console.WriteLine("\nFirst Number:" + num1);
            Console.WriteLine("\nsecond Number:" + num2);


            Console.ReadKey();


        }
    }
}
