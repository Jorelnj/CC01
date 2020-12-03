using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Etudiant
    {
        public string Nom { get; set; } 
        public string Prenom { get; set; }
        public DateTime Date { get; set; }
        public string Lieu { get; set; }
        public int Telephone { get; set; }
        public string Email { get; set; }
        public string Identifiant { get; set; }
        public string Reference { get; set; }

        public Etudiant()
        {

        }

        public Etudiant(string nomEtudiant, string prenomEtudiant, DateTime date, string lieu, 
            int telephone, string email, string identifiant )
        {
            Nom = nomEtudiant;
            Prenom = prenomEtudiant;
            Date = date;
            Lieu = lieu;
            Telephone = telephone;
            Email = email;
            Identifiant = identifiant;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Nom.Equals(etudiant.Nom, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return -1304721846 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }

        /*public static object Where(Func<Etudiant, bool> predicate)
        {
            throw new NotImplementedException();
        }*/
    }
}
