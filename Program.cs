using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> query1 = from num in list
                                     where num > 5
                                     select num;

            foreach(var integer in query1)
            {
                Console.WriteLine("Number greater than 5 are " + integer);
            }


            Console.WriteLine("===================================================");


            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ Id = 1 , Name = "Harsh"},
                new Employee(){ Id = 2 , Name = "Harry"}
            };

            IEnumerable<Employee> query2 = from emp in employees
                                           where emp.Id == 1
                                           select emp;

            foreach(var item in query2)
            {
                Console.WriteLine("Id = " + item.Id + " and Name = " + item.Name);
            }

            Console.ReadLine();

        }


        class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }
        }
    }
}
