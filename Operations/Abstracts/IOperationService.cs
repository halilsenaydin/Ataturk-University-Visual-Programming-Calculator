using Core.Utilities.Results.Abstracts;
using Entities.Abstracts;
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

        IResult CalculatePreviousOperation(Operation operation);
        IDataResult<double> Equals(double number);

        // Four Operations (+, -, *, / )
        IDataResult<double> Adding(double number);
        IDataResult<double> Subtraction(double number);
        IDataResult<double> Multiplication(double number);
        IDataResult<double> Division(double number);

        // Complex Operations
        IDataResult<double> Root(double rootInside); // x^(1/2)
        IDataResult<double> Root(double rootInside, double rootDegree); // x^(1/rootDegree)

        IDataResult<double> Pow(double number); // x^2
        IDataResult<double> Pow(double number, double degree); // x^degree

        IDataResult<double> Inversion(double number); // 1/x

        IDataResult<double> Sine(double number);
        IDataResult<double> Cosine(double number);

        IDataResult<double> Percent(double number);
        IDataResult<double> Log10(double number);


    }
}
