
using interfaceclasses;
using interfacedll;
using System;

namespace maininterface
{
    class maininterface
    {
        static void Main(string[] args)
        {
            Department department = new Department();   
            department.Accept();
            department.Display();
            Console.ReadLine();
        }
    }
}
