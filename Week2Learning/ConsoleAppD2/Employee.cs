using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppD2
{
    // Encapsulation: Propertiers, methods, accessmodifiers
    // Inheritance: FullTime & Emp
    // Polymorphism: Overloading, Overriding
    // Abstraction: Abstract, Interfaces
    public class Employee
    {
        //Constructors: 
        /*
         are used to create an object of the class and initialize class member
        Default constructors do not take any paramters
        if We create any other constructor, we are replacing the default constructor
        constructors can be overloaded.
        constructors cannot be inherited so a constructor cannot be overridden.
        by default, derivded class constructor will make a call to the base class parameterless constructor
         */
        public Employee()
        {
             
        }
        
        public Employee(int a)
        {

        }
        //private int _id;
        //public int OldId
        //{
        //    get { return _id; }
        //    set
        //    {
        //        if(value > 10)
        //        {
        //            return;
        //        }
        //        _id = value;
        //    }
        //}
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        //Overloading: allowing methods to have the same name for reusability, but different parameters to allow
        //different functionality
        // different number of parameters
        // Different data types in parameters
        // different Order of parameters
        // can change the return type of the function but it must use one of the three above with it.
        public string DoWork()
        {
            return "No Work is being done";
        }
        public string DoWork(int a)
        {
            return "No Work is being done";
        }
        public void DoWork(int a, int b)
        {
            Console.WriteLine("do something");
        }
        public virtual string DoWork(string str)
        {
            Console.WriteLine($"Currently Doing :{str}");
            return "Finshed Do Work in Emp";
        }
        public string DoWork(int a, string str)
        {
            return "No Work is being done";
        }
        public string DoWork(string str, int a)
        {
            return "No Work is being done";
        }

        public void Hiding()
        {
            Console.WriteLine("This is the hidden method");
        }
    }

    public class FullTime : Employee
    {
        public FullTime()
        {

        }

        public FullTime(int id, string name, string email) 
        {
            Id = id;
            Name = name;
            Email = email;
        }
        public new void Hiding()
        {
            Console.WriteLine("This is the hidden method In Fulltime");
        }
        public override string DoWork(string str)
        {
            Console.WriteLine($"Currently Doing :{str}");
            return "Finshed Do Work in Fulltime";
        }
    }
}
