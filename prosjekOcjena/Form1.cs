using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prosjekOcjena
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double brojac, ocjene = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UnosButun_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Unos.Text) < 1 || Convert.ToInt32(Unos.Text) > 5)
                {
                    MessageBox.Show("Niste upisali broj od 1 do 5", "Greška");
                }
                else
                {
                    brojac++;
                    ocjene += Convert.ToInt32(Unos.Text);
                    Ispis.AppendText(ocjene + "\r\n");
                }
                DialogResult odgovor = MessageBox.Show("Želite li unesti novu ocjenu?", "Izbor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (odgovor == DialogResult.Yes)
                {
                    Unos.Clear();
                }
                else
                {
                    Ispis.Text = "Prosjek ocjena je = " + (ocjene / brojac);
                }
            }
            catch (Exception Pogreska)
            {
                MessageBox.Show("Niste upisali broj", "Greška");
            }
        }
    }
}
