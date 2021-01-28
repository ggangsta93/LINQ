using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMasOperadores10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenamientos y otros operadores

            //Creamos un arreglosobre el cual trabajar
            int[] numeros = { 1,5,4,7,6,3,5,9,8,11};

            Console.WriteLine("------------.Take(5)");
            IEnumerable<int> desdeInicio = numeros.Take(5);//Take toma un subsecuencia de numeros ejem. toma los primeros 5 elementos
            foreach (int num in desdeInicio)//R=1,5,4,7,6
                Console.WriteLine(num);

            Console.WriteLine("\n------------.Skip(5)");
            IEnumerable<int> brinco = numeros.Skip(5);//Skip brinca los 5 primeros elementos y retorna el resto
            foreach (int num in brinco)//R=3,5,9,8,11
                Console.WriteLine(num);

            Console.WriteLine("\n------------.Reverse()");
            IEnumerable<int> reversa = numeros.Reverse();//Reversa
            foreach (int num in reversa)
                Console.WriteLine(num);

            
            Console.WriteLine("\nEl primer elemento es: "+ numeros.First());
            Console.WriteLine("El ultimo elemento es: "+ numeros.Last());
            Console.WriteLine("En el indice 3 está "+numeros.ElementAt(3));
            Console.WriteLine("Contiene el 15 -  " + numeros.Contains(15));
            Console.WriteLine("Tiene elementos - " + numeros.Any());
            Console.WriteLine("Hay multiplos de 5 - " + numeros.Any(n=> n%5 == 0));
            Console.WriteLine("Contiene el 15 -  " + numeros.Contains(15));

            Console.WriteLine("\n----------------------------");
            //Cuidado con los cambios de valor entre la ejecucion de los query
            int valor = 2;
            IEnumerable<int> resultados = numeros.Where(n => n % valor == 0);
            valor = 3;
            
            foreach (int n in resultados)
                Console.WriteLine(n);
        }
    }
}
