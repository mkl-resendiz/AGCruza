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
            int num_bits = cromosoma.size();    //Se obtiene el # de bits del gen
            Individuo[] hijo = new Individuo [2];   //Se crean los hijos resultantes
            hijo[0] = new Individuo(num_bits);  //Crea el espacio
            hijo[1] = new Individuo(num_bits);
            int crosspoint = num_bits / 2;  //Punto de cruze 

            for (int i = 0; i < num_bits; i++) {    //Asignación de bits
                if (i <= crosspoint)
                {  //Si está debajo o en el punto de corte
                    hijo[0].getCromosoma().setGeneAt(i, this.cromosoma.getGeneAt(i));
                    hijo[1].getCromosoma().setGeneAt(i, madre.getCromosoma().getGeneAt(i));
                }
                else {
                    hijo[1].getCromosoma().setGeneAt(i, this.cromosoma.getGeneAt(i));
                    hijo[0].getCromosoma().setGeneAt(i, madre.getCromosoma().getGeneAt(i));
                }
            }

            return hijo;
        }
        
        Cromosoma cromosoma;
        public Individuo(int num_bits)
        {
            cromosoma = new Cromosoma(num_bits);
            cromosoma.inicializar();
        }

        public Cromosoma getCromosoma() {
            return cromosoma;
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
