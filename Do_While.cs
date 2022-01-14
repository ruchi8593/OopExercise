using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopLearning.Loops_Urvashi
{
    public class Do_While
    {
        public static void Main(string[] args)
        {
            int a = 10;
            do
            {
                Console.WriteLine("value if a: {0}", a);
                a = a + 1;
            }
            while (a < 20);
            Console.WriteLine();
        }
    }
}
//OUTPUT
//value of a: 10
//value of a: 11
//value of a: 12
//value of a: 13
//value of a: 14
//value of a: 15
//value of a: 16
//value of a: 17
//value of a: 18
//value of a: 19