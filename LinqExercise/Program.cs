using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {      
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static void Main(string[] args)
        {// work below
         // numbers.Sum().ToString => Console.WriteLine(numbers.Sum);

            numbers.Sum();
            Console.WriteLine(numbers.Sum());
            //numbers.ForEach(numbers => Console.WriteLine(numbers));  is foreach not usable for this first one? dont see a need for it.
                                
           // numbers.Average();
            Console.WriteLine(numbers.Average());

            //numbers.OrderBy(x => x);
            //numbers.OrderByDescending(x => x);


            //reference
       //vGList.OrderBy(vGList => vGList.Length)
       //.ToList()
       //.ForEach(vGList => Console.WriteLine(vGList));







            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

          

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
