using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalcWebAPI.Model
{
    public class CalcModel
    {
        [RegularExpression(@"^\d+$", ErrorMessage = "Znak nie je cislo")]
        [Required]
        public int Number1 { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Znak nie je cislo")]
        [Required]
        public int Number2 { get; set; }
        [RegularExpression(@"^\+|-|\*|\/$", ErrorMessage = "Znak nie je matematicky operator")]
        [Required]
        public string Operator { get; set; }
    }
}
