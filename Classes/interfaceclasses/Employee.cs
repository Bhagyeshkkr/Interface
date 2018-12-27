using interfacedll;
using System;

using System.Collections.Generic;
using System.Text;

namespace interfaceclasses
{
    public class Employee : Person, IEmployee           
    {
        public int Empid { get; set; }
        public override void Accept()
        {
            base.Accept();                            
            Console.WriteLine("Enter EMpID: ");
            Empid = Convert.ToInt32(Console.ReadLine());
        }

        public override void Display()
        {
            base.Display();                           
            Console.WriteLine("Employee Id: " + Empid);
        }
    }
}
