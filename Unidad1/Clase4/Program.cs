using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Clase4
{
    internal class Program
    {
        static void Main()
        {
            //creamos el objeto titular y lo completamos con datos
            Titular titular = new Titular();
            titular.Dni = 28712568;
            titular.Nombre = "Laureano";
            titular.Apellido = "Gallegos";
            titular.FechaNacimiento = Convert.ToDateTime(28/03/1981);

            CajaAhorro caja = new CajaAhorro(15000);
            //o tambien 
            CajaAhorro cajaConTitular = new CajaAhorro(10000, titular);


        }           
    
    }
}
