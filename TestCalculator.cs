using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class TestCalculator
    {
        public static void Main() {
            TestAddition();
            TestMultiplication();
            TestSubtraction();
            TestDivide();
        }

        public static void TestAddition()
        {
            //Arrange
            Calculator calculator = new Calculator(100, 200);
            float DesiredResult = 300;
           
            //Act
            float Result = calculator.Addition(100,200);
            
            //Assert
            if (Result==DesiredResult) {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Calculator->Addition Test-> OK");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Calculator->Addition Test-> FAIL");
                Console.ResetColor();
            }

        }

        static void TestMultiplication() {
            //Arrange
            Calculator calculator = new Calculator(-150, 1200);
            float DesiredResult = -180000;

            //Act
            float Result = calculator.Multiplication(-150,1200);

            //Assert
            if (Result == DesiredResult)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculator->Multiplication Test-> OK");
                Console.ResetColor();
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Calculator->Multiplication Test-> FAIL");
                Console.ResetColor();
            }
        }


        static void TestSubtraction() {
            //Arrange
            Calculator calculator = new Calculator(-800, 1600);
            float DesiredResult = -2400;

            //Act
            float Result= calculator.Subtraction(-800, 1600);

            //Assert
            if (Result==DesiredResult) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculator->Subtraction Test-> OK");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Calculator->Subtraction Test-> FAIL");
                Console.ResetColor();
            }

        }

        static void TestDivide() {
            //Arrange
            Calculator calculator = new Calculator(-800, 200);
            float DesiredResult = -4;

            //Act
            float Result = calculator.Divide(-800, 200);

            //Assert
            if (Result == DesiredResult)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculator->Divide Test-> OK");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Calculator->Divide Test-> FAIL");
                Console.ResetColor();
            }

        }
    }

}
