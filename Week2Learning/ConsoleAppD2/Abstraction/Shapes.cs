using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppD2.Abstraction
{
    //Abstract Classes: Abstract classes cannot be instantiated but contrete classes can
    // as long as there is a single abstract method in the class, the class must be abstract
    // Abstract classes can contain concrete methods as well as abstract methods.

    //Abstract Methods: It is a method that can be used in an abstract class
    //IT does not have a body and the body is provided int derived class

    //Abstract vs virtual:
    //Abstract method doenst provide implementation and forced derived class to override
    //Virtual gives the option of overriding.

    public abstract class Shapes
    {

        public int Id { get; set; }

        public abstract void SomeMethod();

        public int GetId()
        {
            return Id;
        }
    }

    public class Square : Shapes
    {
        public override void SomeMethod()
        {
            Console.WriteLine("This is the body/content of the some method method");
        }
    }
}
