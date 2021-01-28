using System;
using System.Xml.Linq;

namespace LINQXML04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtenemos informacion XML a partir de una cadena

            //El @ es para no tener problemas en los diferentes saltos de linea
            string alumnos = @"<Alumnos>
                  <Alumno Nombre = 'Jose'>
                  <Curso> Programacion </Curso>
                  <Calificacion> 8 </Calificacion>
                  </Alumno>
 
                  <Alumno Nombre = 'Susana'>
                  <Curso> XML </Curso>
                  <Calificacion> 9 </Calificacion>
                  </Alumno>
  
                  <Alumno Nombre = 'Maria'>
                  <Curso> Orientado a objetos</Curso>
                  <Calificacion> 10 </Calificacion>
                  </Alumno>
      
                  <Alumno Nombre = 'Luis'>
                  <Curso> UML </Curso>
                  <Calificacion> 10 </Calificacion>
                  </Alumno>
              </Alumnos>";

            XElement alumnosx = XElement.Parse(alumnos);//Pasamos la cadena para que haga parse

            //Mostramos el xml
            Console.WriteLine(alumnosx);
        }
    }
}
