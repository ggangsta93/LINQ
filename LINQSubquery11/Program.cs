using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSubquery11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un subquery es un query que esta contenido en la expression lambda de otro query
            //El scope que tiene existe dentro de la expresion que lo contiene

            //Creamos un arreglo sobre el cual trabajar
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            //Ordenamos alfabeticamente de acuerdo a la ultuma palaba de cada elemento
            //Split divide en una coleccion a la cadena
            //pSplit().Last() es el subquery, 

            IEnumerable<string> resultados = postres.OrderBy(p=> p.Split().Last());//ordena segun la ultima palabra de cada elemento
            foreach (string postre in resultados)
                Console.WriteLine(postre);

            
            Console.WriteLine("----------------");
            int[] numeros = { 19, 14, 56, 32, 11, 8, 45, 7, 18, 2, 17, 23 };
            IEnumerable<int> nums = numeros.Where(n=> n < numeros.First());
            foreach (int n in nums)
                Console.WriteLine(n);

            //Numeros que sean menores o iguales al primer entero que se encuentre
            Console.WriteLine("----------------");
            IEnumerable<int> nums2 = numeros.Where(n => n <= (numeros.Where(n2 => n2 % 2 == 0).First()));
            foreach (int n in nums2)
                Console.WriteLine(n);



        }
    }
}
