using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculator;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace UnitTestCalculatorMy
{
    [TestClass]
    public class UnitTestOutputer
    {
        // private variables
        private Calculator calculator_for_test; // reference on trash
      

        [TestInitialize]
        public void TestInitialize() {

            // create calculator instanse
            //Calculator calculator_for_test = new Calculator(); local

            this.calculator_for_test   = new Calculator(); // this.calculator_for_test   reference on real data

            Debug.WriteLine("Calculator created");


        }

        // final action after test
        [TestCleanup]
        public void TestCleanup() {

            Debug.WriteLine("All test finished");
           // this.calculator_for_test.Dispose(); error in calculator cannot free memory
        }


        [TestMethod]
        public void TestSum()
        {
            float x = 4;
            float y = 5;

            float expected_result = 9;

            float real_result = x + y;


            Assert.AreEqual(expected_result, real_result, "Sum is tested");

            Debug.WriteLine("Sum test is finished");
        }

        [TestMethod]
        public void TestSub()
        {
            float x = 4;
            float y = 5;

            float expected_result = -1;

            float real_result = x - y;


            Assert.AreEqual(expected_result, real_result, "Dub is tested");
            Debug.WriteLine("Sub test is finished");
        }

        //test string------------------------------------------

        //StringAssert

        [TestMethod]
        public void TestStringContainSubstring()
        {
            string str_1 = "Hello Mike";

            string str_2 = "Hello Miike";
            // contains substring
            StringAssert.Contains(str_1, "kes");
        }

        [TestMethod]
        public void TestStringEquals()
        {
            string str_1 = "Hello aaabbbb223 Mike";

            string str_2 = "1Hello Mike";
            // ok if equal types
            StringAssert.Equals(str_1, str_2);

            //ok if correct regular expression

            StringAssert.Matches(str_1, new Regex("(a){3}(b){3}(\\d){3}"));
        }


        [TestMethod]
        public void TestStringStartWith()
        {

            string str_1 = "Hell1o aaabbbb223 Mike";

            string str_2 = "1Hello Mike";
           
   

            StringAssert.StartsWith(str_1, "Hello");
        }

        [TestMethod]
        public void TestStringEndWith()
        {

            string str_1 = "Hell1o aaabbbb223 Mike";

            string str_2 = "1Hello Mike";
    

            StringAssert.EndsWith(str_1, "Mike");
        }


    }
}
