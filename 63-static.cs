using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        public Employee (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = NextId;
            NextId++;
        }


        public static int NextId;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";
    }
}
