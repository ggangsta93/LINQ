using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQClase04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso de LINQ con clases

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

            //Encontramos a los reprobados
            var reprobados = from e in estudiantes
                             where e.Promedio <= 5.0  //Aquí trabajamos con una propiedad
                             select e;

            //Mostramos
            Console.WriteLine("Reprobados------");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r);
            }

            //Mostramos solo un atributo de los encontrados por medio de la propiedad
            Console.WriteLine("Solo un atributo------");
            foreach (CEstudiante r in reprobados)
            {
                Console.WriteLine(r.Nombre);
            }

            //Encontramos solo los nombre de los mercadotecnia
            var mercadotecnia = from e in estudiantes
                                where e.Curso == "Mercadotecnia"  //Aquí trabajamos con una propiedad
                                select e.Nombre;

            Console.WriteLine("Nombres de mercadotecnia------");
            foreach (string nombre in mercadotecnia)
            {
                Console.WriteLine(nombre);
            }

        }
    }
}
