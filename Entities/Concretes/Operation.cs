using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Operation:IEntity
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public string OperationSymbol { get; set; }
    }
}
