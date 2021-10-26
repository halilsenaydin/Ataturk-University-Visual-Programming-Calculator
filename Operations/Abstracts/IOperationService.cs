using Core.Utilities.Results.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Operations.Abstracts
{
    public interface IOperationService
    {
        // Get
        Double GetResult();

        // Set
        void SetResult(double result);
        void ClearResult();

        // Four Operations (+, -, *, / )
        // will return result variable..
        IDataResult<double> Adding(double number);
        IDataResult<double> Subtraction(double number);
        IDataResult<double> Multiplication(double number);
        IDataResult<double> Division(double number);

        // Complex Operations (trigonometri, logaritma..)
    }
}
