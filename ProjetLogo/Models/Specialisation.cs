using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetLogo.Models
{
    public class Specialisation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Nom requis")]
        [StringLength(50)]
        public string Nom { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}