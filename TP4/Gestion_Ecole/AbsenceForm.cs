using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_Ecole.Dao;
using Gestion_Ecole.Entities;

namespace Gestion_Ecole
{
    public partial class AbsenceForm : Form
    {

        private Eleve eleve;
        private Absence absence;
        private static DAO<Eleve> eleveDao = new DAO<Eleve>();
        private static AbsenceDAO absenceDao = new AbsenceDAO();

        public AbsenceForm(int eleveId)
        {
            eleve = eleveDao.findById(eleveId);
            absence = new Absence(eleve.Id);
            InitializeComponent();

            title.Text += $"{eleve.Nom} {eleve.Prenom}.";
            status.Text = string.Empty;

            refreshTotalAbs();
        }

        private void handleEnregistrer(object sender, EventArgs e)
        {
            absence.Nbr_Absences = int.Parse(inputNbrAbs.Value.ToString());
            absence.Numero_Semaine = int.Parse(inputNumSem.Value.ToString());

            absenceDao.insert(absence);
            refreshTotalAbs();

        }

        private void handleAnnuler(object sender, EventArgs e)
        {
            this.Close();
        }


        private void refreshTotalAbs()
        {
            textTotalAbs.Text = string.Empty;

            var totalAbs = absenceDao.getEleveTotalAbs(eleve);
            textTotalAbs.Text = totalAbs.ToString();
        }

    }
}
