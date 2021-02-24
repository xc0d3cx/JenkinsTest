using System;


namespace JenkinsTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int input1 = 0;
            int input2 = 0;

            var calc = new Calc();

            Console.WriteLine("+++++++++++++++++++++++++++");

            Console.Write("Enter first number: ");
            input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("+++++++++++++++++++++++++++");

            Console.WriteLine("{0} + {1} = {2}", input1, input2, calc.Add(input1, input2));
            Console.WriteLine("{0} - {1} = {2}", input1, input2, calc.Subtract(input1, input2));
            Console.WriteLine("{0} / {1} = {2}", input1, input2, calc.Divide(input1, input2));
            Console.WriteLine("{0} * {1} = {2}", input1, input2, calc.Multiply(input1, input2));
        }
    }
}
