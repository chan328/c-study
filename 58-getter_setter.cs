using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        private string FirstName;

        public string GetFirstName()
        {
            return FirstName;
        }

        public void SetFirstName (string newFirstName)
        {
            if (newFirstName != null && newFirstName != "")
            {
                FirstName = newFirstName;
            }
        }

        private string LastName;
        public string GetLastName()
        {
            return LastName;
        }
        public void SetLastName (string NewLastName)
        {
            if (NewLastName != null && NewLastName != "")
            {
                LastName = NewLastName;
            }
            //.....
        }
    }
}
