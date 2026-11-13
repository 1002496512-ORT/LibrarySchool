using LibraryDTO;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Net;
namespace Tests
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            
            Console.ReadLine();
        }
            public static void ValidateModel(object model)
            {
                var results = new List<ValidationResult>();
                var context = new ValidationContext(model,  null,  null);
                bool isValid= Validator.TryValidateObject(model, context, results, validateAllProperties: true);
                if (isValid == false)
                {
                    foreach (var vr in results)
                    {
                        Console.WriteLine(vr.ErrorMessage);
                    }
                }
                else
                    Console.WriteLine("The model is correct");
                
            }
  
       

       

      



    }
}
