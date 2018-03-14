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
            Individuo padre = new Individuo(7);

            Individuo madre = new Individuo(7);
            //Individuo madre = new Individuo(new int[7] { 1, 0, 1, 1, 1, 1, 1});

            Console.Write("Individuo Padre ->  ");
            Console.WriteLine("[" + padre.ToString() + "]:" + padre.GetFenotipo() + " BINARIO \n");

            Console.Write("Individuo Madre ->  ");
            Console.WriteLine("[" + madre.ToString() + "]:" + madre.GetFenotipo() + " BINARIO \n");

            Individuo[] hijo = padre.croos1P(madre);

            Console.Write("Individuo Hijo 1 ->  ");
            Console.WriteLine("[" + hijo[0].ToString() + "]:" + hijo[0].GetFenotipo() + " BINARIO\n");

            Console.Write("Individuo Hijo 2 ->  ");
            Console.WriteLine("[" + hijo[1].ToString() + "]:" + hijo[1].GetFenotipo() + " BINARIO\n");

            Console.Read();
        }
    }
}
