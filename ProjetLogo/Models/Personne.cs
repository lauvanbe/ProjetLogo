using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetLogo.Models
{
    public class Personne
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nom requis")]
        [StringLength(50)]
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Prénom requis")]
        [StringLength(50)]
        [Display(Name = "Prénom")]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Email requis")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email non valide")]
        [Display(Name = "Adresse Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Numéro de téléphone fixe requis")]
        [RegularExpression(@"^([0-9]{9})$", ErrorMessage = "Numéro non valide")]
        [Display(Name = "Numéro de téléphone fixe")]
        public int TelFixe { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Numéro non valide")]
        [Display(Name = "Numéro de GSM")]
        public int Gsm { get; set; }
    }
}