using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using Librarie;

namespace GestiuneCheltuieli
{
    
    public partial class Interfata : Form
    {
        IStocareData adminUtilizatori;
        ArrayList cheltuieliselectate=new ArrayList();

        public Interfata()
        {
            InitializeComponent();
            adminUtilizatori = StocareFactory.GetAdministratorStocare();        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                Utilizator ut = new Utilizator(txtNume.Text, txtPrenume.Text, txtParola.Text);
                string inf = string.Empty;
                inf += txtVenit.Text;
                inf += " ";
                inf += txtEconomii.Text;
                inf += " ";
                inf += txtCheltuieli.Text;
                ut.SetInfo(inf);

                Bancnota? bancSelectata = GetBancnotaSelectata();
                if (bancSelectata.HasValue)
                {
                    ut.Bancn = bancSelectata.Value;
                }

                ut.Cheltuieli = new ArrayList();
                ut.Cheltuieli.AddRange(cheltuieliselectate);
                adminUtilizatori.AddUtilizator(ut);
                lblMesaj.Text = "Utilizatorul a fost adaugat";
                ResetareControale();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private Bancnota? GetBancnotaSelectata()
        {
            if (rtbEuro.Checked)
                return Bancnota.Euro;
            if (rtbDolar.Checked)
                return Bancnota.Dolari;
            if (rtbLei.Checked)
                return Bancnota.Lei;
            return null;
        }
        private void ResetareControale()
        {
            txtNume.Text = txtParola.Text = txtPrenume.Text = txtEconomii.Text = txtCheltuieli.Text = txtVenit.Text = string.Empty;
            rtbEuro.Checked = false;
            rtbDolar.Checked = false;
            rtbLei.Checked = false;
            cbxIesiri.Checked = false;
            cbxHaine.Checked = false;
            cbxCosmetice.Checked = false;
            cbxCadouri.Checked = false;
            cbxAnimal.Checked = false;
            lblMesaj.Text = string.Empty;
        }

        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            rtbAfisare.Clear();
            var antet = String.Format("{0,-5}{1,-35}\n", "Id", "Nume Prenume");
            rtbAfisare.AppendText(antet);
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            foreach (Utilizator ut1 in ut)
            {
                var linie = String.Format("{0,5}{1,25}\n",ut1.IdUtilizator,ut1.NumeComplet);
                rtbAfisare.AppendText(linie);
            }
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
           
            int n = -1;
            if(txtNume.Text==string.Empty)
            {
                MessageBox.Show("Nu ai introdus numele");
                txtNume.BackColor = Color.Red;
            }
            if (txtPrenume.Text == string.Empty)
            {
                MessageBox.Show("Nu ai introdus prenumele");
                txtPrenume.BackColor = Color.Red;
            }
            rtbAfisare.Clear();
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            foreach (Utilizator ut1 in ut)
                if (ut1.Nume == txtNume.Text && ut1.Prenume == txtPrenume.Text)
                {
                    MessageBox.Show("Utilizator Gasit");
                    var linie = String.Format("{0,5}{1,25}\n", ut1.IdUtilizator, ut1.NumeComplet);
                    rtbAfisare.AppendText(linie);
                    n = 0;
                }
            if(n==-1)
                 MessageBox.Show("Utilizatorul nu a fost gasit");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            //rtbAfisare.Clear();
            string inf = string.Empty;
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            foreach (Utilizator ut1 in ut)
            {
                if (ut1.Nume == txtNume.Text)
                {
                    ut1.Nume = txtNume.Text;
                    ut1.Prenume = txtPrenume.Text;
                    ut1.Parola = txtPrenume.Text;
                    inf += txtVenit.Text;
                    inf += " ";
                    inf += txtEconomii.Text;
                    inf += " ";
                    inf += txtCheltuieli.Text;
                    ut1.SetInfo(inf);
                    Bancnota? bancSelectata = GetBancnotaSelectata();
                    if (bancSelectata.HasValue)
                    {
                        ut1.Bancn = bancSelectata.Value;
                    }
                    adminUtilizatori.AddUtilizator(ut1);
                    ResetareControale();
                }
            }
        }
        private bool Valid()
        {
            bool ok = true;
            if (txtNume.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus numele");
                txtNume.BackColor = Color.Red;
                ok = false;
            }
           
            
            if (txtPrenume.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus prenumele");
                txtPrenume.BackColor = Color.Red;
                ok = false;
            }
            
            if (txtEconomii.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus economiile");
                txtEconomii.BackColor = Color.Red;
                ok = false;
            }
          
            if (txtVenit.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus venitul");
                txtVenit.BackColor = Color.Red;
                ok = false;
            }
           
            if (txtCheltuieli.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus cheltuielile");
                txtCheltuieli.BackColor = Color.Red;
                ok = false;
            }
          
            if (txtParola.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus parola");
                txtParola.BackColor = Color.Red;
                ok = false;
            }
       
            if (!rtbDolar.Checked && !rtbEuro.Checked && !rtbLei.Checked)
                    {
                    MessageBox.Show("Nu ati ales valuta");
                ok = false;
                    }
            if(!cbxAnimal.Checked&& !cbxCadouri.Checked && !cbxCosmetice.Checked&&!cbxHaine.Checked&&!cbxIesiri.Checked)
            {
                MessageBox.Show("Nu ati selectat Cheltuielile");
                ok = false;
            }
                return ok;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
