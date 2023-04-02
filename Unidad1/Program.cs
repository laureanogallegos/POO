using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tipo nombreDeObjeto = new Tipo();
            Clase clase1 = new Clase();
            //Ejemplo de propiedad Lecto/Escritura
            clase1.Propiedad = "POO";
            string valor = clase1.Propiedad;
            //
            //Ejemplo de propiedad de solo lectura
            var valor2 = clase1.Propiedad;
            clase1.Propiedad2 = "";
            //
            //Propiedad de solo escritura
            clase1.Propiedad3= valor2;
            var valor3 = clase1.Propiedad3;

        }
    }
}
