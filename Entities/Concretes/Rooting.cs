using Core.Utilities;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Rooting : Operation
    {
        public Rooting(double rootInside) : base(rootInside)
        {
            _result = Math.Sqrt(rootInside);
        }
        public Rooting(double rootInside, double rootDegree):base(rootInside, rootDegree)
        {
            _result = Math.Pow(rootInside, 1 / rootDegree);
        }
        public override IDataResult<double> Process()
        {
            // Run Rules
            List<IResult> rules = new List<IResult>() { ArgumentOutOfRange(number2) }; // number2 == rootInside (true)
            var result = RulesRuner.Run(rules);
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            return new SuccessDataResult<double>(_result);
        }

        // Rules
        private IResult ArgumentOutOfRange(double number)
        {
            if (number < 0)
            {
                return new ErrorResult("Sayı beklenen aralıkta değil.");
            }

            return new SuccessResult();
        }
    }
}
