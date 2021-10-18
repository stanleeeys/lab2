using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Models.ViewModels
{
    public class ViewModelPerson
    {
        [Display(Name = "NamePerson")]
        [Required(ErrorMessage = "Este campo es requerido")]
        public string NamePerson { get; set; }

        [Display(Name = "AgePerson")]
        [Required(ErrorMessage = "Este campo es requerido")]

        public int AgePerson { get; set; }

        [Display(Name = "DescriptionPerson")]
        [Required(ErrorMessage = "Este campo es requerido")]

        public string DescriptionPerson { get; set; }
    }
}
