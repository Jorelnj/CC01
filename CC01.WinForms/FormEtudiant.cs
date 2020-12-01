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
    public partial class FormEtudiant : Form
    {
        public FormEtudiant()
        {
            InitializeComponent();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            if (pBoxEtudiant.Image != null)
            {
                //string[] infos = new string[] { txtNom.Text, txtPrenom.Text, txtIdentifiant.Text, dateTimePicker1.Text, txtEmail.Text, txtContact.Text, ofd.FileName };
                string[] etudiant = new string[] { txtNom.Text, txtPrenom.Text, txtLieu.Text, dateTimePicker1.Text, txtEmail.Text, txtTelephone.Text, txtEmail.Text, txtIdentification.Text };
                string[] etudiants = new string[] { txtNom.Text, txtPrenom.Text, txtLieu.Text, dateTimePicker1.Text, txtEmail.Text, txtTelephone.Text, txtEmail.Text, txtIdentification.Text  };

                //Formulaires.listView1.Items.Add(new ListViewItem(etudiant));
                //Formulaires.Tab1.Add(etudiants);

                txtNom.Clear();
                txtPrenom.Clear();
                txtLieu.Clear();                
                txtEmail.Clear();
                txtTelephone.Clear();
                txtIdentification.Clear();
                pBoxEtudiant.ImageLocation = null;

                MessageBox.Show("Enregistrement réussi");
                //MessageBoxButtons.OK;
                //MessageBoxIcon.Information;
            }
        }

        private void pBoxEtudiant_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrCode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pBoxEtudiant.Image = qrCode.Draw(txtEtudiantQR.Text, 50);
        }
    }
}
