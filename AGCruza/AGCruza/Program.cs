/*  
 *    Universidad Autonoma del Estado de México
 *      
 *      Centro Universitario UAEM Zumpango
 *  
 *          Ingeniería en Computación
 *  
 *            Algoritmos Genéticos
 *      
 *      Miguel Ángel Reséndiz García
 *      
 *        Dr. Asdrúbal López Chau
 *        
 *        14 de Febrero de 2018
 *        
 *        Representación Entera
 *        
 *        Descripción y Funcionamiento     
 *        
 *        Crear individuoGray y comentar código
 */



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Individuo ind = new Individuo(5);
            Console.WriteLine("[" + ind.ToString() + "]:" + ind.GetFenotipo() + " BINARIO");
            Console.WriteLine("[" + ind.ToStringGray() + "]:" + ind.GetFenotipo() + " GRAY");
            Console.Read();
        }
    }
}
