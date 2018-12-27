
using interfacedll;
using System;

namespace interfaceclasses
{
    public class Department : Employee, IDepartment     
    {
        public string department { get; set; }
        public override void Accept()
        {
            base.Accept();                   
            Console.WriteLine("Enter the Department: ");
            department = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();                   
            Console.WriteLine("Department is: " + department);
        }
    }
}
