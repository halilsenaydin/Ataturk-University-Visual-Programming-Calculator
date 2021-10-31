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
            return new SuccessDataResult<double>(_result);
        }
    }
}
