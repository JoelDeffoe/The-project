using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertStringIntoDouble()
        {
            string inputConver = "5";

            double convertNumber = _inputConverter.ConverterInputeToNumberic(inputConver);
            Assert.AreEqual(5, convertNumber);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringIntoDouble()
        {
            string inputConver = "*";

            double convertNumber = _inputConverter.ConverterInputeToNumberic(inputConver);

            
        }

    }
}
