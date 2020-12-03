using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC01.WinForms
{
    public partial class FormEtudiantList : Form
    {
        private object etudiantBLO;

        public FormEtudiantList()
        {
            InitializeComponent();
        }    

        private void loadData()
        {
            string value = txtRechercher.Text.ToLower();           
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            Form f = new FormEtudiantEdit(loadData);
            f.Show();
        }
    }
}
