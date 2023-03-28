using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppD2.Abstraction
{
    public sealed class Arithmetic : IArithmetic, ISeconds
    {
        int IArithmetic.Addition(params int[] arr)
        {
            int sum = 0;
            for(int i  = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public int Mulitply(int a, int b)
        {
            throw new NotImplementedException();
        }

        
        int ISeconds.Addition(params int[] seconds)
        {
            return 0;
        }

        public int Subtraction(int a, int b)
        {
            throw new NotImplementedException();
        }

        public static int MathHelper(int a, int b)
        {
            return a + b;
        }

        public static int Qwerty = 100000;
    }
}
