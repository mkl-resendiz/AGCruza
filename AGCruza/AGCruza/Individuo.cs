using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerApp
{
    class Individuo
    {
        public Individuo[] croos1P (Individuo madre)
        {
            Individuo[] hijo = new int [2];
        } 



        Cromosoma cromosoma;
        public Individuo(int num_bits)
        {
            cromosoma = new Cromosoma(num_bits);
            cromosoma.inicializar();
        }

        public override string ToString()
        {
            return cromosoma.ToString();
        }
        public string ToStringGray()
        {
            return cromosoma.ToStringGray();
        }

        public int GetFenotipo()
        {
            return cromosoma.GetValue();
        }
    }
}
