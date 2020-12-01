using CC01.BO;
using CC01.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BLL
{
    public class EcoleBLO
    {
        EcoleDAO ecoleRepo;

        public EcoleBLO(string dbFolder)
        {
            ecoleRepo = new EcoleDAO(dbFolder);
        }

        public void CreateEcole(Ecole ecole)
        {
            ecoleRepo.Add(ecole);
        }

        public void DeleteEcole(Ecole ecole)
        {
            ecoleRepo.Remove(ecole);
        }     
        
    }
}
