using interfacedll;
using System;

using System.Collections.Generic;
using System.Text;

namespace interfaceclasses
{
    public class Person : IPerson           
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual void Accept()          
        {
            Console.WriteLine("Enter name of person: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter age of person: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void Display()              
        {
            Console.WriteLine("Name of person is: " + Name);
            Console.WriteLine("Age of person is: " + Age);

        }
    }
}
