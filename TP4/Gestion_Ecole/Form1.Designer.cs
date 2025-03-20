namespace Gestion_Ecole
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNom = new System.Windows.Forms.TextBox();
            this.inputPrenom = new System.Windows.Forms.TextBox();
            this.inputVille = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonGestion = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.Label();
            this.inputSpecialite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputGroupe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ville";
            // 
            // inputNom
            // 
            this.inputNom.Location = new System.Drawing.Point(189, 102);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(339, 22);
            this.inputNom.TabIndex = 6;
            // 
            // inputPrenom
            // 
            this.inputPrenom.Location = new System.Drawing.Point(189, 145);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(339, 22);
            this.inputPrenom.TabIndex = 7;
            // 
            // inputVille
            // 
            this.inputVille.Location = new System.Drawing.Point(189, 188);
            this.inputVille.Name = "inputVille";
            this.inputVille.Size = new System.Drawing.Size(339, 22);
            this.inputVille.TabIndex = 8;
            this.inputVille.TextChanged += new System.EventHandler(this.inputGroupe_TextChanged);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(608, 99);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(194, 29);
            this.buttonAjouter.TabIndex = 9;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.handleAjouter);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(608, 139);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(194, 29);
            this.buttonModifier.TabIndex = 10;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.handleModifier);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(608, 182);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(194, 29);
            this.buttonSupprimer.TabIndex = 11;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.handleSupprimer);
            // 
            // buttonGestion
            // 
            this.buttonGestion.Location = new System.Drawing.Point(608, 269);
            this.buttonGestion.Name = "buttonGestion";
            this.buttonGestion.Size = new System.Drawing.Size(194, 29);
            this.buttonGestion.TabIndex = 12;
            this.buttonGestion.Text = "Gestion d\'absences";
            this.buttonGestion.UseVisualStyleBackColor = true;
            this.buttonGestion.Click += new System.EventHandler(this.handleGestion);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Location = new System.Drawing.Point(56, 344);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.RowTemplate.Height = 24;
            this.table.Size = new System.Drawing.Size(871, 215);
            this.table.TabIndex = 13;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Firebrick;
            this.status.Location = new System.Drawing.Point(54, 589);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(60, 22);
            this.status.TabIndex = 14;
            this.status.Text = "Status";
            // 
            // inputSpecialite
            // 
            this.inputSpecialite.Location = new System.Drawing.Point(189, 234);
            this.inputSpecialite.Name = "inputSpecialite";
            this.inputSpecialite.Size = new System.Drawing.Size(339, 22);
            this.inputSpecialite.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Specialiste";
            // 
            // inputGroupe
            // 
            this.inputGroupe.Location = new System.Drawing.Point(189, 279);
            this.inputGroupe.Name = "inputGroupe";
            this.inputGroupe.Size = new System.Drawing.Size(339, 22);
            this.inputGroupe.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Groupe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "Dashboard de Gestion d\'absence";
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(608, 224);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(194, 29);
            this.buttonRechercher.TabIndex = 20;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.handleRechercher);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 648);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputGroupe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputSpecialite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.status);
            this.Controls.Add(this.table);
            this.Controls.Add(this.buttonGestion);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.inputVille);
            this.Controls.Add(this.inputPrenom);
            this.Controls.Add(this.inputNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Gestion d\'Ecole";
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNom;
        private System.Windows.Forms.TextBox inputPrenom;
        private System.Windows.Forms.TextBox inputVille;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonGestion;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox inputSpecialite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputGroupe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRechercher;
    }
}

