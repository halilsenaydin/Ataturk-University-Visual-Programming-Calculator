using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Pow : Operation
    {
        public Pow(double baseValue) : base(baseValue)
        {
            _result = Math.Pow(baseValue, 2);
        }
        public Pow(double baseValue, double degree):base(baseValue, degree)
        {
            _result = Math.Pow(baseValue, degree);
        }
        public override IDataResult<double> Process()
        {
            return new SuccessDataResult<double>(_result);
        }
    }
}
