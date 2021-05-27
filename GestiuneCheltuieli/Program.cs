using System;
using System.Collections;
using NivelAccesDate;
using Librarie;


namespace GestiuneCheltuieli
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList utilizatori = new ArrayList();

            IStocareData adminUtilizator = StocareFactory.GetAdministratorStocare();

            utilizatori = adminUtilizator.GetUtilizatori();

            Utilizator ut = new Utilizator();
            int nrUtilizatori = utilizatori.Count;
            Utilizator.IdUltimUtilizator = nrUtilizatori;


            int op, ok = 0;
            do
            {
                Console.WriteLine("\t\t\t\t\t\tCheltuieli Personale");
                Console.WriteLine("1. Adaugare utilizator");
                Console.WriteLine("2. Log-in");
              
                Console.WriteLine("3. Comparare economii pentru 2 utilizatori alesi");
                Console.WriteLine("4. Afisare utilizatori existenti in aplicatie");
                Console.WriteLine("5. Cautare Utilizator");
                Console.WriteLine("6. Modificare date utilizator");
                Console.WriteLine("7. Iesire Aplicatie");
                op = int.Parse(Console.ReadLine());



                switch (op)
                {
                    case 1:

                        ut = CitireDateTastatura();

                        utilizatori.Add(ut);
                        adminUtilizator.AddUtilizator(ut);
                        break;
                    case 2:

                        IntraInCont(utilizatori);

                        break;
                    case 3:
                        ComparareEntitati(utilizatori);

                        break;
                    case 4:
                        foreach (Utilizator u in utilizatori)
                        {
                            Console.WriteLine(u.AfisareUtilizatori());
                        }
                        break;
                    case 5:
                        {
                            string n, p;
                            Console.WriteLine("Introduceti numele utilizatorului cautat:");
                            n = Console.ReadLine();
                            Console.WriteLine("Introduceti prenumele utilizatorului cautat");
                            p = Console.ReadLine();

                            Utilizator u1 = new Utilizator();
                            u1 = adminUtilizator.Cautare(n, p);
                            if (adminUtilizator.Cautare(n, p) != null)
                                Console.WriteLine("Utilizator Gasit:\n"+u1.ConversieLaSir());
                            else
                                Console.WriteLine("Utilizatorul " + n+" "+p + " nu a fost gasit");
                           
                        }
                        break;
                    case 6:
                        {
                            string n, p;
                            Console.WriteLine("Introduceti numele utilizatorului cautat:");
                            n = Console.ReadLine();
                            Console.WriteLine("Introduceti prenumele utilizatorului cautat");
                            p = Console.ReadLine();
                            Utilizator u3;
                            Utilizator u2 = new Utilizator();
                            u2 = adminUtilizator.Cautare(n, p);
                            if (adminUtilizator.Cautare(n, p) != null)
                            {
                                Console.WriteLine("Introduceti datele noi despre utilizator: ");
                                u3 = CitireDateTastatura();
                                adminUtilizator.Modificare(u3);
                            }
                            else
                                Console.WriteLine("Utilizatorul " + n + " " + p + " nu a fost gasit\nCreati un cont nou!");
                        }

                        break;
                   
                    default:
                        break;





                }
                Console.WriteLine("Apasa orice tasta pentru a continua");
                Console.ReadKey();
                Console.Clear();

            } while (op != 7);

        }
        private static Utilizator CitireDateTastatura()
        {
            double valid;
            Utilizator u2 = new Utilizator();
            string nume, _prenume, _parola, infor, info;
            info = infor = string.Empty;


            Console.WriteLine("Introduceti numele utilizatorului: ");
            nume = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele utilizatorului");
            _prenume = Console.ReadLine();
            Console.WriteLine("Introduceti parola utilizatorului");
            _parola = Console.ReadLine();
            Console.WriteLine("Venit:");
            info = Console.ReadLine();
            if (double.TryParse(info, out valid))
            {
                infor += info;
                infor += " ";
            }
            else
            {
                Console.WriteLine("Nu ati introdus date corecte");
                return u2;
            }
            Console.WriteLine("Economii:");
            info = Console.ReadLine();
            if (double.TryParse(info, out valid))
            {
                infor += info;
                infor += " ";
            }
            else
            {
                Console.WriteLine("Nu ati introdus date corecte");
                return u2;
            }
            Console.WriteLine("Cheltuieli");
            info = Console.ReadLine();
            if (Double.TryParse(info, out valid))
            {
                infor += info;
                infor += " ";
            }
            else
            {
                Console.WriteLine("Nu ati introdus date corecte");
                return u2;
            }
            int b;
            Console.WriteLine("Alegeti moneda:");
            Console.WriteLine("1-Euro\n2-Lei\n3-Dolar");
            b = Int32.Parse(Console.ReadLine());
            Utilizator u1 = new Utilizator(nume, _prenume, _parola,b);
            u1.SetInfo(infor);
            return u1;
        }


        private static void IntraInCont(ArrayList utilizatori)
        {
            int corect = -1;
            string parola, numeU, prenumeU;
            Console.WriteLine("Introduceti numele utilizatorului: ");
            numeU = Console.ReadLine();
            Console.WriteLine("Introduceti prenumele utilizatorului");
            prenumeU = Console.ReadLine();
            Console.WriteLine("Introduceti parola utilizatorului");
            parola = Console.ReadLine();
            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (((Utilizator)utilizatori[i]).Nume == numeU && ((Utilizator)utilizatori[i]).Prenume == prenumeU && ((Utilizator)utilizatori[i]).Parola == parola)
                {
                    corect = i;
                    break;
                }
            }
            if (corect > -1)
                Console.WriteLine(((Utilizator)utilizatori[corect]).ConversieLaSir());
            else
                Console.WriteLine("Utilizator inexistent");
        }
        private static void ComparareEntitati(ArrayList utilizatori)
        {
            int gasit1 = 0, gasit2 = 0;
            Utilizator a, b;
            a = b = new Utilizator();
            string numeA, numeB, prenumeA, prenumeB;
            Console.WriteLine("Introduceti informatii despre prima persoana:");
            Console.WriteLine("Nume:");
            numeA = Console.ReadLine();
            Console.WriteLine("Prenume:");
            prenumeA = Console.ReadLine();
            Console.WriteLine("Introduceti informatii despre a doua persoana:");
            Console.WriteLine("Nume:");
            numeB = Console.ReadLine();
            Console.WriteLine("Prenume:");
            prenumeB = Console.ReadLine();
            for (int i = 0; i < utilizatori.Count; i++)
            {
                if (numeA == ((Utilizator)utilizatori[i]).Nume && prenumeA == ((Utilizator)utilizatori[i]).Prenume)
                {
                    gasit1 = 1;
                    a = (Utilizator)utilizatori[i];
                }
                if (numeB == ((Utilizator)utilizatori[i]).Nume && prenumeB == ((Utilizator)utilizatori[i]).Prenume)
                {
                    gasit2 = 1;
                    b = (Utilizator)utilizatori[i];
                }
            }
            if (gasit1 == 1 && gasit2 == 1)
                Console.WriteLine(a.Comparare(b));
            else
                if (gasit1 == 0 && gasit2 == 1)
                Console.WriteLine("Utilizatorul" + numeA + " " + prenumeA + " nu exista");
            else
                     if (gasit1 == 1 && gasit2 == 0)
                Console.WriteLine("Utilizatorul" + numeB + " " + prenumeB + " nu exista");
            else
                Console.WriteLine("Utilizatorii nu exista");

        }

       
       
        
    }
}
