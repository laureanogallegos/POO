namespace Unidad1.TrabajoIntegradorUnidad2
{
    internal class Mediocampista : Jugador
    {
        private int cantidadAsistencias;
        public int CantidadAsistencias
        {
            get { return cantidadAsistencias; }
            set { cantidadAsistencias = value; }
        }
        public override string ToString()
        {
            return "";// $"***********************\r\nArquero:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.FechaNacimiento}\r\nEdad: {base.Edad}\r\Cantidad de asistencias:{cantidadAsistencias}\r\n";
        }
    }
}
