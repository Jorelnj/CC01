namespace CC01.WinForms
{
    partial class FormEcole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEcole));
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnModifie = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            this.txtNomEcole = new System.Windows.Forms.TextBox();
            this.lblNomEcole = new System.Windows.Forms.Label();
            this.lblFiliere = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRechercher
            // 
            this.btnRechercher.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.ForeColor = System.Drawing.Color.White;
            this.btnRechercher.Location = new System.Drawing.Point(389, 391);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(128, 33);
            this.btnRechercher.TabIndex = 18;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = false;
            // 
            // btnModifie
            // 
            this.btnModifie.BackColor = System.Drawing.Color.MediumPurple;
            this.btnModifie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifie.ForeColor = System.Drawing.Color.White;
            this.btnModifie.Location = new System.Drawing.Point(240, 391);
            this.btnModifie.Name = "btnModifie";
            this.btnModifie.Size = new System.Drawing.Size(90, 33);
            this.btnModifie.TabIndex = 17;
            this.btnModifie.Text = "Modifier";
            this.btnModifie.UseVisualStyleBackColor = false;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(576, 391);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(128, 33);
            this.btnSupprimer.TabIndex = 16;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnCreer
            // 
            this.btnCreer.BackColor = System.Drawing.Color.Lime;
            this.btnCreer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreer.ForeColor = System.Drawing.Color.White;
            this.btnCreer.Location = new System.Drawing.Point(91, 391);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(90, 33);
            this.btnCreer.TabIndex = 15;
            this.btnCreer.Text = "Créer";
            this.btnCreer.UseVisualStyleBackColor = false;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // txtNomEcole
            // 
            this.txtNomEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomEcole.Location = new System.Drawing.Point(136, 213);
            this.txtNomEcole.Name = "txtNomEcole";
            this.txtNomEcole.Size = new System.Drawing.Size(300, 22);
            this.txtNomEcole.TabIndex = 19;
            // 
            // lblNomEcole
            // 
            this.lblNomEcole.AutoSize = true;
            this.lblNomEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEcole.Location = new System.Drawing.Point(9, 219);
            this.lblNomEcole.Name = "lblNomEcole";
            this.lblNomEcole.Size = new System.Drawing.Size(99, 16);
            this.lblNomEcole.TabIndex = 20;
            this.lblNomEcole.Text = "Nom de l\'ecole";
            // 
            // lblFiliere
            // 
            this.lblFiliere.AutoSize = true;
            this.lblFiliere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiliere.Location = new System.Drawing.Point(9, 245);
            this.lblFiliere.Name = "lblFiliere";
            this.lblFiliere.Size = new System.Drawing.Size(45, 16);
            this.lblFiliere.TabIndex = 22;
            this.lblFiliere.Text = "Filière";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(136, 245);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 22);
            this.textBox1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Année académque";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(136, 281);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(300, 22);
            this.textBox2.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // FormEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblFiliere);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNomEcole);
            this.Controls.Add(this.txtNomEcole);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.btnModifie);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnCreer);
            this.Name = "FormEcole";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Button btnModifie;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.TextBox txtNomEcole;
        private System.Windows.Forms.Label lblNomEcole;
        private System.Windows.Forms.Label lblFiliere;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}