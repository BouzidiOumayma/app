using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace app.Data
{
    public class MyDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MyDBContext() : base("name=MyDBContext")
        {
        }

        public System.Data.Entity.DbSet<app.Models.Account> Accounts { get; set; }

        public System.Data.Entity.DbSet<app.Models.Etudiant> Etudiants { get; set; }

        public System.Data.Entity.DbSet<app.Models.Enseignant> Enseignants { get; set; }

        public System.Data.Entity.DbSet<app.Models.Note> Notes { get; set; }

        public System.Data.Entity.DbSet<app.Models.Matiere> Matieres { get; set; }

        public System.Data.Entity.DbSet<app.Models.Affect_enseignant_matiere> Affect_enseignant_matiere { get; set; }
    }
}
