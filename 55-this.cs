using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        public string FirstName;
        public string LastName;
        public string Salary;

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }

        void SetName(string newFirstName, string newLastName)
        {
            this.FirstName = newFirstName;
            this.LastName = newLastName;
        }
    }
}
