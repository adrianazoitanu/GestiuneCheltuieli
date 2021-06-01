using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
    public enum Bancnota
    {
        Euro = 1,
        Lei = 2,
        Dolari = 3
    };
  
    
    public class Utilizator
    {
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int INFO = 4;
        private const int PAROLA = 3;
        private const int BANCNOTA = 5;

        double[] informatii;
        public static int IdUltimUtilizator { get; set; } = 0;
        public string Parola { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public Bancnota Bancn { get; set; }
        public int IdUtilizator { get; set; }
        public ArrayList Cheltuieli { get; set; }
        public string NumeComplet { get { return Nume + "         " + Prenume; } }
        public Utilizator()
        {
            Nume = Prenume = Parola = String.Empty;
            IdUltimUtilizator++;
            IdUtilizator = IdUltimUtilizator;
           
        }
        public string afBancnota()
        {
            return $"{(Bancnota)Bancn }";
        }
        //laborator2, ex1
        public Utilizator(string _nume, string _prenume, string _parola, double[] _info, Bancnota banc)
        {
            Nume = _nume;
            Prenume = _prenume;
            Parola = _parola;
            informatii = new double[_info.Length];
            _info.CopyTo(informatii, 0);
            IdUltimUtilizator++;
            IdUtilizator = IdUltimUtilizator;
            Bancn = banc;
        }
        public string afisInfo()
        {
            string sInfo = "Nu exista";
            if (informatii != null)
            {
                sInfo = string.Join("         ", informatii);
             //   sInfo = string.Join(" ", Bancn);
            }
            
            return $"{sInfo}";
        }
        public string Venit()
        {
            return $"{informatii[0]}";
        }
        public string Econom()
        {
            return $"{informatii[1]}";
        }
        public string Chelt()
        {
            return $"{informatii[2]}";
        }
        public Utilizator(string nume, string prenume, string parola)
        {
            Nume = nume;
            Prenume = prenume;
            Parola = parola;
            
            IdUltimUtilizator++;
            IdUtilizator = IdUltimUtilizator;
        }
        public Utilizator(string linieFisier)
        {
            var dateFisier = linieFisier.Split(';');


            IdUtilizator = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            Bancn = (Bancnota)Enum.Parse(typeof(Bancnota), dateFisier[BANCNOTA]);
            SetInfo(dateFisier[INFO]);
            Parola = dateFisier[PAROLA];
            IdUltimUtilizator = IdUtilizator;
            
        }
        public void SetInfo(string sInfo)
        {
            string[] v = sInfo.Split(' ');
            informatii = new Double[v.Length];
            int nrinfo = 0;

            foreach (var info in v)
            {

                bool rez = Double.TryParse(info, out informatii[nrinfo]);
                if (rez == true && informatii[nrinfo] > 0)
                {
                    nrinfo++;
                }

            }

            Array.Resize(ref informatii, nrinfo);

        }


        //laborator2, ex2
        public string ConversieLaSir()
        {
            string sInfo = "Nu exista";
            if (informatii != null)
            {
                sInfo = string.Join(" ", informatii);
            }
            
            string s = $"\nUtilizatorul: {IdUtilizator}\nNume: {Nume} \nPrenume: {Prenume}\nVenit: {informatii[0]} {(Bancnota)Bancn}\nCheltuieli: {informatii[1]} {(Bancnota)Bancn}\nEconomii: {informatii[2]} {(Bancnota)Bancn}";
            return s;
        }

        public string AfisareUtilizatori()
        {
            string s = $"Data: {DateTime.Now}\nUtilizatorul: {IdUtilizator}\nNume: {Nume} \nPrenume: {Prenume}";
            return s;
        }
        public string Comparare(Utilizator a)
        {
            if (a.informatii[2] > informatii[2])
                return $"{a.Nume} a economisit cel mai mult, suma de : {a.informatii[2]} lei";
            return $"{Nume} a economisit cel mai mult, suma de: {informatii[2]} lei";

        }
       
        public string ConversieLaSir_PentruScriereInFisier()
        {
            string sInfo = "Nu exista";
            if (informatii != null)
            {
                sInfo = string.Join(" ", informatii);
            }

            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}", ';', IdUtilizator.ToString(), (Nume ?? "Necunoscut"), (Prenume ?? "Necunoscut"), (Parola ?? "Necunoscut"), sInfo,(Bancnota)Bancn );

            return s;
        }



    }
}
