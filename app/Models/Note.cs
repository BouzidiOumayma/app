using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace app.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string matiere { get; set; }
        public string NoteValeur { get; set; }
        [ForeignKey("Etudiant")]
        public int IdEtudiant { get; set; }
        public Etudiant Etudiant { get; set; }
    }
}