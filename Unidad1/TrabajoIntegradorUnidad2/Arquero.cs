namespace Unidad1.TrabajoIntegradorUnidad2
{
    internal class Arquero : Jugador
    {
        private int altura;
        public int Altura
        { 
            get { return altura; }
            set { altura = value; }
        }
        public override string ToString()
        {
            return $"***********************\r\nArquero:\r\nNombre y Apellido: {base.Nombre} {base.Apellido}\r\nFecha de nacimiento: {base.FechaNacimiento}\r\nEdad: {base.Edad}\r\nAltura:{altura}\r\n";
        }
    }
}
