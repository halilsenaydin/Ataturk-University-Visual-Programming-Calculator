using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public static class RulesRuner
    {
        public static IResult Run(List<IResult> rules)
        {
            foreach (var rule in rules)
            {
                if (!rule.Success)
                {
                    return new ErrorResult(rule.Message);
                }
            }

            return new SuccessResult();
        }
    }
}
