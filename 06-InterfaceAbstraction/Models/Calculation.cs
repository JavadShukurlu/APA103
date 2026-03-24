using _06_InterfaceAbstraction.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06_InterfaceAbstraction.Models
{
    internal class Calculation : ICalculation
    {
        

        public void Calculate(int num1, int num2)
        {
            Console.WriteLine($"Iki ededin cemi:{num1+num2}");
            Console.WriteLine($"Iki ededin ferqi:{num1-num2}");
            Console.WriteLine($"Iki ededin hasili:{num1*num2}");
            Console.WriteLine($"Iki ededin nisbeti:{Convert.ToDouble(num1/num2)}");
        }
    }
}
