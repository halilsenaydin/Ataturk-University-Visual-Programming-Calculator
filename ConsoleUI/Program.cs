using Core.Utilities;
using Operations.Abstracts;
using Operations.Concretes;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IOperationService operationService = new OperationManager();
            List<string> trying = new List<string>() { "Halil İbrahim" };


            var splited = ListOperations.Split(trying, " ");
            foreach (var i in splited)
            {
                foreach (var j in i)
                {
                    Console.WriteLine(j);
                }
            }

            Console.ReadLine();
        }
    }
}
