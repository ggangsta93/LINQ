using System;
using System.Xml.Linq;


namespace LINQXML02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos un documento de XML mas completo

            XDocument documento = new XDocument(
                new XDeclaration("1.0","utf-8","yes"),//Colocamos la declaracion del documento version, codificacion, standalone yes/not
                new XComment("listado de alumnos"),//Con eso colocamos un comentario
                new XProcessingInstruction("xml-stylesheet","href='MyStyles.css', title='Compact', type='text/css'"),
                new XElement("{http://nicosio.com}Alumnos",//Lleva namespace {http:/nicosio.com}
                    new XElement("Ana", new XAttribute("ID", "10100"),
                        new XElement("Curso", "Administracion"),
                        new XElement("Promedio", "10")
                    ),//Fin de Ana
                    new XElement("Luis", new XAttribute("ID", "25350"), new XComment("ESTO_ES_OTRO_COMENTARIO"),
                        new XElement("Curso", "Programacion"),
                        new XElement("Promedio", "9.5")
                    )//FIn de luis
                )//Fin de alumnos

            );//Fin de documento

            //Mostramos el documento
            Console.WriteLine(documento);

            //Guardamos en disco
            documento.Save("alumnos.xml");
        }
    }
}
