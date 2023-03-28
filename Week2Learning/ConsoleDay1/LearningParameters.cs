using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDay1
{
    public class LearningParameters
    {
        public int PassByValue(int a, int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine( $"a = {a}, b = {b} sum = {a + b} inside function");
            return a + b;
        }
        public int PassByReference(ref int a, ref int b)
        {
            a = 100;
            b = 200;
            Console.WriteLine($"a = {a}, b = {b} sum = {a + b} inside function");
            return a + b;
        }
        public bool Author(string uname, string pass, out string msg)
        {
            msg = "";
            if (uname == "bob" && pass == "smith")
            {
                msg = "verified";
                return true;
            }
            else
            {
                msg = "not verified";
                return false;
            }
        }

        public void ParamsLearning( int a, string str, params int[] ints) //Formal parameters
        {
            int sum = 0;
            for(int i = 0; i < ints.Length; i++) {
                sum += ints[i];
            }
            Console.WriteLine(sum);
        }
    }
}
