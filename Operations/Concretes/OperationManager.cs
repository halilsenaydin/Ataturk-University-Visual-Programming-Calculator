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

        private double previousNumber { get; set; }
        private double newNumber { get; set; }

        private int numberOfTransactionsMade { get; set; }

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
            numberOfTransactionsMade = 0;
        }

        public IDataResult<double> Adding(double number)
        {
            numberOfTransactionsMade++;
            previousNumber = newNumber;
            newNumber = number;

            _result += newNumber;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Division(double number) 
        {
            numberOfTransactionsMade++;
            _number = number;
            _result /= _number;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Multiplication(double number)
        {
            if (numberOfTransactionsMade == 0)
            {
                _result = 1;
            }

            numberOfTransactionsMade++;
            _number = number;

            _result *= _number;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Subtraction(double number)
        {
            _number = number;
            var result = Adding((_number)*-1);
            _result = result.Data;

            return new SuccessDataResult<double>(_result);
        }
    }
}
