﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarie
{
    public class Utilizator
    {
        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int INFO = 4;
        private const int PAROLA = 3;

        double[] informatii;
        public static int IdUltimUtilizator { get; set; } = 0;
        public string Parola { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int IdUtilizator { get; set; }
        public string NumeComplet { get { return Nume + " " + Prenume; } }
        public Utilizator()
        {
            Nume = Prenume = Parola = String.Empty;
            IdUltimUtilizator++;
            IdUtilizator = IdUltimUtilizator;

        }
        //laborator2, ex1
        public Utilizator(string _nume, string _prenume, string _parola, double[] _info)
        {
            Nume = _nume;
            Prenume = _prenume;
            Parola = _parola;
            informatii = new double[_info.Length];
            _info.CopyTo(informatii, 0);
            IdUltimUtilizator++;
            IdUtilizator = IdUltimUtilizator;

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

            string s = $"Data: {DateTime.Now}\nUtilizatorul: {IdUtilizator}\nNume: {Nume} \nPrenume: {Prenume}\nVenit: {informatii[0]}\nCheltuieli: {informatii[1]}\nEconomii: {informatii[2]}";
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

            string s = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}", ';', IdUtilizator.ToString(), (Nume ?? "Necunoscut"), (Prenume ?? "Necunoscut"), (Parola ?? "Necunoscut"), sInfo);

            return s;
        }



    }
}
