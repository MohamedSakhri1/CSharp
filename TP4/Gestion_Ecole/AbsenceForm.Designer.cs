namespace Gestion_Ecole
{
    partial class AbsenceForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEnregister = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textTotalAbs = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.inputNumSem = new System.Windows.Forms.NumericUpDown();
            this.inputNbrAbs = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumSem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNbrAbs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre d\'absence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numéro du Semaine";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total des absences";
            // 
            // buttonEnregister
            // 
            this.buttonEnregister.Location = new System.Drawing.Point(44, 165);
            this.buttonEnregister.Name = "buttonEnregister";
            this.buttonEnregister.Size = new System.Drawing.Size(108, 33);
            this.buttonEnregister.TabIndex = 5;
            this.buttonEnregister.Text = "Enregister";
            this.buttonEnregister.UseVisualStyleBackColor = true;
            this.buttonEnregister.Click += new System.EventHandler(this.handleEnregistrer);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.Location = new System.Drawing.Point(202, 165);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(108, 33);
            this.buttonAnnuler.TabIndex = 6;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = true;
            this.buttonAnnuler.Click += new System.EventHandler(this.handleAnnuler);
            // 
            // textTotalAbs
            // 
            this.textTotalAbs.Enabled = false;
            this.textTotalAbs.Location = new System.Drawing.Point(44, 264);
            this.textTotalAbs.Name = "textTotalAbs";
            this.textTotalAbs.Size = new System.Drawing.Size(174, 22);
            this.textTotalAbs.TabIndex = 7;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.ForeColor = System.Drawing.Color.Red;
            this.status.Location = new System.Drawing.Point(41, 305);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 16);
            this.status.TabIndex = 8;
            this.status.Text = "Status";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(41, 23);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(102, 16);
            this.title.TabIndex = 9;
            this.title.Text = "Absences de ";
            // 
            // inputNumSem
            // 
            this.inputNumSem.Location = new System.Drawing.Point(190, 107);
            this.inputNumSem.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.inputNumSem.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNumSem.Name = "inputNumSem";
            this.inputNumSem.Size = new System.Drawing.Size(120, 22);
            this.inputNumSem.TabIndex = 10;
            this.inputNumSem.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // inputNbrAbs
            // 
            this.inputNbrAbs.Location = new System.Drawing.Point(190, 65);
            this.inputNbrAbs.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.inputNbrAbs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputNbrAbs.Name = "inputNbrAbs";
            this.inputNbrAbs.Size = new System.Drawing.Size(120, 22);
            this.inputNbrAbs.TabIndex = 11;
            this.inputNbrAbs.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AbsenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(355, 347);
            this.Controls.Add(this.inputNbrAbs);
            this.Controls.Add(this.inputNumSem);
            this.Controls.Add(this.title);
            this.Controls.Add(this.status);
            this.Controls.Add(this.textTotalAbs);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonEnregister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AbsenceForm";
            this.Text = "Absence";
            ((System.ComponentModel.ISupportInitialize)(this.inputNumSem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputNbrAbs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEnregister;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textTotalAbs;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown inputNumSem;
        private System.Windows.Forms.NumericUpDown inputNbrAbs;
    }
}