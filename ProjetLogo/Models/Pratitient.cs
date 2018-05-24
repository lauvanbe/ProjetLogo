using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetLogo.Models
{
    public class Pratitient : Personne
    {
        [Required(ErrorMessage = "Numéro Inami requis")]
        [RegularExpression(@"^([0-9]{11})$", ErrorMessage = "Numéro non valide")]
        public int Inami { get; set; }

        public Specialisation Specialisation { get; set; }

        public byte SpecialisationId { get; set; }

        public Fonction Fonction { get; set; }

        public byte FonctionId { get; set; }
    }
}