namespace Unidad1.TrabajoIntegradorUnidad2
{
    internal class Defensor : Jugador
    {
        private int cantidadTarjetasAmarillas;
        private int cantidadTarjetasRojas;

        public int CantidadTarjetasAmarillas 
        {
            get { return cantidadTarjetasAmarillas; }
            set { cantidadTarjetasAmarillas = value; }
        }

        public int CantidadTarjetasRojas
        {
            get { return cantidadTarjetasRojas; }
            set { cantidadTarjetasRojas = value; }
        }
        public override string ToString()
        {
            return $"***********************\r\nArquero:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.FechaNacimiento}\r\nEdad: {base.Edad}\r\nCantidad de tarjetas amarillas:{cantidadTarjetasAmarillas}\r\nCantidad de tarjetas rojas:{cantidadTarjetasRojas}\r\n";
        }
    }
}
