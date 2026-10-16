using Tests.DTO;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
namespace Tests
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Console.ReadLine();

        }

        public static class ValidationTester
        {
            public static List<ValidationResult> ValidateModel(object model)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(model, serviceProvider: null, items: null);
                bool isValid= Validator.TryValidateObject(model, context, results, validateAllProperties: true);
                return results;
            }
  
       

       

      



    }
}
