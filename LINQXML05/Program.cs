using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQXML05
{
    class Program
    {
        static void Main(string[] args)
        {
            //var escuela = new XElement("Escuela", 
            //                        new XElement("Ciencias",
            //                            new XElement("Materia", "Matematicas"),
            //                            new XElement("Materia", "Fisica")
            //                            ),
            //                        new XElement("Artes",
            //                            new XElement("Materia", "Historia del arte"),
            //                            new XElement("Practica", "Pintura")
            //                            )
            //                        );

            //Console.WriteLine(escuela);
            //Console.WriteLine("\n-------//Nodes regresa a los hijos-----------------------------------");

            //foreach (XNode nodo in escuela.Nodes())
            //    Console.WriteLine(nodo.ToString());

            //Console.WriteLine("\n-------//Elements regresa los hijos de los nodos de tipo XElement----");

            //foreach (XElement elemento in escuela.Elements())
            //    Console.WriteLine(elemento.Name+"="+elemento.Value);

            //Console.WriteLine("\n-------//FirstNode nos regresa el primer nodo------------------------");
            //Console.WriteLine(escuela.FirstNode);

            //Console.WriteLine("\n-------//Encontramos el padre el primer nodo------------------------");
            //Console.WriteLine(escuela.FirstNode.Parent.Name);

            //Console.WriteLine("\n-------//LastNode nos regresa el ultimo nodo------------------------");
            //Console.WriteLine(escuela.LastNode);


            //Console.WriteLine("\n------//Obtiene todos los elementos del donde se encuentre Fisica---");
            //IEnumerable<string> materias = from curso in escuela.Elements()
            //                               where curso.Elements().Any(materias => materias.Value == "Fisica")
            //                               select curso.Value;

            //foreach (string s in materias)
            //    Console.WriteLine(s);

            //Console.WriteLine("\n------//Obtiene el nombre del elemento padre de Fisica-------------");
            //IEnumerable<XName> tipoCurso = from curso in escuela.Elements()
            //                               where curso.Elements().Any(materias => materias.Value == "Fisica")
            //                               select curso.Name;

            //foreach (XName s in tipoCurso)
            //    Console.WriteLine(s);

            //Console.WriteLine("\n------//Solamente selecciona los nodos materia----------------------");
            //IEnumerable<string> materia2 = from curso in escuela.Elements()
            //                               from asignatura in curso.Elements()
            //                               where asignatura.Name == "Materia"
            //                               select asignatura.Value;

            //foreach (string s in materia2)
            //    Console.WriteLine(s);

            //Console.WriteLine("\n------//Contamos los elementos de un tipo en particular-------------");
            //int n = escuela.Elements("Ciencias").Count();
            //Console.WriteLine("Hay {0} Ciencias",n);

            //Console.WriteLine("\n------//Element nos da la primera ocurrencia de un elemento con ese nombre-----");
            //string mat = escuela.Element("Ciencias").Element("Materia").Value;
            //Console.WriteLine("Hay {0} Ciencias", mat);

            //Console.WriteLine("\n------//Obtenemos el siguiente nodo, estilo lista ligada-------------------");
            //XNode p = escuela.FirstNode;
            //Console.WriteLine(p);
            //Console.WriteLine("---Tomamos el siguiente ---");
            //p = p.NextNode;
            //Console.WriteLine(p);

            //Console.WriteLine("--------------------------------");
            //escuela.SetElementValue("Deportes", "No hay");
            //Console.WriteLine(escuela);
            //Console.WriteLine("---------------------------------");
            //Si lo volvemos a usar se actualiza
            //escuela.SetElementValue("Deportes","Sin presupuesto");
            //Console.WriteLine(escuela);


            //Para adicionar despues de un elementom el primer nodo es el punto de referencia
            //escuela.FirstNode.AddAfterSelf(new XElement("Asignaturas"));
            //Console.WriteLine(escuela);
            //Console.WriteLine("---------------------------------");
            //Ahora adicionamos un elemento antes de ese
            //escuela.FirstNode.AddBeforeSelf(new XElement("EscuelaLibre"));
            //Console.WriteLine(escuela);

            //Console.WriteLine("---------------------------------");
            //Obtenemos a matematicas
            //var mate = escuela.Element("Ciencias").Element("Materia");
            //Le damos un valor
            //mate.SetValue("Geometria no Euclidiana");
            //Console.WriteLine(escuela);

            //Obtenemos el valor de ese elemento
            //string valorMate = mate.Value;
            //Console.WriteLine(valorMate);


            /////////////////////////////////////////////////////////////////

            //Descendants regresa a los nodos hijos todos sus descendientes
            //Cargamos un XML de archivo
            //No olvidar poner un .xml en el directorio para cargar

            //Console.WriteLine("------------Se Carga el archivo alumnos.xml---------------------");
            //XDocument alumnos = XDocument.Load("alumnos.xml");
            //Console.WriteLine(alumnos);


            //Console.WriteLine("------------Se elimina \"Maestros\"---------------------");
            ////Eliminar a los maestros
            //alumnos.Descendants("Maestros").Remove(); 
            //Console.WriteLine(alumnos);


            //Console.WriteLine("------------Se elimina \"calificaciones\"---------------------");
            ////Eliminar a las calificaciones
            ////alumnos.Descendants("calificacion").Remove();
            ////Console.WriteLine(alumnos);


            //Console.WriteLine("------------Se obtienen las calificaciones---------------------");
            ////Obtenemos las calificaciones
            //var califs = from a in alumnos.Descendants("calificacion")
            //             select a.Value;

            //foreach (var calif in califs)
            //    Console.WriteLine(calif);
        }
    }
}
