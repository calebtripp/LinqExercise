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
        {
            Console.WriteLine(numbers.Sum());
            //is foreach not usable for the first 2? I dont see a need for it.
            Console.WriteLine("Press Enter after viewing result to move to the next result.");
            Console.ReadLine();

            Console.WriteLine(numbers.Average());
            Console.ReadLine();

            numbers.OrderBy(x => x).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.ReadLine();

            numbers.OrderByDescending(x => x).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.ReadLine();

            numbers.Where(x => x > 0).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.ReadLine();

            numbers.Where(x => x > 5).OrderByDescending(x => x)
                                     .ToList().ForEach(numbers => Console
                                     .WriteLine(numbers));
            // is this what they meant with for each only?
            Console.ReadLine();

            numbers.SetValue(37, 4);                                            
            numbers.OrderByDescending(x => x)
                   .ToList().ForEach(numbers => Console
                   .WriteLine(numbers));
            //is this ok for solution? got a void error when just adding dot?
            Console.ReadLine();          

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
