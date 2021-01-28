using System;
using System.Linq;
using System.Xml.Linq;

namespace LINQXML03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un XML a partir de un arreglo
            //Funciona con otros contenedores tambien

            var listado = new[]
            {
                new { Nombre="Jose", Calif=8, Curso="Programacion"},
                new { Nombre="Susana", Calif=9, Curso="XML" },
                new { Nombre="Maria", Calif=10, Curso="Orientado a objetos"},
                new { Nombre="Luis", Calif=10, Curso="UML"}
            };

            //Ahora creamos el elemento
            XElement alumnos = new XElement("Alumnos",//Este es la raiz)
                from a in listado
                select  new XElement("Alumno", new XAttribute("Nombre",a.Nombre),
                        new XElement("Curso", a.Curso),
                        new XElement("Calificacion",a.Calif)
                )//Fin de alumno    
           );//Fin de alumnos

            //Lo mostramos
            Console.WriteLine(alumnos);

            //Lomandamos a disco
            alumnos.Save("Alumnos.xml");


        }

    }
}
