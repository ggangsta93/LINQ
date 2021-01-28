using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQFluentSintax09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hemos estado utilizando una sintaxis que llamamos query expression
            //Ahora veremos una sintaxis que se conoce como fluent sintax
            //Formalicemos algunos conceptos
            //Sequence es un objeto que implementa a IEnumerable<T>
            //Element es cada item es la secuencia
            //Query operator es un metodo que transforma una secuencia
            //Acepta una sequencia de entrada y da como resultado una sequencia de salida
            //Se tiene cerca de 40 operadores para LINQ, esto forman parte de los standard query operators
            //El query es una expresion que cuando se enumera transforma a la secuencia usando los operadores

            //Creamos un arreglo sobre el cual trabajar 
            int[] numeros = { 1, 5, 4, 7, 6, 3, 5, 9, 8, 11};

            //Usamos expresione lambda como argumento, n es el argumento de entrada
            IEnumerable<int> pares = numeros.Where(n => n % 2 == 0);//Esta expresion lambda retorna un True o False

            //Mostramos los resultados
            foreach (int num in pares)
                Console.WriteLine(num);

            Console.WriteLine("---------");

            //Creamos un arreglo sobre el cual trabajar
            string[] postres = { "pay de manzana", "pastel de chocolate", "manzana caramelizada", "fresas con crema" };

            IEnumerable<string> encontrados = postres.Where(p => p.Contains("manzana"));
            foreach (string postre in encontrados)
                Console.WriteLine(postre);

            Console.WriteLine("---------");

            //Encadenamos operadores
            //Se va adicionando operadores

            IEnumerable<string> manzana = postres.Where(p => p.Contains("manzana")).OrderBy(p => p.Length).Select(p => p.ToUpper());//El elemento es proyectado

            //Mostramos los resultados
            foreach (string postre in manzana)
                Console.WriteLine(postre);

            Console.WriteLine("---------");
        }
    }
}
