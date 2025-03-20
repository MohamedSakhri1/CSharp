namespace Gestion_Ecole
{
    partial class ModifierForm
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
            this.title = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.textVille = new System.Windows.Forms.TextBox();
            this.textSpecialiste = new System.Windows.Forms.TextBox();
            this.buttonRenitialiser = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.textGroupe = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textGroupe)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(40, 21);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(207, 22);
            this.title.TabIndex = 0;
            this.title.Text = "Modification d\'eleve Id = ";
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(29, 72);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(36, 16);
            this.nom.TabIndex = 1;
            this.nom.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Specialiste";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Groupe";
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(149, 69);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(152, 22);
            this.textNom.TabIndex = 6;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(149, 107);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(152, 22);
            this.textPrenom.TabIndex = 7;
            // 
            // textVille
            // 
            this.textVille.Location = new System.Drawing.Point(149, 141);
            this.textVille.Name = "textVille";
            this.textVille.Size = new System.Drawing.Size(152, 22);
            this.textVille.TabIndex = 8;
            // 
            // textSpecialiste
            // 
            this.textSpecialiste.Location = new System.Drawing.Point(149, 179);
            this.textSpecialiste.Name = "textSpecialiste";
            this.textSpecialiste.Size = new System.Drawing.Size(152, 22);
            this.textSpecialiste.TabIndex = 9;
            // 
            // buttonRenitialiser
            // 
            this.buttonRenitialiser.Location = new System.Drawing.Point(24, 281);
            this.buttonRenitialiser.Name = "buttonRenitialiser";
            this.buttonRenitialiser.Size = new System.Drawing.Size(121, 31);
            this.buttonRenitialiser.TabIndex = 11;
            this.buttonRenitialiser.Text = "Renitialiser";
            this.buttonRenitialiser.UseVisualStyleBackColor = true;
            this.buttonRenitialiser.Click += new System.EventHandler(this.handleRenitialiser);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(193, 281);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(121, 31);
            this.buttonAnnuler.TabIndex = 12;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.handleAnnuler);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(24, 333);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(290, 31);
            this.buttonModifier.TabIndex = 13;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.handleModifier);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(28, 387);
            this.status.MaximumSize = new System.Drawing.Size(290, 19);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(53, 19);
            this.status.TabIndex = 14;
            this.status.Text = "Status";
            // 
            // textGroupe
            // 
            this.textGroupe.Location = new System.Drawing.Point(149, 215);
            this.textGroupe.Name = "textGroupe";
            this.textGroupe.Size = new System.Drawing.Size(152, 22);
            this.textGroupe.TabIndex = 15;
            // 
            // ModifierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.textGroupe);
            this.Controls.Add(this.status);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonRenitialiser);
            this.Controls.Add(this.textSpecialiste);
            this.Controls.Add(this.textVille);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.title);
            this.Name = "ModifierForm";
            this.Text = "Modification";
            ((System.ComponentModel.ISupportInitialize)(this.textGroupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox textVille;
        private System.Windows.Forms.TextBox textSpecialiste;
        private System.Windows.Forms.Button buttonRenitialiser;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.NumericUpDown textGroupe;
    }
}