using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Parcial1TN
{
    internal class Pasajero
    {
        private string nombre;
        private string apellido;
        private string dni;

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
        
        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }
    }
}
