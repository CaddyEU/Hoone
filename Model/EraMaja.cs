using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine.Model
{
    class EraMaja : Hoone
    {
        public int KorrusteArv { get; set; }
        public bool KoosGaraaziga { get; set; }
        public string Suurus
        {
            get
            {
                if (Pindala > 200)
                {
                    return "liiga suur maja";
                }
                else if (Pindala > 100)
                {
                    return "suur maja";
                }
                else if (Pindala > 50)
                {
                    return "keskmine maja";
                }

                return "vaike maja";
            }
        }

        public EraMaja(int ehitusAasta, EnergiaKlass energiaKlass, int pindala = 50, int korrusteArv = 1, bool koosGaraaziga = false) : base(ehitusAasta, energiaKlass, pindala)
        {
            KorrusteArv = korrusteArv;
            KoosGaraaziga = koosGaraaziga;
        }

        public override void NaitaInfo()
        {
            base.NaitaInfo();
            Console.WriteLine($"Mina olen {KorrusteArv}-korruseline");

            if (KoosGaraaziga)
            {
                Console.WriteLine("Mina olen garaaziga");
            }
            else
            {
                Console.WriteLine("Mina olen garaazita");
            }
        }
    }
}
