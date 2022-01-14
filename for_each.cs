using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopLearning.Loops_Urvashi
{
    public class for_each
    {
        public static void Main(string[] args)
        {
            char[] MyArray = { 'H', 'E', 'L', 'L', 'O' };
            foreach(char ch in MyArray)
            {
                Console.WriteLine(ch);
            }
        }
    }
}

//OUTPUT
//H
//E
//L
//L
//O