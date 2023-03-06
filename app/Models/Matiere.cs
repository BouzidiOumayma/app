using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class Matiere
    {
        [Key]
        public int IdMatiere { get; set; }

        public string name { get; set; }
        public ICollection<Affect_enseignant_matiere> Affect_Enseignant_Matieres { get; set; }
        
    }
}