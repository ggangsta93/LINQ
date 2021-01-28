using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Necesario
using System.Xml.Linq;
namespace LINQEnWinsForms
{
    public partial class Form1 : Form
    {

        //Nuestro documento XML
        XDocument documento = new XDocument();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            documento = XDocument.Load("alumnos.xml");
            txtXML.Text = documento.ToString();
        }

        private void txtAdicionar_Click(object sender, EventArgs e)
        {
            //Creamos un nuevo elemento
            XElement temp = new XElement("alumno", new XAttribute("Nombre", txtNombre.Text),
                new XElement("curso", txtCurso.Text),
                new XElement("calificacion", txtCalificacion.Text)
                );

            //Lo adicionamos al documento
            documento.Descendants("alumnos").First().Add(temp);

            //Actualizamps el textBox
            txtXML.Text = documento.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var resultados = from a in documento.Descendants("alumno")
                                 where (string)a.Element("curso") == txtBusqueda.Text
                                 select a.Element("calificacion").Value +" "+a.Element("curso").Value;

            //Construimos una cadena conla informacion
            string datos = "";
            foreach (var dato in resultados.Distinct())
                datos += string.Format("calificacion {0}\r\n", dato);

            //Mostramos el resultado
            MessageBox.Show(datos);
        }
    }
}

