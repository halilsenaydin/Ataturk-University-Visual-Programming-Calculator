using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Inversion : Operation
    {
        public Inversion(double number) : base(number)
        {
            _result = 1/number;
        }

        public override IDataResult<double> Process()
        {
            return new SuccessDataResult<double>(_result);
        }
    }
}
