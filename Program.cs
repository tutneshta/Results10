using System;

namespace Task10._1
{
    class Program
    {
        static ILogger logger { get; set; }

        static void Main(string[] args)
        {
            logger = new Logger();

            Calculator calculator = new Calculator(logger);

            ErrorNumber errorNumber = new ErrorNumber(logger);

            Console.WriteLine("Введите 2 числа");

            try
            {
                int x = Int32.Parse(Console.ReadLine());

                int y = Int32.Parse(Console.ReadLine());

                Console.WriteLine($"Сумма чисел: {calculator.Sum(x, y)}");
            }
            catch (Exception ex)
            {
                errorNumber.Error("Error: ");

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

    }

}
