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
    public partial class ModifierForm : Form
    {
        private Eleve eleve;
        private static DAO<Eleve> eleveDao = new DAO<Eleve>();


        public ModifierForm(int eleveId)
        {
            eleve = eleveDao.findById(eleveId);
            InitializeComponent();

            title.Text += eleveId;
            handleRenitialiser();
        }

        private void handleRenitialiser(object sender = null, EventArgs e = null)
        {
            if (eleve != null)
            {
                textNom.Text = eleve.Nom;
                textPrenom.Text = eleve.Prenom;
                textSpecialiste.Text = eleve.Specialite;
                textVille.Text = eleve.Ville;
                textGroupe.Value = eleve.Groupe;
            }

            status.Text = string.Empty;

        }

        private void handleAnnuler(object sender = null, EventArgs e = null)
        {
            this.Close();
        }

        private void handleModifier(object sender, EventArgs e)
        {
            status.Text = string.Empty;

            eleve.Nom = textNom.Text.Trim();
            eleve.Prenom = textPrenom.Text.Trim();
            eleve.Specialite = textSpecialiste.Text.Trim();
            eleve.Ville = textVille.Text.Trim();
            eleve.Groupe = int.Parse(textGroupe.Value.ToString());

            try
            {
                eleveDao.update(eleve);
                this.Close();
            }
            catch (Exception ex)
            {
                status.Text = ex.Message;
            }
        }
    }
}
