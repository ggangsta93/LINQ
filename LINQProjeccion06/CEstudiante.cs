using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProjeccion06
{
    class CEstudiante
    {
        private string nombre;
        private string id;
        private string curso;
        private double promedio;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public string Curso { get => curso; set => curso = value; }
        public double Promedio { get => promedio; set => promedio = value; }


        public CEstudiante(string pNombre, string pId, string pcurso,double pPromedio)
        {
            this.nombre = pNombre;
            this.id = pId;
            this.curso = pcurso;
            this.promedio = pPromedio;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, {1}, curso: {2}, promedio: {3}",nombre,id,curso,promedio);
        }

    }
}
