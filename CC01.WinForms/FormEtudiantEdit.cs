using CC01.BO;
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
    public partial class FormEtudiantEdit : Form
    {
        public FormEtudiantEdit()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*try
            {

                Etudiant etudiant = new Etudiant
                (
                    txtNom.Text.ToUpper(),
                    txtPrenom.Text,
                    int.Parse(txtTelephone.Text),
                    txtIdentification.Text
                );

                StudentBLO productBLO = new StudentBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldStudent == null)
                    productBLO.CreateStudent(newStudent);
                else
                    productBLO.EditStudent(oldStudent, newStudent);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldStudent != null)
                    Close();

                txtUniversity.Clear();
                txtLastname.Clear();
                txtFirstname.Clear();
                txtDate.Clear();
                txtContactStudent.Clear();
                txtLocationStudent.Clear();
            }*/
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
