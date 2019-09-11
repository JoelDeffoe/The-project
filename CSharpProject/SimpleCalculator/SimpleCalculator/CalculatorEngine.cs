﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class CalculatorEngine
    {
        public double Calculate(string argOperat, double argFirstNumber, double argSecondNumber)
        {
            double result;

            switch(argOperat.ToLower())
            {
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "substract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;

                case "multiply":
                case "*":
                    result = argFirstNumber + argSecondNumber;
                    break;

                case "divide":
                case "/":
                    result = argFirstNumber + argSecondNumber;
                    break;

                default:
                    throw new InvalidOperationException("Specified operation is not recognised");
            }

            return result;
        }
    }
}