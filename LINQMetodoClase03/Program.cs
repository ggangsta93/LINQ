using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMetodoClase03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtener resultados de query desde metodos

            Console.WriteLine("--ObtenerNumerosPares()----");
            //invocamos el metodo
            IEnumerable<int> resultados = CClaseExplicita.ObtenernumerosPares();
            //Mostramos los resultados
            foreach (int num in resultados)
            {
                Console.WriteLine(num);
            }
            
            Console.WriteLine("\n--ObtenerPostres()----");
            IEnumerable<string> postres = CClaseExplicita.ObtenerPostres();

            //Mostramos los resultados
            foreach (string p in postres)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\n--ObtenerNumerosImpares()----"); 
            //Ejemplo de resultado de query inmediato
            int[] impares = CClaseExplicita.ObtenerNumerosImpares();

            //mostramos los resultados
            foreach (int m in impares)
            {
                Console.WriteLine(m);
            }
        
        }
    }
}
