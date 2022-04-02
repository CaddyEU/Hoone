using System;
using Klassi_Hoone_loomine.Model;

namespace Klassi_Hoone_loomine
{
    class Program
    {
        static void Main(string[] args)
        {
            EraMaja majake = new EraMaja(2015, EnergiaKlass.A, korrusteArv: 2, koosGaraaziga: true);
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            mees.hoone = majake;
            mees.NaitaInfo();

            Inimene korteriteMajaOmanik = new Inimene("Van Darkholme");
            KorteriteMaja korteriteMaja = new KorteriteMaja(2018, EnergiaKlass.A, 69);
            korteriteMaja.uks = new Uks("roosa");
            korteriteMajaOmanik.hoone = korteriteMaja;
            korteriteMajaOmanik.NaitaInfo();
        }
    }
}