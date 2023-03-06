using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class Affect_enseignant_matiere
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Matiere")]
        public int IdMatiere { get; set; }
        public Matiere Matiere { get; set; }
        [ForeignKey("Enseignant")]
        public int IdEnseignant { get; set; }
        public Enseignant Enseignant { get; set; }
    }
}