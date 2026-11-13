using Tests.DTO;
using System.Collections.Generic;
using System.Collections;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;
using System;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.Net;
using LibraryModels;
namespace Tests
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            Author author = new Author
            {
                AuthorFirstName = "Kjfkdjk",
                AuthorId = "1",
                AuthorLastName = "Agfg",
                AuthorPicture = "fgfgfj.jpg",
                AuthorYear = 1234,
                CountryId = 3
            };
            ValidateModel(author);
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
