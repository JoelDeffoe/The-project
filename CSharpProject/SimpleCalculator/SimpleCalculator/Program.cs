using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firsNumber = inputConverter.ConverterInputeToNumberic(Console.ReadLine());
                double secondNuber = inputConverter.ConverterInputeToNumberic(Console.ReadLine());

                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firsNumber, secondNuber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
