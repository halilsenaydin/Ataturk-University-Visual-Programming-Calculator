using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Concretes;
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

        private int counter { get; set; }

        public OperationManager()
        {
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
            counter = 0;
        }

        public void CalculatePreviousOperation(Operation operation)
        {

        }

        public IDataResult<double> Adding(double number)
        {
            counter++;
            previousNumber = newNumber;
            newNumber = number;

            _result += newNumber;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Division(double number) 
        {
            previousNumber = newNumber;
            newNumber = number;

            if (counter == 0)
            {
                _result = newNumber;
                counter++;
                return new SuccessDataResult<double>(_result);
            }

            counter++;
            _number = newNumber;
            _result /= _number;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Multiplication(double number)
        {
            if (counter == 0)
            {
                _result = 1;
            }

            counter++;
            _number = number;
            _result *= _number;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Subtraction(double number)
        {
            if (counter == 0)
            {
                _result = number;
                counter++;
                return new SuccessDataResult<double>(_result);
            }

            counter++;
            _number = number;
            _result -= _number;

            return new SuccessDataResult<double>(_result);
        }
    }
}
