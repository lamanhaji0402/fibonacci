using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo3
{
    public class Fibonacci
    {
        public Fibonacci() { }
        // Calculate Fibonici Series : 1,1,2,3,5,8,13..
        public int Calculate(int Position)
        {

            if (Position <= 1) return Position;

            else
                return Calculate(Position - 1) + Calculate(Position - 2);
        }
    }
}
