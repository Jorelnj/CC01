using CC01.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.DAL
{
    public class EcoleDAO
    {
        private static List<Ecole> ecoles;
        private const string FILE_NAME = @"ecoles.json";
        private readonly string dbFolder;
        private FileInfo file;
        public EcoleDAO(string dbFolder)
        {
            this.dbFolder = dbFolder;
            file = new FileInfo(Path.Combine(this.dbFolder, FILE_NAME));
            if (!file.Directory.Exists)
            {
                file.Directory.Create();
            }

            if (!file.Exists)
            {
                file.Create().Close();
                file.Refresh();
            }

            if (ecoles == null)
            {
                ecoles = new List<Ecole>();
            }
        }

        public void Set(Etudiant oldEcole, Ecole newEcole)
        {
            var oldIndex = ecoles.IndexOf(oldEcole);
            var newIndex = ecoles.IndexOf(newEcole);
            if (oldIndex < 0)
                throw new KeyNotFoundException("Cet ecole n'existe pas !");
            if (newIndex >= 0 && oldIndex != newIndex)
                throw new DuplicateNameException("L'ecole que vous recherchez existe déjà");
            ecoles[oldIndex] = newEcole;
            //Save();
        }

        public void Add(Ecole ecole)
        {
            var index = ecoles.IndexOf(ecole);
            if (index >= 0)
                throw new DuplicateNameException("This product reference already exists !");
            ecoles.Add(ecole);
            //Save();
        }

        /*private void Save()
        {
            ecoles.Save();
        }*/

        public void Remove(Ecole ecole)
        {
            ecoles.Remove(ecole); //base sur Product.Equals redefini
            //Save();
        }

        /*public IEnumerable<Ecole> Find()
        {
            return new List<Ecole>(ecoles);
        }*/
    }
}
