using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopLearning.Loops_Urvashi
{
    public class Switch_Case
    {
        public static void Main(string[] args)
        {
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Good");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Better");
                    break;
                case 'E':
                    Console.WriteLine("Best");
                    break;
                default:
                    Console.WriteLine("Excellent");
                    break;
            }
            Console.WriteLine("your grade is {0}", grade);
            Console.ReadLine();
        }
    }
}


//OUTPUT
//Better
//Your grade is B