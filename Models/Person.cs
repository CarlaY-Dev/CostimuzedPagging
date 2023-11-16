using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PaggingMVC.Models
{
    public class Person
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "please Enter {0}")]
        [MaxLength(150)]
        public string Name { get; set; }
    }
}