using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppD2.Abstraction
{
    public interface ISeconds
    {
        public int Addition(params int[] seconds);
        public int Mulitply(int a, int b);
    }
}
