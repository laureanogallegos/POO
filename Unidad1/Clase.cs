using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//la palabra reservada using permite referenciar espacios de nombre dentro de la clase física, esto es poder utilizar clases de otra libreria.


//el namespace actua como contenedor de clases 
namespace Unidad1
{
    //Visibilidad palabrareservada NombreDeLaClase
    internal class Clase
    {
        //Constructor de la clase este metodo no tiene tipo de retorno y se ejecuta cuando se crea (instancia) un objeto de una clase.
        //Si no lleva parametros o si no se necesita inicializar alguna variable no es necesario declararlo. (el compilador lo ejecuta implicitamente)
        public Clase()
        {
        }

        //Atributo de clase, permite almacenar un valor del tipo especificado (string)
        //Visibilidad Tipo_de_dato _nombreAtributo;
        //Al ser privado solo puede accederse dentro de la clase
        private string _atributo;

        //Propiedad de la clase, permite acceder y leer o escribir sobre la variable a la que hace referencia.
        //Visibilidad Tipo_de_dato Propiedad { accesor get(permite devolver un valor); accesor set(permite establecer un valor); }
        //En este caso la propiedad Propiedad es de lecto/escritura
        public string Propiedad { get => _atributo; set => _atributo = value; }

        //Propiedad de solo lectura, no se puede establer un valor, esto es una  forma de encapsulamiento
        public string Propiedad2 { get => _atributo; }

        //Propiedad de solo escritura
        public string Propiedad3 { set => _atributo = value; }

        //Destructor de la clase, se ejecuta al eliminarse el objeto, permite eliminar recursos innecesarios
        //Actualmente el GarbageCollector se encarga de la destruccion de los ebjetos y limpieza de recursos.
        ~Clase() 
        {
        }
    }
}
