﻿using System;
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
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name :");
            firstName = System.Console.ReadLine();

            System.Console.Write("Enter your last name:");
            lastName = System.Console.ReadLine();

            System.Console.WriteLine( $"your full name is { firstName } { lastName }." );
            System.Console.WriteLine( "your full name is " + firstName + " " + lastName );
            System.Console.WriteLine(String.Format("your full name is {0} {1}.", firstName, lastName));
            // printf("your full name is %s %s", %(firstName, lastName);
        }
    }
}
