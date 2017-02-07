using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    class Inputer
    {
        // return extract double from user string and display "Enter number"  
        public double get_double(string prompt) {

            Console.Write(prompt+" ");
            return Double.Parse(Console.ReadLine());
        }
    }
}
