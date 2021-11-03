using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Absolute : Operation
    {
        public Absolute(double number) : base(number) // number2 == number (true)
        {
        }

        public override IDataResult<double> Process()
        {
            _result = Abs(number2);
            return new SuccessDataResult<double>(_result);
        }

        public double Abs(double number)
        {
            if (number < 0)
            {
                return number * (-1);
            }

            return number;
        }
    }
}
