using System;


//Es necesario
using System.Xml.Linq;

namespace LINQXML01
{
    class Program
    {
        static void Main(string[] args)
        {
            //XML es muy utilizado, pero es tedioso trabajar con el, aunque sencillo
            //El framework provee System.Xml. y XmlReader, XmlWriter
            //Pero es mas sencillo trabajar con LINQ para XML

            //Cada parte de XML: declaracion, elemento, atributos, pueden representarse por clases
            //Si esas clases tienen colecciones, entonces podemos representar un arbol que 
            //describe al documento XML, esa es la base de DOM (Document Object Model)

            //LINQ para XMl tiene un DOM conocido como X-DOM y operadores extra
            //XObject - Clase abstracta que es la base para todo contenido de XML
            //XNode - Clase base para la mayoria del contenido XML, excepto atributos
            //XContainer - Define miembros para trabajar con sus hijos y es la clase padre de XElement y XDocument
            //XElement - Define a un elemento
            //XDocument - Representa la raiz de un arbol XML, en realidad envuelve a un XElement que actua como raiz 
            //            y lo podemos usar para adicion la declaracion e instrucciones de procesamiento.
            //            Se puede usar X-DOM sin tener un XDocument

            //Creamos un documentos sencillo de XML con LINQ
            XElement raiz = new XElement("raiz");
            XElement el1 = new XElement("Elemento1");
            el1.Add(new XAttribute("Atributo", "valor"));
            el1.Add(new XElement("Anidado", "Contenido"));

            raiz.Add(el1);
            Console.WriteLine(raiz);

            Console.WriteLine("-------------------------------");

            //Esta forma de crear el documento se conoce como construccion funcional
            XElement documento = new XElement("Alumnos",
                new XElement("Ana", new XAttribute("ID", "10100"),
                new XElement("Curso", "Administracion"),
                new XElement("Promedio", "10")
                ),//Fin de Ana
                new XElement("Luis",new XAttribute("ID", "25350"),
                    new XElement("Curso", "Programacion"),
                    new XElement("Promedio", "9.5")
                )//FIn de luis
            );//Fin de alumnos

            //Imprimimos
            Console.WriteLine(documento);

            //Escribimos el documento a disco
            documento.Save("Alumnos.xml");

        }
    }
}
