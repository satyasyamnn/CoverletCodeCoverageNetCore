using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.Write(calculator.Add(10, 11));
        }
    }
}
