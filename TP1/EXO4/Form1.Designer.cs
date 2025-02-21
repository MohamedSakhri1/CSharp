namespace EXO4
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
            this.inputNbrEtud = new System.Windows.Forms.TextBox();
            this.inputNoteEtud = new System.Windows.Forms.TextBox();
            this.inputNoteMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumEtud = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNoteMoy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputNoteMax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAlerts = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNbrEtud
            // 
            this.inputNbrEtud.Location = new System.Drawing.Point(217, 33);
            this.inputNbrEtud.Name = "inputNbrEtud";
            this.inputNbrEtud.Size = new System.Drawing.Size(100, 22);
            this.inputNbrEtud.TabIndex = 0;
            this.inputNbrEtud.TextChanged += new System.EventHandler(this.ValidateNbrEtudiant);
            // 
            // inputNoteEtud
            // 
            this.inputNoteEtud.Location = new System.Drawing.Point(217, 74);
            this.inputNoteEtud.Name = "inputNoteEtud";
            this.inputNoteEtud.Size = new System.Drawing.Size(100, 22);
            this.inputNoteEtud.TabIndex = 1;
            this.inputNoteEtud.TextChanged += new System.EventHandler(this.ValidateNoteEtud);
            // 
            // inputNoteMin
            // 
            this.inputNoteMin.Enabled = false;
            this.inputNoteMin.Location = new System.Drawing.Point(12, 169);
            this.inputNoteMin.Name = "inputNoteMin";
            this.inputNoteMin.Size = new System.Drawing.Size(100, 22);
            this.inputNoteMin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre d\'étudiants";
            // 
            // txtNumEtud
            // 
            this.txtNumEtud.AutoSize = true;
            this.txtNumEtud.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumEtud.Location = new System.Drawing.Point(12, 75);
            this.txtNumEtud.Name = "txtNumEtud";
            this.txtNumEtud.Size = new System.Drawing.Size(142, 18);
            this.txtNumEtud.TabIndex = 2;
            this.txtNumEtud.Text = "Note d\'étudiant Num";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Note Min";
            // 
            // inputNoteMoy
            // 
            this.inputNoteMoy.Enabled = false;
            this.inputNoteMoy.Location = new System.Drawing.Point(273, 169);
            this.inputNoteMoy.Name = "inputNoteMoy";
            this.inputNoteMoy.Size = new System.Drawing.Size(100, 22);
            this.inputNoteMoy.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "La moyenne";
            // 
            // inputNoteMax
            // 
            this.inputNoteMax.Enabled = false;
            this.inputNoteMax.Location = new System.Drawing.Point(139, 169);
            this.inputNoteMax.Name = "inputNoteMax";
            this.inputNoteMax.Size = new System.Drawing.Size(100, 22);
            this.inputNoteMax.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Note Max";
            // 
            // txtAlerts
            // 
            this.txtAlerts.AutoSize = true;
            this.txtAlerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlerts.ForeColor = System.Drawing.Color.Red;
            this.txtAlerts.Location = new System.Drawing.Point(12, 212);
            this.txtAlerts.Name = "txtAlerts";
            this.txtAlerts.Size = new System.Drawing.Size(45, 18);
            this.txtAlerts.TabIndex = 2;
            this.txtAlerts.Text = "Alerts";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(332, 72);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 26);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.handleButtonClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.handleValider);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(458, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlerts);
            this.Controls.Add(this.txtNumEtud);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNoteMax);
            this.Controls.Add(this.inputNoteMoy);
            this.Controls.Add(this.inputNoteMin);
            this.Controls.Add(this.inputNoteEtud);
            this.Controls.Add(this.inputNbrEtud);
            this.Name = "Form1";
            this.Text = "Gestion des notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputNbrEtud;
        private System.Windows.Forms.TextBox inputNoteEtud;
        private System.Windows.Forms.TextBox inputNoteMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtNumEtud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNoteMoy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputNoteMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtAlerts;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
    }
}

