using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO4
{
    public partial class Form1 : Form
    {
        private Classe classe;
        private string noteEtudiantBase = "Note d'étudiant ";
        public Form1()
        {
            InitializeComponent();
            txtAlerts.Text = string.Empty;
        }

        private void handleButtonClick(object sender, EventArgs e)
        {
            int nextStudentIndex = classe.Etudiants.Count + 2;
            try
            {
                double note = castInputToDouble(inputNoteEtud.Text);
                classe.Ajouter(note);


                if (classe.isFull())
                {
                    inputNoteMin.Text = classe.NoteMin().ToString();
                    inputNoteMax.Text = classe.NoteMax().ToString();
                    inputNoteMoy.Text = classe.NoteMoyenne().ToString();
                }
                else
                {
                    txtNumEtud.Text = noteEtudiantBase + nextStudentIndex;
                }
            }
            catch (Exception ex)
            {
                txtAlerts.Text = ex.Message;
            }
        }

        private void ValidateNbrEtudiant(object sender, EventArgs e)
        {
            txtAlerts.Text = string.Empty;
        }

        private void ValidateNoteEtud(object sender, EventArgs e)
        {
            txtAlerts.Text = string.Empty;
        }

        private void handleValider(object sender, EventArgs e)
        {
            try
            {
                int classeTalle = castInputToInt(inputNbrEtud.Text);

                classe = new Classe(classeTalle);

                inputNoteEtud.Enabled = true;
                txtNumEtud.Text = noteEtudiantBase + 1;

                inputNbrEtud.Enabled = false;
                button1.Enabled = false;

            }
            catch (Exception ex) { 
                txtAlerts.Text = ex.Message;
            }

        }

        private double castInputToDouble(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("Chaîne vide !");
            try
            {
                double castResult = Convert.ToDouble(text);
                return castResult;
            }
            catch
            {
                throw new Exception("Entrer un nombre valide !");
            }
        }

        private int castInputToInt(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new Exception("Chaîne vide !");
            try
            {
                int castResult = Convert.ToInt32(text);
                return castResult;
            }
            catch
            {
                throw new Exception("Entrer un nombre valide !");
            }
        }
    }
}
