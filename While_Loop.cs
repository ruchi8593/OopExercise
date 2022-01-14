using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopLearning.Loops_Urvashi
{
    public class While_Loop
    {
        public static void Main(string[] args)
        {
            int i = 10;
            while(i < 18)
            {
                Console.WriteLine("value of i: {0}", i);
                i++;
            }

        }
    }
}

//OUTPUT
//value of i: 10
//value of i: 11
//value of i: 12
//value of i: 13
//value of i: 14
//value of i: 15
//value of i: 16
//value of i: 17