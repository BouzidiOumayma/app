using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class Enseignant
    {
        [Key]
        public int IdEnseignant { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Matiere { get; set; }
        [Required]
        public string Niveau { get; set; }
        [Required]
        public string Section { get; set; }
        public ICollection<Affect_enseignant_matiere> Affect_Enseignant_Matieres { get; set; }
    }
}