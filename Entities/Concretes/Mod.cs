using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Mod:Operation
    {
        public Mod() { }
        public Mod(double number2) : base(number2) { }
        public Mod(double number1, double number2) : base(number1, number2) { }
        public override IDataResult<double> Process()
        {
            _result = this.number1 % this.number2;
            return new SuccessDataResult<double>(_result);
        }
    }
}
