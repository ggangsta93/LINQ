using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQOperadores13
{
    class CEstudiante
    {
        private string nombre;
        private int id;
        public CEstudiante(string pNombre, int pID)
        {
            Nombre = pNombre;
            Id = pID;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("Estudiante {0}, {1}",nombre,id);
        }
    }
}
