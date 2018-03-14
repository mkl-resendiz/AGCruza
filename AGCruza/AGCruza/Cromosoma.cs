using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerApp
{
    class Cromosoma
    {



        private int BITS_PER_GENE;
        private int[] gene;
        private int[] geneGray;

        public Cromosoma(int bits)
        {
            BITS_PER_GENE = bits;
            gene = new int[BITS_PER_GENE];
            geneGray = new int[BITS_PER_GENE];
        }

        public int size()
        {
            return BITS_PER_GENE;
        }

        public int GetValue()
        {
            int value = 0;
            //Convertir de binario a decimal

            for (int i = 1; i < BITS_PER_GENE; i++)
            {
                value += gene[i]* (int)Math.Pow (2, BITS_PER_GENE - i - 1);
            }
            if (gene[0] == 1)
                value = -value;
              
            return value;
        }

        public void inicializar() //Llenar con aleatorios
        {
            Random rnd = new Random();
            for (int i = 0; i < BITS_PER_GENE; i++)
            {
                gene[i] = rnd.Next(2);
            }

            geneGray[0] = gene[0];

            int anterior = gene[1];
            geneGray[1] = anterior;

            for (int i = 2; i < BITS_PER_GENE; i++)
            {
                geneGray[i] = anterior ^ gene[i];
                anterior = gene[i];
            }
        }


        public override string ToString()
        {
            string data = "";
            for (int i = 0; i < BITS_PER_GENE; i++)
            {
                data += "" + gene[i];
            }
            return data;  //Debe imprimir 110000
        }
        public string ToStringGray()
        {
            string data = "";
            for (int i = 0; i < BITS_PER_GENE; i++)
            {
                data += "" + geneGray[i];
            }
            return data;  //Debe imprimir 110000
        }

    }
}
