using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperaciones07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vemos varias operaciones que podemos realizar con LINQ

            //Creamos una lista
            List<CEstudiante> estudiantes = new List<CEstudiante>
            {
                new CEstudiante("Ana","A100","Mercadotecnia",10.0),
                new CEstudiante("Luis","S250","Orientado a objetos", 9.0),
                new CEstudiante("Juan","S875","Programacion basica", 5.0),
                new CEstudiante("Susana","A432","Mercadotecnia", 8.7),
                new CEstudiante("Pablo","A156","Mercadotecnia",4.3),
                new CEstudiante("Alberto","S456","Orientado a objetos",8.3)

            };

            Console.WriteLine("\n------CONTEO-----");
            int cantidad = (from e in estudiantes
                            where e.Promedio > 5
                            select e).Count();
            Console.WriteLine("La cantidad de aprobados es {0}",cantidad);

            Console.WriteLine("\n------REVERSA-----");
            var aprobados = from e in estudiantes
                            where e.Promedio > 5
                            select e;

            foreach (CEstudiante est in aprobados)
                Console.WriteLine(est);
            Console.WriteLine("-----------");
            foreach (CEstudiante est in aprobados.Reverse())
                Console.WriteLine(est);

            Console.WriteLine("\n------ORDENAMIENTO-----");

            var ordenados = from e in estudiantes
                            orderby e.Promedio descending //ascending
                            select e;

            foreach (CEstudiante est in aprobados)
                Console.WriteLine(est);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n------OPERACION DE AGRAGACIÓN-----");

            int[] numeros = {2,5,3,9,1,6,4,7,8};

            int maximo = (from n in numeros select n).Max();
            Console.WriteLine("El maximo es {0}",maximo);

            int minimo = (from n in numeros select n).Min();
            Console.WriteLine("El minimo es {0}", minimo);

            double prom = (from n in numeros select n).Average();
            Console.WriteLine("El promedio es {0}", prom);

            int sumatoria = (from n in numeros select n).Sum();
            Console.WriteLine("La sumatoria es {0}", sumatoria);




        }
    }
}
