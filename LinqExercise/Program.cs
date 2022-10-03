using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LinqExercise
{
    class Program
    {
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
        static void Main(string[] args)
        {
            Console.WriteLine(numbers.Sum());          
            Console.WriteLine("Press Enter after viewing result to move to the next result.");
            Console.ReadLine();

            Console.WriteLine(numbers.Average());
            Console.ReadLine();

            numbers.OrderBy(x => x).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.ReadLine();

            numbers.OrderByDescending(x => x).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.ReadLine();

            numbers.Where(x => x > 6).ToList().ForEach(numbers => Console.WriteLine(numbers));
            Console.ReadLine();

            numbers.Where(x => x > 5).OrderByDescending(x => x)
                                     .ToList()
                                     .ForEach(numbers => Console
                                     .WriteLine(numbers));
                                      Console.ReadLine();

            numbers.SetValue(37, 4);                 
            numbers.OrderByDescending(x => x)
                   .ToList().ForEach(numbers => Console
                   .WriteLine(numbers));
            Console.ReadLine();                
                                       
            var employees = CreateEmployees();
            
            employees.Where(x => x.FirstName                   
                     .StartsWith('C') || x.FirstName
                     .StartsWith('S'))
                     .OrderBy(x => x.FirstName)
                     .ToList().ForEach(x => Console
                     .WriteLine(x.FullName));
            Console.ReadLine();

            employees.Where(x => x.Age > 26)
                     .OrderBy(x => x.Age)
                     .ThenBy(x => x.FirstName)
                     .ToList()
                     .ForEach(x => Console
                     .WriteLine(x.FullName));
            Console.ReadLine();
                       
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience)); 
            Console.WriteLine(employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience)); 
            Console.ReadLine();

            employees = employees.Append(new Employee("Denise", "Shines", 34, 2)).ToList();
            employees.ForEach(y => Console.WriteLine(y.FullName));                     
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


