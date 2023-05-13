namespace Unidad1.TrabajoIntegradorUnidad2
{
    internal class Delantero : Jugador
    {
        private int cantidadGoles;
        public int CantidadGoles
        {
            get { return cantidadGoles; }
            set { cantidadGoles = value; }
        }
        public override string ToString()
        {
            return $"***********************\r\nArquero:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.FechaNacimiento}\r\nEdad: {base.Edad}\r\nCantidad de goles:{cantidadGoles}\r\n";
        }
    }
}
