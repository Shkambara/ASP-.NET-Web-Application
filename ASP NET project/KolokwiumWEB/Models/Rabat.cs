using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KolokwiumWEB.Models
{
    public class Rabat
    {   
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRabat { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public Collection<Person> People { get; set; }
    }
}