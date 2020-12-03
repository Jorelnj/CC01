using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {
        public string NomEcole { get; set; }
        public string Filiere { get; set; }
        public int AnneeAcademique { get; set; }

        public Ecole()
        {

        }

        public Ecole(string nomEcole, string filiere, int anneeAcademique)
        {
            NomEcole = nomEcole;
            Filiere = filiere;
            AnneeAcademique = anneeAcademique;
        }
    }


    
}
