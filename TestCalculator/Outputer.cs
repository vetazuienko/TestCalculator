using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator
{
    public class Outputer
    {
        // output prompt: a

        public string output_double(string prompt,double a) {

            string result = prompt + ": {0}";
            Console.WriteLine(result,a);
            return result;
        }
    }
}
