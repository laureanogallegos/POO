using System;

namespace Unidad1.TrabajoIntegradorUnidad2
{
    internal abstract class Jugador
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
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
        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value;}
        }
        public int Edad
        {
            get 
            {
                var edad = DateTime.Now.Year - fechaNacimiento.Year;
                if (fechaNacimiento.DayOfYear > DateTime.Now.DayOfYear)
                   edad--;
                return edad;
            }
        }
    }
}
