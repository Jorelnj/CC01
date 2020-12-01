namespace CC01.WinForms
{
    partial class FormEtudiant
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLieu = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifie = new System.Windows.Forms.Button();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblLieu = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTéléphone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.txtIdentification = new System.Windows.Forms.TextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.pBoxEtudiant = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEtudiantQR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(144, 45);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(245, 22);
            this.txtNom.TabIndex = 0;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(12, 51);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(37, 16);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.Location = new System.Drawing.Point(12, 83);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(55, 16);
            this.lblPrenom.TabIndex = 3;
            this.lblPrenom.Text = "Prenom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(144, 83);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(245, 22);
            this.txtPrenom.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(128, 16);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "Date de naisssance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-277, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Identification";
            // 
            // txtLieu
            // 
            this.txtLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLieu.Location = new System.Drawing.Point(144, 169);
            this.txtLieu.Name = "txtLieu";
            this.txtLieu.Size = new System.Drawing.Size(245, 22);
            this.txtLieu.TabIndex = 6;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(144, 221);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(245, 22);
            this.txtTelephone.TabIndex = 8;
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.Lime;
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.ForeColor = System.Drawing.Color.White;
            this.btnCreer.Location = new System.Drawing.Point(12, 405);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(90, 33);
            this.btnCreer.TabIndex = 10;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(375, 405);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(128, 33);
            this.btnSupprimer.TabIndex = 12;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifie
            // 
            this.btnModifie.BackColor = System.Drawing.Color.MediumPurple;
            this.btnModifie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifie.ForeColor = System.Drawing.Color.White;
            this.btnModifie.Location = new System.Drawing.Point(118, 405);
            this.btnModifie.Name = "btnModifie";
            this.btnModifie.Size = new System.Drawing.Size(90, 33);
            this.btnModifie.TabIndex = 13;
            this.btnModifie.Text = "Modifier";
            this.btnModifie.UseVisualStyleBackColor = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(231, 405);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(128, 33);
            this.btnRechercher.TabIndex = 14;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            // 
            // lblLieu
            // 
            this.lblLieu.AutoSize = true;
            this.lblLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLieu.Location = new System.Drawing.Point(12, 175);
            this.lblLieu.Name = "lblLieu";
            this.lblLieu.Size = new System.Drawing.Size(33, 16);
            this.lblLieu.TabIndex = 16;
            this.lblLieu.Text = "Lieu";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(12, 268);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 16);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // lblTéléphone
            // 
            this.lblTéléphone.AutoSize = true;
            this.lblTéléphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTéléphone.Location = new System.Drawing.Point(12, 224);
            this.lblTéléphone.Name = "lblTéléphone";
            this.lblTéléphone.Size = new System.Drawing.Size(74, 16);
            this.lblTéléphone.TabIndex = 19;
            this.lblTéléphone.Text = "Téléphone";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(144, 268);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 18;
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentification.Location = new System.Drawing.Point(12, 317);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(82, 16);
            this.lblIdentification.TabIndex = 21;
            this.lblIdentification.Text = "Identification";
            // 
            // txtIdentification
            // 
            this.txtIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentification.Location = new System.Drawing.Point(144, 311);
            this.txtIdentification.Name = "txtIdentification";
            this.txtIdentification.Size = new System.Drawing.Size(245, 22);
            this.txtIdentification.TabIndex = 20;
            // 
            // btnImprimer
            // 
            this.btnImprimer.BackColor = System.Drawing.Color.White;
            this.btnImprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimer.ForeColor = System.Drawing.Color.Black;
            this.btnImprimer.Location = new System.Drawing.Point(537, 405);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(128, 33);
            this.btnImprimer.TabIndex = 23;
            this.btnImprimer.Text = "Imprimer";
            this.btnImprimer.UseVisualStyleBackColor = false;
            // 
            // pBoxEtudiant
            // 
            this.pBoxEtudiant.Location = new System.Drawing.Point(441, 33);
            this.pBoxEtudiant.Name = "pBoxEtudiant";
            this.pBoxEtudiant.Size = new System.Drawing.Size(224, 133);
            this.pBoxEtudiant.TabIndex = 25;
            this.pBoxEtudiant.TabStop = false;
            this.pBoxEtudiant.Click += new System.EventHandler(this.pBoxEtudiant_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 23);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // txtEtudiantQR
            // 
            this.txtEtudiantQR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtudiantQR.Location = new System.Drawing.Point(441, 246);
            this.txtEtudiantQR.Name = "txtEtudiantQR";
            this.txtEtudiantQR.Size = new System.Drawing.Size(224, 22);
            this.txtEtudiantQR.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Code de l\'etudiant";
            // 
            // FormEtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEtudiantQR);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pBoxEtudiant);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.lblIdentification);
            this.Controls.Add(this.txtIdentification);
            this.Controls.Add(this.lblTéléphone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLieu);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnModifie);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLieu);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtNom);
            this.Name = "FormEtudiant";
            this.Text = "FormEtudiant";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLieu;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifie;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblLieu;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTéléphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.TextBox txtIdentification;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.PictureBox pBoxEtudiant;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEtudiantQR;
        private System.Windows.Forms.Label label1;
    }
}

