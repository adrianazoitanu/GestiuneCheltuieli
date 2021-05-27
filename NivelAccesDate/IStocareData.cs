using Librarie;
using System.Configuration;
using System.Collections;
namespace NivelAccesDate
{
    //definitia interfetei
    public interface IStocareData
    {
        void AddUtilizator(Utilizator ut);
        ArrayList GetUtilizatori();
       Utilizator Cautare(string nume, string prenume);
        bool Modificare(Utilizator utMofidicat);
    }
}
