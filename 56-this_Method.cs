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
            Employee employee = new Employee();

            employee.SetName("Indigo", "Montoya");
        }
        public string FirstName;
        public string LastName;

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }
        public void SetName(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
