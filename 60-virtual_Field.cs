using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class1
    {
        static void Main()
        {
            Employee employee1 = new Employee();
            employee1.Name = "Inigo Montoya";
            System.Console.WriteLine(employee1.Name);

            //....
        }

        class Employee
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

            public string Name
            {
                get
                {
                    return $"{FirstName} {LastName}";
                }
                set
                {
                    string[] names;
                    names = value.Split(new char[] { ' ' });
                    if (names.Length == 2)
                    {
                        FirstName = names[0];
                        LastName = names[1];
                    }
                    else
                    {
                        throw new System.ArgumentException(
                            $"Assigned value '{value}' is invalid", "value");
                    }
                }
            }
        }
    }
}
