using ListaCsharp;
using System.Globalization;
using System;
using System.Collections.Generic;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x._id == searchId);
            if (emp != null) {
                Console.Write("Enter the percentage: ");
                decimal percentage = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.increaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Employee obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}