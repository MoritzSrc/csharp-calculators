using System.Diagnostics.Contracts;

namespace CalculatorV1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers;
            double result = 0;

            Console.WriteLine("Calculator v1");
            Console.WriteLine("---------------");
            Console.Write("Which operation do you want to use(+, -, *, /)?: ");
            string operation = Console.ReadLine();
            Console.Write("How many numbers do you want to use?: ");
            numbers = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= numbers; i++)
            {
                 Console.Write($"Number {i}: ");
                 double number = Convert.ToDouble(Console.ReadLine());
                 if (i == 1)
                 {
                    result = number;
                 }
                 else
                 {
                     switch (operation)
                     {
                        case "+":
                            result += number;
                            break;

                        case "-":
                            result -= number;
                            break;

                        case "/":
                            result /= number;
                            break;

                        case "*":
                            result *= number;
                            break;


                     }
                            
                 }
            }
            Console.Write("Result: " + result);
            Console.Write("\nPress Enter to end the program... ");
            string beenden = Console.ReadLine();
        }
    }
}
