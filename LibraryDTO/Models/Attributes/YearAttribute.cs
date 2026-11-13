using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDTO
{
    public class YearAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            
            return base.IsValid(value);
        }
    }
}
