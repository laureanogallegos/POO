using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Clase4
{
    internal class CajaAhorro
    {
        //Constructor de la clase || este método se ejecuta cada vez que  se instancia de la clase.
        //la sintaxis es la siguiente
        //Visibilidad NombreDeClase()   Si el constructor lleva parametros se lo denomina constructor parametrizado
        //{
        //}

        //SI EXPLICITAMENTE DECLARO UN CONSTRUCTOR PARAMETRIZADO y quiero a su vez instanciar la mism clase sin parametros voy a tener 
        //que declarar un constructor sin parametros, por ejemplo:

        //public CajaAhorro()
        //{
        //}

        //En este caso vamos a crear cajas de ahorro que tengan X pesos de regalo.

        public CajaAhorro(int montoInicial) //recibimos como parametro el monto deseado y ese mismo se suma al saldo, por ende nos aseguramos que cuando se 
        {                                   //cree la caja de ahorro siempre tenga un monto inicial
            saldo += montoInicial;
        }

        public CajaAhorro(int montoInicial, Titular titular)// en este caso el constructor esta tambien sobrecargado, el nombre se mantiene cambia la cantidad
        {                                                   //de parametros. En este caso me aseguro que cuando creo la caja de ahorro y a este asociada a un titular
                                                            //y tenga un monto
            this.saldo += montoInicial;
            this.titular = titular;
        }


        private int nroCuenta;
        private int saldo;
        private Titular titular;
        private TipoMonedaEnum tipoMoneda;
        public enum TipoMonedaEnum { Dolares, Pesos };// el enum permite seleccionar entre los valores definidos dentro de la enumaeracion


        public int NroCuenta
        {
            get { return nroCuenta; }
            set { nroCuenta = value; }
        }
        public int Saldo
        {
            get { return saldo; }
        }

        public Titular Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public TipoMonedaEnum TipoMoneda
        {
            get { return tipoMoneda; }
            set { tipoMoneda = value; }
        }

        public string Extraer(int monto)
        {
            if (monto < 0)
            {
                return "El monto: " + monto + "debe ser mayor que cero."; //Forma mas comun de concatenar strings
            }
            else if (monto <= saldo)
            {
                saldo -= monto;
                return $"{titular} ha extraido {monto} {tipoMoneda}";
            }
            else
                return "No hay saldo suficiente para realizar la extracción";// cuando solamente tengo una sola instruccion dentro del if o el else
                                                                             // no es necesario ponerlo entre llaves
        }

        public string Depositar(int monto)
        {
            if (monto < 0)
            {
                return "El monto: " + monto + "debe ser mayor que cero."; //Forma mas comun de concatenar strings
            }
            else
            {
                saldo += monto;
                return $"{titular} ha depositado {monto} {tipoMoneda}";
            }
        }

        public string ConsultarSaldo()
        {
            return $"El saldo en {tipoMoneda} es de :{saldo}"; //este tipo de concatenacion se denomina string interpolation
        }

        //A su vez como tenemos constructores, tambien tenemos destructores que se encargan de limpiar los recursos utilizados por la clase,
        //Actualmente existe el Garbage Collector propio del Framework que se encarga de lo mismo, no podemos invocar al destructor pero si declararlo
        //por si necesitamos eliminar otros recursos utilizados


        //Sintaxis deldestructor
        //~NombreDeClase()
        //{}


        ~CajaAhorro() //destructor
        {
        }

    }
}
