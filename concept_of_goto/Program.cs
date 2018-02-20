/*
 * C# Program to Illustrate the Concept of Goto
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace concept_of_goto
{
    class Program
    {
        static void Main(string[] args)
        {
            int no, per, option;
            float ans;
        loop:
            Console.Write("Enter a Number :\t");
            no = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Percentage Value : \t");
            per = Convert.ToInt32(Console.ReadLine());
            ans = (float)(no * per) / 100;
            Console.WriteLine("Percentage Value is:\t{0}", ans);
            Console.Write("\nCalculate again press 1.   To quit press digit:\t");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                goto loop;
            }
            Console.WriteLine("Press Enter for quit");
            Console.ReadLine();
        }
    }
}
