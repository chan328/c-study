using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Program
    {
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        private string _FirstName;

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
            private string _LastName;
    }
}


    class Employee
    {
        public string FirstName;
        
        static void Main()
        {
            Employee employee = new Employee();
            employee.FirstName = "강";
            System.Console.WriteLine(employee.FirstName);
        }
    }

