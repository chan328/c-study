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
        }

        public Employee (int id, string firstName, string lastName)
        
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public Employee(int id)
        {
            Id = id;

            // 직원 이름 조회...
            //...
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Salary { get; set; } = "Not Enough";
    }
}
