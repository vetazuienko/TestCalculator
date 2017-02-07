using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestOutputer
    {
        [TestMethod]


        public void TestOutputer()
        {
            // output prompt: a

            // public string output_double(string prompt, double a)

            // arrange
            string my_text = "Hello";
            double my_number = 7;

            string expected_result = "Hello: 7";

            // act

            Outputer outputer = new Outputer();

            string result = outputer.output_double(my_text, my_number);


            // assert for text with register
            //Assert.AreEqual(expected_result, result, false);

            //with out register
            Assert.AreEqual("HI", result, false);

            // result and expected result in one memory place

            Assert.AreSame(expected_result, result);

        }
    }
}
