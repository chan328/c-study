using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        public class Employee
        {
            public string FirstName;
            public string LastName;
            public string Salary;
        }
        static void Main()
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            employee1.FirstName = "강";
            employee1.LastName = "찬";
            employee1.Salary = "적음";

            Increase(employee1);
            System.Console.WriteLine("{0} {1} 의 월급은 {2}",
                employee1.FirstName,
                employee1.LastName,
                employee1.Salary);
        }
        static void Increase(Employee employee)
        {
            employee.Salary = "많음";
        }
    }
}
