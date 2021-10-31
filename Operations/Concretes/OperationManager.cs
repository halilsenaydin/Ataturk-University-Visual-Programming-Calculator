﻿using Core.Utilities;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using Entities.Concretes;
using Operations.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Concretes
{
    public class OperationManager : IOperationService
    {
        private double _result { get; set; }
        private Operation _previousOperation { get; set; }
        private int counter { get; set; }

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

        public IResult CalculatePreviousOperation(Operation operation)
        {
            if (counter == 0) // İlk işlem ise önceki işlem ataması yap.
            {
                _previousOperation = operation;
                return new SuccessResult();
            }

            if (_previousOperation == null) // Önceki işlem null ise.. (Eşittir basıldığı zaman önceki işleme null ataması yapılır.)
            {
                _previousOperation = operation;
                return new SuccessResult();
            }

            // Get Numbers
            _previousOperation.number1 = this._result;
            _previousOperation.number2 = operation.number2;

            // Process And Return
            var result = _previousOperation.Process();
            if (!result.Success)
            {
                return new ErrorResult(result.Message);
            }
            _result = result.Data;
            _previousOperation = operation; // Get reference of process
            return new SuccessResult();
        }

        public IDataResult<double> Adding(double number)
        {
            Operation newOperation = new Adding(number);
            var previousOperation = CalculatePreviousOperation(newOperation);
            if (!previousOperation.Success)
            {
                return new ErrorDataResult<double>(previousOperation.Message);
            }

            // İlk işlem ise sonuç girilen sayıdır.
            if (counter == 0)
            {
                counter++;
                _result = number;
            }

            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Subtraction(double number)
        {
            Operation newOperation = new Subtraction(number);
            var previousOperation = CalculatePreviousOperation(newOperation);
            if (!previousOperation.Success)
            {
                return new ErrorDataResult<double>(previousOperation.Message);
            }

            // İlk işlem ise sonuç girilen sayıdır.
            if (counter == 0)
            {
                counter++;
                _result = number;
            }
            
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Multiplication(double number)
        {
            Operation newOperation = new Multiplication(number);
            var previousOperation = CalculatePreviousOperation(newOperation);
            if (!previousOperation.Success)
            {
                return new ErrorDataResult<double>(previousOperation.Message);
            }

            // İlk işlem ise sonuç girilen sayıdır.
            if (counter == 0)
            {
                counter++;
                _result = number * 1; // çarpmada etkisiz eleman 1'dir.
            }

            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Division(double number)
        {
            Operation newOperation = new Division(number);
            var previousOperation = CalculatePreviousOperation(newOperation);
            if (!previousOperation.Success)
            {
                return new ErrorDataResult<double>(previousOperation.Message);
            }

            // İlk işlem ise sonuç girilen sayıdır.
            if (counter == 0)
            {
                counter++;
                _result = number;
            }

            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Equals(double number)
        {
            // Get Numbers
            _previousOperation.number1 = this._result;
            _previousOperation.number2 = number;

            // Process And Return
            var result = _previousOperation.Process();

            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }
            _previousOperation = null;
            _result = result.Data;
            return new SuccessDataResult<double>(_result);
        }

        public IDataResult<double> Root(double rootInside)
        {
            Operation operation = new Rooting(rootInside);
            var result = operation.Process();
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            return new SuccessDataResult<double>(result.Data);
        }

        public IDataResult<double> Root(double rootInside, double rootDegree)
        {
            Operation operation = new Rooting(rootInside, rootDegree);
            var result = operation.Process();
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            return new SuccessDataResult<double>(result.Data);
        }

        public IDataResult<double> Pow(double number)
        {
            Operation operation = new Pow(number);
            var result = operation.Process();
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            return new SuccessDataResult<double>(result.Data);
        }

        public IDataResult<double> Pow(double number, double degree)
        {
            Operation operation = new Pow(number, degree);
            var result = operation.Process();
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            return new SuccessDataResult<double>(result.Data);
        }

        public IDataResult<double> Inversion(double number)
        {
            Operation operation = new Inversion(number);
            var result = operation.Process();
            if (!result.Success)
            {
                return new ErrorDataResult<double>(result.Message);
            }

            return new SuccessDataResult<double>(result.Data);
        }
    }
}
