using Librarie;
using System;
using System.Collections;
using System.IO;


namespace NivelAccesDate
{
    public class AdministrareUtilizator_FisierText : IStocareData
    {
        string NumeFisier { get; set; }

        public AdministrareUtilizator_FisierText(string numeFisier)
        {
            this.NumeFisier = numeFisier;
            Stream sFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            sFisierText.Close();

        }
        public void AddUtilizator(Utilizator ut)
        {
            try
            {

                using (StreamWriter swFisierText = new StreamWriter(NumeFisier, true))
                {
                    swFisierText.WriteLine(ut.ConversieLaSir_PentruScriereInFisier());

                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public ArrayList GetUtilizatori()
        {
            ArrayList ut = new ArrayList();

            try
            {

                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string line;


                    while ((line = sr.ReadLine()) != null)
                    {
                        Utilizator utilizatorDinFisier = new Utilizator(line);
                        ut.Add(utilizatorDinFisier);
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return ut;
        }
        public Utilizator Cautare(string nume, string prenume)
        {
            try
            {
                using(StreamReader sr=new StreamReader(NumeFisier))
                {
                    string linie=string.Empty;
                    while((linie=sr.ReadLine())!=null)
                    {
                        Utilizator ut = new Utilizator(linie);
                        if (ut.Nume.Equals(nume) && ut.Prenume.Equals(prenume))
                            return ut;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }

        public bool Modificare(Utilizator utMofidicat)
        {
           ArrayList utilizatori = GetUtilizatori();
            bool modificare = false;
            try
            {
                using(StreamWriter sr= new StreamWriter(NumeFisier,false))
                {
                   foreach(Utilizator ut in utilizatori)
                    {
                        Utilizator scrieInFisier = ut;
                        if(ut.IdUtilizator==utMofidicat.IdUtilizator)
                        {
                            scrieInFisier = utMofidicat;
                        }
                        sr.WriteLine(scrieInFisier.ConversieLaSir_PentruScriereInFisier());
                    }
                    modificare = true;
                }

            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return modificare;


        }
    }
}
