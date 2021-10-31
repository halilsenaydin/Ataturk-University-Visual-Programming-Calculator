using Core.Utilities;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Division : Operation
    {
        public Division(double number2) : base(number2) {}
        public Division(double number1, double number2) : base(number1, number2) {}
        public override IDataResult<double> Process()
        {
            // Run Rules
            List<IResult> rules = new List<IResult>() { DivideByZero(number2) };
            var result = RulesRuner.Run(rules);
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            _result = this.number1 / this.number2;
            return new SuccessDataResult<double>(_result);
        }

        //  Rules!
        private IResult DivideByZero(double number)
        {
            if (number == 0)
            {
                return new ErrorDataResult<double>("Sıfıra Bölme Hatası!");
            }

            return new SuccessResult();
        }
    }
}
