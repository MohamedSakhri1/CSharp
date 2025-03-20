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
    public partial class Form1 : Form
    {
        // BindingList pour stocker les étudiants
        private BindingList<Eleve> etudiants = new BindingList<Eleve>();
        private DAO<Eleve> eleveDAO = new DAO<Eleve> ();

        public Form1()
        {
            InitializeComponent();
            refreshTable();

            // status
            status.Text = string.Empty;
        }

        private void handleAjouter(object sender, EventArgs e)
        {
            try
            {
                Eleve eleve = new Eleve(
                    1,
                    inputNom.Text,
                    inputPrenom.Text,
                    inputVille.Text,
                    inputSpecialite.Text,
                    int.Parse(inputGroupe.Text)
                );

                eleveDAO.insert(eleve);
                refreshTable();
            }
            catch (Exception ex)
            {
                setErrorMessage(ex.Message);
            }
        }

        private void handleModifier(object sender, EventArgs e)
        {
            try
            {
                if (table.SelectedRows.Count > 0)
                {
                    // Récupérer la première ligne sélectionnée
                    DataGridViewRow selectedRow = table.SelectedRows[0];

                    int selectedId = int.Parse(selectedRow.Cells["id"].Value.ToString());

                    Form modificationFrom = new ModifierForm(selectedId);
                    modificationFrom.ShowDialog();

                    refreshTable();
                }
            }
            catch (Exception ex)
            {
                setErrorMessage(ex.Message);
            }
        }

        private void handleSupprimer(object sender, EventArgs e)
        {
            try { 
                if (table.SelectedRows.Count > 0)
                {
                    // Récupérer la première ligne sélectionnée
                    DataGridViewRow selectedRow = table.SelectedRows[0];

                    int selectedId = int.Parse(selectedRow.Cells["id"].Value.ToString());

                    eleveDAO.delete(selectedId);

                    refreshTable();
                }
            } catch (Exception ex)
            {
                setErrorMessage(ex.Message);
            }
        }

        private void handleGestion(object sender, EventArgs e)
        {
            
                if (table.SelectedRows.Count > 0)
                {
                    // Récupérer la première ligne sélectionnée
                    DataGridViewRow selectedRow = table.SelectedRows[0];

                    int selectedId = int.Parse(selectedRow.Cells["id"].Value.ToString());

                    Form midificationAbsence = new AbsenceForm(selectedId);
                    midificationAbsence.ShowDialog();
                }
            
        }

        private void inputGroupe_TextChanged(object sender, EventArgs e)
        {

        }


        private void refreshTable()
        {
            table.DataSource = null;
            table.DataSource = eleveDAO.findAll();
        }

        private void renetializeInputs(object sender = null, EventArgs e = null)
        {
            inputNom.Text = string.Empty;
            inputGroupe.Text = string.Empty;
            inputPrenom.Text = string.Empty;
            inputSpecialite.Text = string.Empty;
            inputVille.Text = string.Empty;

            status.Text = string.Empty;
        }

        private void setErrorMessage(string message)
        {
            status.Text = message;
            Timer timer = new Timer();
            timer.Interval = 2500;
            timer.Tick += renetializeInputs;
            timer.Start();
        }

        private void handleRechercher(object sender, EventArgs e)
        {
            Eleve eleve = new Eleve(
                    0,
                    inputNom.Text,
                    inputPrenom.Text,
                    inputVille.Text,
                    inputSpecialite.Text
            );
            if ( ! inputGroupe.Text.Equals("") )
                eleve.Groupe = int.Parse(inputGroupe.Text);

            table.DataSource = null;
            table.DataSource = eleveDAO.find(eleve);
        }
    }
}
