using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.TrabajoIntegradorUnidad1
{
    internal class Alumno
    {
        private string numeroLegajo;
        private string nombre;
        private string apellido;
        
        public string NumeroLegajo 
        {
            get { return numeroLegajo; }
            set { numeroLegajo = value; } 
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido 
        {
            get { return apellido; }
            set { apellido = value; } 
        }
    }
}
