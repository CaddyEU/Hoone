using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine.Model
{
    class KorteriteMaja : Hoone
    {
        public int KorteriteArv { get; set; }
        public KorteriteMaja(int ehitusAasta, EnergiaKlass energiaKlass, int korteriteArv, int pindala = 200) : base(ehitusAasta, energiaKlass, pindala)
        {
            KorteriteArv = korteriteArv;
        }

        public override void NaitaInfo()
        {
            base.NaitaInfo();
            Console.WriteLine($"Minu korterite arv on {KorteriteArv}");
        }
    }
}
