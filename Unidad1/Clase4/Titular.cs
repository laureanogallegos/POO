using System;

namespace Unidad1.Clase4
{
    internal class Titular
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int dni;
        public string Nombre
        { 
            get { return nombre; } 
            set { nombre = value; } 
        }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime FechaNacimiento
        {   
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }
        public int Edad
        {
            get => (int)Math.Floor((DateTime.Now - fechaNacimiento).TotalDays / 365.25D);
        }
    }
}
