using System;
using System.Collections.Generic;
using System.Text;

namespace JenkinsTest
{
    public class Calc
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }
        
        public int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
        
        public string Divide(int a, int b)
        {
            int remainder, quotient = Math.DivRem(a, b, out remainder);
            return quotient + " remainder = " + remainder;
        }
        
        public int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }


    }
}
