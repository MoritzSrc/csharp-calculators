using System.Data;

namespace CalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Calculator v2");
                Console.WriteLine("--------------------------");
                Thread.Sleep(2000);
                Console.Clear();
                Console.Write("Enter your exercise: ");
                string exercise = Console.ReadLine();
                var table = new DataTable();
                var result = table.Compute(exercise, "");
                Console.WriteLine(result);
                Console.Write("Do you want to end the calculator (yes/no)?: ");
                string frage = Console.ReadLine();
                if (frage == "yes" || frage == "Yes")
                {
                    Console.WriteLine("Ending... ");
                    Thread.Sleep(2000);
                    break;
                }
                else
                {
                    Console.WriteLine("Back to start...");
           
                }
            }
        }
    }
}
