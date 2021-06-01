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
            bool ok = false;
            ArrayList ut = adminUtilizatori.GetUtilizatori();
            if (Validlog())
            {
                foreach (Utilizator ut1 in ut)
                {

                    if (txtParola.Text == ut1.Parola && txtNume.Text == ut1.Nume && txtPrenume.Text == ut1.Prenume)
                    {

                        using (Logare form = new Logare(ut1))
                        {
                            form.ShowDialog();
                           
                        }
                        ok = true;

                    }


                }

                if (ok == false)
                    MessageBox.Show("Utilizator inexistent");

           

            }

        }
        private void btnCauta_Click(object sender, EventArgs e)
        {
            ResetareControale();
            //lstbxAfis.Items.Clear();
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
                     
                    //lstbxAfis.Items.Add(linie);
                    n = 0;
                }
            if(n==-1)
                 MessageBox.Show("Utilizatorul nu a fost gasit");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            //lstbxAfis.Items.Clear();
            
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
            if (txtNume.Text == string.Empty || !(Char.IsLetter(txtNume.Text[0])))
            {
                MessageBox.Show("Nu ati introdus numele");
               
                ok = false;
            }
          
           
            
            if (txtPrenume.Text == string.Empty || !(Char.IsLetter(txtPrenume.Text[0])))
            {
                MessageBox.Show("Nu ati introdus prenumele");
          
                ok = false;
            }
            double val = 0;
            if (txtEconomii.Text == string.Empty ||!double.TryParse(txtEconomii.Text,out val) )
            {
                MessageBox.Show("Nu ati introdus economiile");
              
                ok = false;
            }
          
            if (txtVenit.Text == string.Empty || !double.TryParse(txtVenit.Text, out val))
            {
                MessageBox.Show("Nu ati introdus venitul");
   
                ok = false;
            }
           
            if (txtCheltuieli.Text == string.Empty|| !double.TryParse(txtCheltuieli.Text, out val))
            {
                MessageBox.Show("Nu ati introdus cheltuielile");
               
                ok = false;
            }
          
            if (txtParola.Text == string.Empty)
            {
                MessageBox.Show("Nu ati introdus parola");
                
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

        private void btnAdauga_Click_1(object sender, EventArgs e)
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
 
                adminUtilizatori.AddUtilizator(ut);
                lblMesaj.Text = "Utilizatorul a fost adaugat";
                using (Logare form1 = new Logare(ut))
                {
                    form1.ShowDialog();
                }
                ResetareControale();

                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
