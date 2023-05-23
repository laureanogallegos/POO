using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Parcial1TN
{
    internal class Estudiante : Pasajero
    {
        private string nombreInstitucion;
        private string numeroLegajo;
        public string NombreInstitucion
        {
            get { return nombreInstitucion; }
            set { nombreInstitucion = value; }
        }

        public string NumeroLegajo
        {
            get { return numeroLegajo; }
            set { numeroLegajo = value; }
        }
    }
}
