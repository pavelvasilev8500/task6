using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace task_6
{
    class Employee : IComparable<Employee>
    {
        public string Info { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return "Info: " + Info + " Salary: " + Salary;
        }
        public int SBS(string info1, string info2)
        {
            return info1.CompareTo(info2);
        }
        public int CompareTo(Employee employee)
        {
            if (employee == null)
            {
                return 1;
            }
            else
            {
                return this.Salary.CompareTo(employee.Salary);
            }
        }    
    }

    class Empoyees
    {
        public void metod()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() { Info = "Вася Пупкин", Salary = 3 });
            employees.Add(new Employee() { Info = "Алексей Пупкин", Salary = 5 });
            employees.Add(new Employee() { Info = "Фёдор Пупкин", Salary = 2 });
            employees.Add(new Employee() { Info = "Николай Пупкин", Salary = 15 });
            Console.WriteLine("Employees:");
            foreach (Employee em in employees)
            {
                Console.WriteLine(em);
            }
            int i = 0;
            do
            {
                Console.Write("\nSort by:\n1 - Salary.\n2 - Info.\n3 - Exit.\n");

                while (!int.TryParse(Console.ReadLine(), out i))
                {
                    Console.Write("Please select one of variants:\t");
                }

                while (i < 0 || i >= 2147483647)
                {
                    Console.Write("Please select one of variants:\t");
                    while (!int.TryParse(Console.ReadLine(), out i))
                    {
                        Console.Write("Please select one of variants:\t");
                    }
                }

                switch (i)
                {
                    case 1:
                        employees.Sort();
                        Console.WriteLine("\nEmployees sort by salary:");
                        foreach (Employee em in employees)
                        {
                            Console.WriteLine(em);
                        }
                        break;
                    case 2:
                        employees.Sort(delegate (Employee x, Employee y)
                        {
                            if (x.Info == null && y.Info == null) return 0;
                            else if (x.Info == null) return -1;
                            else if (y.Info == null) return 1;
                            else return x.Info.CompareTo(y.Info);
                        });
                        Console.WriteLine("\nEmployees sort by Info:");
                        foreach (Employee em in employees)
                        {
                            Console.WriteLine(em);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Thanks for using! :)");
                        break;
                }
            }
            while (i != 3);
        }
    }
    
}
