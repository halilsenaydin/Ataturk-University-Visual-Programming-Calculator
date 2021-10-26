using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Operations.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Concretes
{
    public class OperationManager : IOperationService
    {
        public double _number { get; set; }
        private double _result { get; set; }

        public OperationManager()
        {
            _result = 0;
        }

        public double GetResult() // Encapsulation
        {
            return _result;
        }

        public void SetResult(double result)
        {
            _result = result;
        }

        public void ClearResult()
        {
            _result = 0;
        }

        public IDataResult<double> Adding(double number)
        {
            _number = number;
            _result += _number;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Division(double number) 
        {
            _number = number;
            _result /= _number;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Multiplication(double number) // Toplama işlemi  ile çarpma..
        {
            _number = number;

            double smallest = Math.Min(_result, number);
            double biggest = Math.Max(_result, number);

            for (int i = 0; i < smallest; i++)
            {
                _result += biggest;
            }
            
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Subtraction(double number)
        {
            _number = number;
            var result = Adding((_number)*-1);
            if (result.Success)
            {
                return new SuccessDataResult<double>(_result);
            }

            return new ErrorDataResult<double>(_result);
        }
    }
}
