using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AllExpirience.Models
{
    public class Country
    {
        [Required(ErrorMessage = "Укажите вашу страну в который проживаете.")]
        [Display(Name = "Страна")]
        public int CountryId { get; set; }

        [Required(ErrorMessage = "Укажите вашу страну в который проживаете.")]
        [Display(Name = "Страна")]
        public string Name { get; set; }

        public ICollection<Help> Helps { get; set; }

        public Country()
        {
            Helps = new List<Help>();
        }
    }
}