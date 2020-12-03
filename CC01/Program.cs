using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "y";
            do
            {
                Console.Clear();
                Console.WriteLine("**********Enregistrement d'un élève**********");
                Console.Write("Entrer le nom de l'etudiant\t: ");
                string nom = Console.ReadLine();
                Console.Write("Entrer le prenom de l'etudiant\t: ");
                string prenom = Console.ReadLine();
                Console.Write("Entrer la date de naissance\t: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Entrer le lieu de naissance\t: ");
                string lieu = Console.ReadLine();
                Console.Write("Entrer le numero de telephone de l'etudiant\t: ");
                int telephone = int.Parse(Console.ReadLine());
                Console.Write("Entrer l'email de l'etudiant\t: ");
                string email = Console.ReadLine();
                Console.Write("Entrer l'identifiant de l'etudiant\t: ");
                string identifiant = Console.ReadLine();


                Etudiant etudiant = new Etudiant(nom, prenom, date, lieu, telephone, email, identifiant);
                EtudiantBLO etudiantBLO = new EtudiantBLO(ConfigurationManager.AppSettings["DbFolder"]);
                etudiantBLO.CreateEtudiant(etudiant);

                IEnumerable<Etudiant> etudiants = etudiantBLO.GetAllEtudiants();
                foreach (Etudiant e in etudiants)
                {
                    Console.WriteLine($"{e.Nom}\t{e.Prenom}\t{e.Date}\t{e.Lieu}\t{e.Telephone}\t{e.Email}\t{e.Identifiant}");
                }

                Console.WriteLine("Voulez-vous créer un autre etudiant ?[y/n]");
                choice = Console.ReadLine();
            }

            while (choice.ToLower() != "n");
            Console.WriteLine("Programme terminé !!");

            Console.ReadKey();
        }
    }
}
