using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeList
{
    class Emploee
    {
        int number;
        string name;
        string lastName;
        int workHours;
        int salary;

        public Emploee(int number, string name, string lastName, int workHours)
        {
            this.number = number;
            this.name = name;
            this.lastName = lastName;
            this.workHours = workHours;
        }

        public void printLine()
        {
            Console.WriteLine(
                "| {0} | {1} |  {2} | {3} |",
                number,
                (name + " " + lastName).PadLeft(15),
                workHours,
                salary);
              


                
        }

    }
}
