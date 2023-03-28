using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppD2.Abstraction
{
    // Interfaces: is a contract that gives a list of methods which must be implemented
    // by the derived class
    /*
     * Interfaces by default has all members as public
     * interfaces can only have method declaration and not implementation.
     * interaces cannote have constructors
     * interfaces cannot have variables but can have properties
     * you cannot make instance of an interface but you can still upcast
     * interfaces can support multiple inheritance but abstract classes cannot
    */
    /*
     
     */
    public interface IArithmetic
    {
        // This method accepts an array of integers and adds them all up into a singular returned int
        public int Addition(params int[] arr);
        //Collect two integers and subtract the first with the second and returns result
        public int Subtraction(int a, int b);
    }
}
