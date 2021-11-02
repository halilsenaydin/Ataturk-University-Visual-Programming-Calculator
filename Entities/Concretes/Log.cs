using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Log : Operation
    {
        public Log(double number, double baseValue) : base(number)
        {
            _result = Math.Log(number, baseValue);
        }

        public override IDataResult<double> Process()
        {
            return new SuccessDataResult<double>(_result);
        }
    }
}
