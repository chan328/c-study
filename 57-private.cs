using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.FirstName = "강";
            employee.LastName = "찬";

            //...

            //password는 private이므로 dl외부에서 접근이 불가능하다.
            //console.writeline("Password = {0}", employee.Password);
        }
    }
    class Class1
    {
        public string FirstName;
        public string LastName;
        public string Salary;
        public string Password;
        private bool IsAuthenticated;

        public bool Logon (string password)
        {
            if (password == Password)
            {
                IsAuthenticated = true;
            }
            return IsAuthenticated;
        }

        public bool GetIsAuthenticated()
        {
            return IsAuthenticated;
        }
        //....
    }
}
