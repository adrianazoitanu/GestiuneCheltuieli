using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
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
            adminUtilizatori = StocareFactory.GetAdministratorStocare();
            ResetareControale();
        }
       
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

                //ut.Cheltuieli = new ArrayList();
               // ut.Cheltuieli.AddRange(cheltuieliselectate);

                adminUtilizatori.AddUtilizator(ut);
                lblMesaj.Text = "Utilizatorul a fost adaugat";
                ResetareControale();
               
                lstbxAfis.Items.Clear();
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
            
            
            lblMesaj.Text = string.Empty;
        }
       
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            
            DateTime dataactualizata=DateTime.Now;
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            lstbxAfis.Items.Clear();

                        var antet = String.Format("{0,-5} {1,1} {2,8} {3,10} {4,12} {5,13} {6,16}\n", "Id ", " Nume", "Prenume "," Venit", "Economii", "Cheltuieli", "Valuta");
            bool ok = false;
            
            lstbxAfis.Items.Add(antet);
            if (Validlog())
            {
                foreach (Utilizator ut1 in ut)
                {
                     
                    if (txtParola.Text == ut1.Parola && txtNume.Text == ut1.Nume && txtPrenume.Text == ut1.Prenume)
                    {
                         
                            var linie = String.Format("{0,-5}{1,13}{2,33}{3,27}", ut1.IdUtilizator,ut1.NumeComplet,ut1.afisInfo(),ut1.Bancn.ToString());

                            lstbxAfis.Items.Add(linie);
                            ok = true;
                        
                    }


                }

                if (ok == false)
                    MessageBox.Show("Utilizator inexistent");
            }


            //ResetareControale();


        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            ResetareControale();
            lstbxAfis.Items.Clear();
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
             
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            foreach (Utilizator ut1 in ut)
                if (ut1.Nume == txtNume.Text && ut1.Prenume == txtPrenume.Text)
                {
                    MessageBox.Show("Utilizator Gasit");
                    var linie = String.Format("{0,5}{1,25}\n", ut1.IdUtilizator, ut1.NumeComplet);
                     
                    lstbxAfis.Items.Add(linie);
                    n = 0;
                }
            if(n==-1)
                 MessageBox.Show("Utilizatorul nu a fost gasit");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            lstbxAfis.Items.Clear();
            
            string inf = string.Empty;
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            foreach (Utilizator ut1 in ut)
            {
                if (ut1.Nume == txtNume.Text)
                {
                    ut1.Nume = txtNume.Text;
                    ut1.Prenume = txtPrenume.Text;
                    ut1.Parola = txtPrenume.Text;
                    inf +=Convert.ToString(Convert.ToDouble(txtVenit.Text)+Convert.ToDouble(ut1.Venit()));
                    inf += " ";
                    inf += Convert.ToString(Convert.ToDouble(txtEconomii.Text) + Convert.ToDouble(ut1.Econom()));
                    inf += " ";
                    inf += Convert.ToString(Convert.ToDouble(ut1.Chelt()) - Convert.ToDouble(txtCheltuieli.Text));
                    ut1.SetInfo(inf);
                    Bancnota? bancSelectata = GetBancnotaSelectata();
                    if (bancSelectata.HasValue)
                    {
                        ut1.Bancn = bancSelectata.Value;
                    }
                    adminUtilizatori.AddUtilizator(ut1);
                 
                }
            }
            ResetareControale();
        }
        private bool Validlog()
        {
            bool ok = true;
            if (txtPrenume.Text == string.Empty || !(Char.IsLetter(txtPrenume.Text[0]))) 
            {
                MessageBox.Show("Introduceti prenumele pentru a intra in cont");
                ok = false;
            }
            if (txtNume.Text == string.Empty || !(Char.IsLetter(txtNume.Text[0])))
            {
                MessageBox.Show("Introduceti numele pentru a intra in cont");
                ok = false;
            }
            if (txtParola.Text == string.Empty)
            {
                MessageBox.Show("Introduceti parola pentru a intra in cont");
                ok = false;
            }
            return ok;
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
         
                return ok;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ArrayList ut = adminUtilizatori.GetUtilizatori();

              
        }

        private void varstaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxAfis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa iesiti?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                Application.Exit();

            }
        }

        private void Interfata_Load(object sender, EventArgs e)
        {

        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
