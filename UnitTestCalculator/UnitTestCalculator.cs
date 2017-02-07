using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestCalculator;

namespace UnitTestCalculator
{
    [TestClass]
    public class UnitTestCalculator
    {
        [TestMethod]
        // Only digits (positive and negative) minimum 10^-10 to 10^10 
        // if divided equals zero than print message "division on zero"

        public void TestDivision()
        {
            // public double calculate(double a, double b, Calculator.operation_types.div)
            // when div is call? when operator = Calculator.operation_types.div

            // init = arrange
            double first_numer = 2;

            double second_numer = 4;

            double expected_result = 0.5;

            // calculation = act

            Calculator calculator_for_test = new Calculator();

            double real_result = calculator_for_test.calculate(first_numer, second_numer, Calculator.operation_types.div);

            // result of test = assert

            //Assert.Equals(expected_result, real_result);

            Assert.AreEqual(expected_result, real_result, "Division first number on second");

        }


        [TestMethod]
        // simple assert equals

        public void TestSum() {

            // arrange

            double first_number = 1;
            double second_number = 2;

            double expected_result = 3;

            //act

            Calculator calc = new Calculator();

            double result = calc.calculate(first_number, second_number, Calculator.operation_types.sum);

            // assert

            // formatted text output
            //print_text(string text)
            //print_text("Hello")
            // string name="Mike";
            // string name2="Zara";
            //print_text("Hello {0}",name);

            //print_text("Hello {0} and {1}",name,name2);

            Assert.AreEqual(expected_result, result, "First {0} plus Second {1} and i want get {2}",first_number,second_number,expected_result );


        }

        [TestMethod]

        public void TestSumWithDelta()
        {
            // arrange
            // type variable_name = value;

            double a = 3;
            double b = 4;

            double delta = 0.001;

            double expected_result = 7; // 7-0.001 to 7+0.001

            // act
            Calculator calc = new Calculator();

            double result = calc.calculate(a, b, Calculator.operation_types.sum);

            // assert

            Assert.AreEqual(expected_result, result, delta, "{0} + {1} = {2} expected and {3} was calclated", a, b, expected_result, result);

        }



    }
}
