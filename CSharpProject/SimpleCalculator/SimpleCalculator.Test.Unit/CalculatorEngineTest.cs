using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class UnitTest1
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddmetodeVerificationNonSybole()
        {
            int number1 = 1;
            int number2 = 2;

            double result = _calculatorEngine.Calculate("add", number1, number2);
        }

        [TestMethod]
        public void AddmetodeVerificationSybole()
        {
            int number1 = 1;
            int number2 = 2;

            double result = _calculatorEngine.Calculate("+", number1, number2);
        }
    }
}
