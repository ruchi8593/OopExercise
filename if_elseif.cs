using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopLearning.Loops_Urvashi
{
    public class if_elseif
    {
        public static void Main(string[] args)
        {
            int num = 12;
            if (num < 5)
            {
                Console.WriteLine("{0} is less than 5", num); 
            }
            else if (num > 5)
            {
                Console.WriteLine("{0} is greater than 5", num);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }
        }
    }
}
//OUTPUT
//12 is greater than 5