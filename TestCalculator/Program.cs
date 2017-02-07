using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Inputer input = new Inputer();
            Outputer output = new Outputer();

            output.output_double("Result", calculator.calculate(input.get_double("Enter first number"), input.get_double("Enter second number"), Calculator.operation_types.div));

            Console.ReadKey();
        }
    }
}
