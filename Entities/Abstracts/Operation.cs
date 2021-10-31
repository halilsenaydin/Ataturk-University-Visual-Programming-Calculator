using Core.Utilities.Results.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Abstracts
{
    public abstract class Operation
    {
        // Props
        public double number1 { get; set; }
        public double number2 { get; set; }
        protected double _result { get; set; }

        // Contructors
        public Operation() { }
        public Operation(double number2)
        {
            this.number2 = number2;
        }
        public Operation(double number1, double number2):this(number2)
        {
            this.number1 = number1;
        }

        // Methods
        public abstract IDataResult<double> Process();
    }
}
