using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXO3
{
    public partial class Form1 : Form
    {
        private CalculatorUtils calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new CalculatorUtils();
            labelAlert.Text = "";
        }

        private void txtBox_onChange(object sender, EventArgs e)
        {
            string contenu = txtBox1.Text;
            labelAlert.Text = "";

            try {
                int nbrCoupie = int.Parse(contenu);
                if (nbrCoupie < 0 )
                    throw new Exception("entier négative");

                button1.Enabled = true;

            } catch (Exception ex) {
                labelAlert.Text = "Juste les nombre entier !";
                button1.Enabled = false;
            }
        }

        private void txtBox2_onChange(object sender, EventArgs e)
        {

        }

        private void button_handle_click(object sender, EventArgs e)
        {
            double prixTotal = 0;
            int nbrCoupies = int.Parse(txtBox1.Text);

            prixTotal = calculator.CalculerPrixAvecRemises(nbrCoupies);

            txtBox2.Text = prixTotal.ToString();

        }
    }
}
