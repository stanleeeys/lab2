using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lab2.Dominio
{
    public class Person
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdPerson { get; set; }

        public string NamePerson { get; set; }

        public int AgePerson { get; set; }

        public string DescriptionPerson { get; set; }

    }
}
