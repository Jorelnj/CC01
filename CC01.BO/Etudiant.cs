using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    public class Etudiant : Ecole
    {
        public string NomEtudiant { get; set; } 
        public string PrenomEtudiant { get; set; }
        public DateTime DateNaissance { get; set; }
        public string Lieu { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Identifiant { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string nomEtudiant, string prenomEtudiant, DateTime dateNaissance, string lieu, 
            int telephone, string email, string identifiant )
        {
            NomEtudiant = nomEtudiant;
            PrenomEtudiant = prenomEtudiant;
            DateNaissance = dateNaissance;
            Lieu = lieu;
            Telephone = telephone;
            Email = email;
            Identifiant = identifiant;
        }
    }
}
