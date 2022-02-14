using System;

namespace Assignment_1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Enter an operator: + , - , * , / ");

                switch (Console.ReadLine())
                {
                    case "+":
                        Addition(num1, num2);

                        break;

                    case "-":
                        subtraction(num1, num2);

                        break;

                    case "*":
                        Multiplication(num1, num2);

                        break;


                    case "/":
                        Divisionn(num1, num2);

                        break;


                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.WriteLine("Would you like to continue? Y= yes , N= no");
            } while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");
            Console.ReadKey();

        }

        static void Addition(double num1, double num2)
        {
            double c = num1 + num2;
            Console.WriteLine(c);
        }

        static void subtraction(double num1, double num2)
        {
            double c = num1 - num2;
            Console.WriteLine(c);
        }

        static void Multiplication(double num1, double num2)
        {
            double c = num1 * num2;
            Console.WriteLine(c);
        }

        static void Divisionn(double num1, double num2)
        {
            double c = num1 / num2;
            if (num2 == 0)

                Console.WriteLine("You can not divide a number by 0!");

            else

                Console.WriteLine(c);

        }
    }
}
