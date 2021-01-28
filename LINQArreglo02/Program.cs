using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQArreglo02
{
    class Program
    {
        static void Main(string[] args)
        {

            //Trabajo con tipos implicitos, ejecucion diferida, inmediata

            //Ejemplo con numeros
            //Creamos un arreglo sobre el cual trabajar

            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11 };

            //Hacemos el query y usamos un tipo implicito por medio de var

            var valores = from n in numeros    //var es un tipo implicito
                          where n % 2 == 0
                          select n;

            //Mostramos los resultados
            foreach (int num in valores)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("---Reflexion--");


            ////hacemos reflexion
            InformacionResultados(valores);

            Console.WriteLine("-----Ejecucion diferida");
            //Ejecucion diferida
            //la expresion de query no se evalua hasta que se itera sobre el arreglo
            //Se puede usar el mismo query y siempre obtenemos el resultado actualizado
            //Modificamos el arreglo
            numeros[1] = 12;

            //Mostramos los resultados
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }


            Console.WriteLine("-----Ejecucion inmediata");
            //Se ejecuta el query en el momento exacto

            //Guardamos los resultados como un arreglo
            int[] arrayValores = (from n in numeros where n % 2 == 0 select n).ToArray<int>();

            //Guardamos los resultados como un list
            List<int> listValores = (from n in numeros where n % 2 == 0 select n).ToList<int>();

            //Mostramos
            Console.WriteLine("----------El arreglo");

            //Mostramos los resultados
            foreach (int num in arrayValores)
            {
                Console.WriteLine(num);
            }

            numeros[0] = 28;
            Console.WriteLine("----- se actualiza despues de la modificacion.?");
            //Mostramos los resultados 
            foreach (int num in arrayValores)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----------la lista");
            foreach (int num in listValores)
            {
                Console.WriteLine(num);
            }
        }


        static void InformacionResultados(object pResultados)
        {
            Console.WriteLine("Tipo {0}", pResultados.GetType().Name);
            Console.WriteLine("Locacion {0}", pResultados.GetType().Assembly.GetName().Name);
        }
    }
}
