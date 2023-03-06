using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class Etudiant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Niveau { get; set; }
        [Required]
        public string Section { get; set; }
        public ICollection<Note> Note { get; set; }
    }
}