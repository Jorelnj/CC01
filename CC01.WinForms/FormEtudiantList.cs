﻿using System;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            string value = txtRechercher.Text.ToLower();
            var products = etudiantBLO.GetBy
            (
                x =>
                x.Reference.ToLower().Contains(value) ||
                x.Name.ToLower().Contains(value)
            ).OrderBy(x => x.Reference).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = products;
            lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
        }

        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
