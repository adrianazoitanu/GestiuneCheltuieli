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
    public partial class Logare : Form
    {
        IStocareData adminUtilizatori;
        public Utilizator Inf { get; set; }
        public Logare()
        {
            InitializeComponent();
            adminUtilizatori = StocareFactory.GetAdministratorStocare();
        }

        public Logare(Utilizator ut)
        {
            InitializeComponent();
            adminUtilizatori = StocareFactory.GetAdministratorStocare();
            Inf = ut;
            Antet();
            Afis();
             
        }
        private void Logare_Load(object sender, EventArgs e)
        {
            
        }
         
       
 
        private void btnL_Click(object sender, EventArgs e)
        {
            string inf = string.Empty;
            
 
             
             
                    Inf.Nume = txtNume.Text;
                    
                    var linie = String.Format("{0,-5} {1,5} \t{2,40} {3,20}",Inf.IdUtilizator,Inf.NumeComplet, Inf.afisInfo(),Inf.Bancn);
                    lstbxAfis.Items.Add(linie);
            
            adminUtilizatori.AddUtilizator(Inf);

            Reset();
               
            
        }
        private Bancnota? GetBancnotaSelectata()
        {
            if (rtbEuro.Checked)
                return Bancnota.Euro;
            if (rtbDolari.Checked)
                return Bancnota.Dolari;
            if (rtbLei.Checked)
                return Bancnota.Lei;
            return null;
        }
        private void lblmesaj_Click(object sender, EventArgs e)
        {
            lblmesaj.Text = Inf.NumeComplet;
            lblmesaj.Text = "Adauga";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string info = string.Empty;
            info += txtVenit.Text;
            info += " ";
            info +=Inf.Econom();
            info += " ";
            info += Inf.Chelt();
            Inf.SetInfo(info);

            Afis();
            adminUtilizatori.AddUtilizator(Inf);
            Reset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrenume_Click(object sender, EventArgs e)
        {
           
            Inf.Prenume = txtPrenume.Text;


            Afis();
            adminUtilizatori.AddUtilizator(Inf);
            Reset();

        }
        private void Antet()
        {
            var antet = String.Format("{0,-5} {1,1} {2,8} {3,10} {4,12} {5,13} {6,16}\n", "Id ", " Nume", "Prenume ", " Venit", "Economii", "Cheltuieli", "Valuta");
            lstbxAfis.Items.Add(antet);
        }
        private void Afis()
        {
            

            var linie = String.Format("{0,-5} {1,5} \t{2,40} {3,20}", Inf.IdUtilizator, Inf.NumeComplet, Inf.afisInfo(), Inf.Bancn);
            lstbxAfis.Items.Add(linie);

        }
        private void btnEconomii_Click(object sender, EventArgs e)
        {
           
            string info=string.Empty;
            info += Inf.Venit();
            info += " ";
            info += Convert.ToString(Convert.ToDouble(txtEc.Text) + Convert.ToDouble(Inf.Econom()));
            info += " ";
            info += Inf.Chelt();
            Inf.SetInfo(info);

            Afis();
            adminUtilizatori.AddUtilizator(Inf);
            Reset();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            lstbxAfis.Items.Clear();
            Antet();
            Afis();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {

            Application.Exit();


        }

        private void btnCheltuieli_Click(object sender, EventArgs e)
        {
            string info = string.Empty;
            info += Inf.Venit();
            info += " ";
            info += Inf.Econom();
            info += " ";
            info += Convert.ToString(Convert.ToDouble(Inf.Chelt()) + Convert.ToDouble(txtCh.Text));
            Inf.SetInfo(info);

            Afis();
            adminUtilizatori.AddUtilizator(Inf);
            Reset();
        }

        private void btnScade_Click(object sender, EventArgs e)
        {
            string info = string.Empty;
            info += Inf.Venit();
            info += " ";
            if (Convert.ToDouble(Inf.Econom()) >= Convert.ToDouble(Inf.Chelt()))
            {
                info += Convert.ToString(Convert.ToDouble(Inf.Econom()) - Convert.ToDouble(Inf.Chelt()));
                info += " ";
                info += "0.0001";
            }
            else
            {
                MessageBox.Show("Nu aveti suficiente economii");
                info += Inf.Econom();
                info += " ";
                info += Inf.Chelt();
            }
            Inf.SetInfo(info);
            Afis();
            adminUtilizatori.AddUtilizator(Inf);
            Reset();
        }
        private void Reset()
        {
            
            txtCh.Text = txtEc.Text = txtNume.Text=txtVenit.Text= txtPrenume.Text = string.Empty;
            rtbDolari.Checked = false;
            rtbEuro.Checked = false;
            rtbLei.Checked = false;
        }
        private bool Valid()
        {
            bool ok = true;
            if(txtCh.Text==string.Empty || !double.TryParse(txtCh.Text, out var val3))
            {
                MessageBox.Show("Date incorecte");
                ok = false;
            }
            if (txtEc.Text == string.Empty || !double.TryParse(txtEc.Text, out var val))
            {
                MessageBox.Show("Date incorecte");
                ok = false;
            }
            if (txtVenit.Text == string.Empty || !double.TryParse(txtVenit.Text, out var val1))
            {
                MessageBox.Show("Date incorecte");
                ok = false;
            }
            if (txtPrenume.Text == string.Empty || !(Char.IsLetter(txtPrenume.Text[0])))
            {
                MessageBox.Show("Date incorecte");
                ok = false;
            }
            if (txtNume.Text == string.Empty || !(Char.IsLetter(txtNume.Text[0])))
            {
                MessageBox.Show("Date incorecte");
                ok = false;
            }
            return ok;
        }

        private void btnMoneda_Click(object sender, EventArgs e)
        {
            if (rtbDolari.Checked == true || rtbEuro.Checked == true || rtbLei.Checked == true)
            {
                if (rtbDolari.Checked && Inf.Bancn == Bancnota.Euro)
                {
                    string info = string.Empty;
                    info += Convert.ToString(1.22 * Convert.ToDouble(Inf.Venit()));
                    info += " ";
                    info += Convert.ToString(1.22 * Convert.ToDouble(Inf.Econom())); ;
                    info += " ";
                    info += Convert.ToString(1.22 * Convert.ToDouble(Inf.Chelt())); ;
                    Inf.SetInfo(info);
                    Inf.Bancn = Bancnota.Dolari;
                    Afis();
                    adminUtilizatori.AddUtilizator(Inf);
                    Reset();
                }
                else
                  if (rtbDolari.Checked && Inf.Bancn == Bancnota.Lei)
                {
                    string info = string.Empty;
                    info += Convert.ToString(0.25 * Convert.ToDouble(Inf.Venit()));
                    info += " ";
                    info += Convert.ToString(0.25 * Convert.ToDouble(Inf.Econom())); ;
                    info += " ";
                    info += Convert.ToString(.25 * Convert.ToDouble(Inf.Chelt())); ;
                    Inf.SetInfo(info);
                    Inf.Bancn = Bancnota.Dolari;
                    Afis();
                    adminUtilizatori.AddUtilizator(Inf);
                    Reset();
                }
                else
                   if (rtbEuro.Checked && Inf.Bancn == Bancnota.Lei)
                {
                    string info = string.Empty;
                    info += Convert.ToString(0.20 * Convert.ToDouble(Inf.Venit()));
                    info += " ";
                    info += Convert.ToString(0.20 * Convert.ToDouble(Inf.Econom())); ;
                    info += " ";
                    info += Convert.ToString(.20 * Convert.ToDouble(Inf.Chelt())); ;
                    Inf.SetInfo(info);
                    Inf.Bancn = Bancnota.Euro;
                    Afis();
                    adminUtilizatori.AddUtilizator(Inf);
                    Reset();
                }
                else
                   if (rtbEuro.Checked && Inf.Bancn == Bancnota.Dolari)
                {
                    string info = string.Empty;
                    info += Convert.ToString(0.82 * Convert.ToDouble(Inf.Venit()));
                    info += " ";
                    info += Convert.ToString(0.82 * Convert.ToDouble(Inf.Econom())); ;
                    info += " ";
                    info += Convert.ToString(.82 * Convert.ToDouble(Inf.Chelt())); ;
                    Inf.SetInfo(info);
                    Inf.Bancn = Bancnota.Euro;
                    Afis();
                    adminUtilizatori.AddUtilizator(Inf);
                    Reset();
                }
                else
                   if (rtbLei.Checked && Inf.Bancn == Bancnota.Euro)
                {
                    string info = string.Empty;
                    info += Convert.ToString(4.92 * Convert.ToDouble(Inf.Venit()));
                    info += " ";
                    info += Convert.ToString(4.92 * Convert.ToDouble(Inf.Econom())); ;
                    info += " ";
                    info += Convert.ToString(4.92 * Convert.ToDouble(Inf.Chelt())); ;
                    Inf.SetInfo(info);
                    Inf.Bancn = Bancnota.Lei;
                    Afis();
                    adminUtilizatori.AddUtilizator(Inf);
                    Reset();
                }
                else
                   if (rtbLei.Checked && Inf.Bancn == Bancnota.Dolari)
                {
                    string info = string.Empty;
                    info += Convert.ToString(4.02 * Convert.ToDouble(Inf.Venit()));
                    info += " ";
                    info += Convert.ToString(4.02 * Convert.ToDouble(Inf.Econom())); ;
                    info += " ";
                    info += Convert.ToString(4.02 * Convert.ToDouble(Inf.Chelt())); ;
                    Inf.SetInfo(info);
                    Inf.Bancn = Bancnota.Lei;
                    Afis();
                    adminUtilizatori.AddUtilizator(Inf);
                    Reset();
                }
            }
            else
                MessageBox.Show("Alegeti o moneda");
        }
    }
}
