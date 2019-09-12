using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConverterInputeToNumberic(string argTextInput)
        {
            double convertedNumber;
            if(!double.TryParse(argTextInput, out convertedNumber))throw new ArgumentException("Epected a numeric value. ");
            return convertedNumber;
        }
    }
}
