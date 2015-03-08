using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Emploee> employees = new List<Emploee>();


            employees.Add(new Emploee(1, "Alex", "Nuberg", 8));
            employees.Add(new Emploee(2, "Vasya", "Ivanov", 7));
            employees.Add(new Emploee(3, "Petya", "Petrov", 6));
            employees.Add(new Emploee(4, "Kolya", "Sidorov", 5));
            employees.Add(new Emploee(5, "Robert", "Lorry", 4));
            employees.Add(new Emploee(6, "Bob", "Nolan", 3));

            Console.WriteLine("| {0} | {1} | {2} | {3} |", "#", ("Name").PadLeft(15), "WH", "S");

            foreach (Emploee emp in employees)
            {
                emp.printLine();
            }

        }
    }
}
