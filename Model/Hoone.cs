using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum EnergiaKlass
{
    D,
    C,
    B,
    A,
    APluss,
    APlussPluss
}

namespace Klassi_Hoone_loomine.Model
{
    class Hoone
    {
        public int EhitusAasta { get; set; }
        public EnergiaKlass EnergiaKlass { get; set; }
        public int Pindala { get; set; }
        public Uks uks;

        public Hoone(int ehitusAasta, EnergiaKlass energiaKlass, int pindala = 200)
        {
            EhitusAasta = ehitusAasta;
            EnergiaKlass = energiaKlass;
            Pindala = pindala;
        }

        public virtual void NaitaInfo()
        {
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2, ehitusaasta on {EhitusAasta} ja energiaklass on {EnergiaKlass}");
        }

        public Uks GetUks()
        {
            return uks;
        }
    }
}
