using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Factorial:Operation
    {
        public Factorial(double number) : base(number) // number2 == number (true)
        {
        }

        public override IDataResult<double> Process()
        {
            _result = GetFactorial(number2);
            return new SuccessDataResult<double>(_result);
        }

        private double GetFactorial(double n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return (n * GetFactorial(n - 1));
        }
    }
}
