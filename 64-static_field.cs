using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        static void Main()
        {
            Employee.NextId = 1000000;
            Employee employee1 = new Employee("Indigo", "Montoya");
            Employee employee2 = new Employee("Princess", "Buttercup");

            Console.WriteLine(
                "{0} {1} ({2})",
                employee1.FirstName,
                employee1.LastName,
                employee1.Id);
            Console.WriteLine(
                "{0} {1} ({2})",
                employee2.FirstName,
                employee2.LastName,
                employee2.Id);

            Console.WriteLine(
                $"NextId = {Employee.NextId}");
        }
    }
}
