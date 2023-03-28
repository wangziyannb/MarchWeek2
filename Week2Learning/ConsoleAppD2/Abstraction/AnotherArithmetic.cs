using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppD2.Abstraction
{
    public class AnotherArithmetic : IArithmetic
    {
        public int Addition(params int[] arr)
        {
            throw new NotImplementedException();
        }

        public int Subtraction(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
