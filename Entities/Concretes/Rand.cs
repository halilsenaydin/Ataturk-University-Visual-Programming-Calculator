using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Rand : Operation
    {
        public Rand(double number) : base(number) // number2 == number (true)
        {
            _result = Math.Round(number);
        }

        public override IDataResult<double> Process()
        {
            return new SuccessDataResult<double>(_result);
        }
    }
}
