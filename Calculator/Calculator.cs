using System;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    public class Calculator
    {
        // Step 1: Addition method
        // Step 2: Multiplication method
        // Step 3: Subsraction Method
        // Step 4: Division Method

        public int Add(int x, int y)
        {
            if (x < y)
            {
                return x;
            }
            var sum = x + y;
            return sum;

           
        }
        public int Subtract(int x, int y)
        {

            var sum = x - y;
            return sum;
        }
        public int Multiply(int x, int y)
        {
            var sum = x * y;
            return sum;
        }
        public int Divide(int x, int y)
        {
            if (x % y == 0)
            {
                var sum = x / y;
                return sum;
            }
            return 0;
        }
    }
}
