using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad1.Clase2;

namespace Unidad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Clase1();

            //Clase2();// creo metodos para separar cada ejercicio del main y no hacer un main monolitito

            Parcial1();
        }

        private static void Clase2()
        {
            Console.WriteLine("Bienvenido al banco UAI");
            CajaAhorro cajaAhorro = new CajaAhorro();
            Console.WriteLine("Ingrese su numero de cuenta");
            cajaAhorro.NroCuenta = Convert.ToInt32(Console.ReadLine());// convierto un string a int32 (int)
            Console.WriteLine("Ingrese su nombre y apellido");
            cajaAhorro.Titular = Console.ReadLine(); // no necesito realizar conversion ya que readline devuelve un string
            Console.WriteLine("Ingrese el tipo de moneda: Pesos|Dolares");
            bool conversionOk = true;
            do
            {
                var conversionOK = Enum.TryParse(Console.ReadLine(), out CajaAhorro.TipoMonedaEnum tipoMoneda);
                if (conversionOK)
                    cajaAhorro.TipoMoneda = tipoMoneda;
            } while (!conversionOk);
            Console.WriteLine("Seleccione una Opcion:");
            Console.WriteLine("1-Extraer:");
            Console.WriteLine("2-Depositar:");
            Console.WriteLine("3-Saldo:");
            Console.WriteLine("4-Salir");
            
            int opcion = Convert.ToInt32(Console.ReadLine());
            do
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el monto a extraer");
                        var montoExtraccion = Convert.ToInt32(Console.ReadLine());
                        var mensajeExtraccion = cajaAhorro.Extraer(montoExtraccion);
                        Console.WriteLine(mensajeExtraccion);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a depositar");
                        var montoDeposito = Convert.ToInt32(Console.ReadLine());
                        var mensajeDeposito = cajaAhorro.Depositar(montoDeposito);
                        Console.WriteLine(mensajeDeposito);
                        break;
                        case 3:
                        //var mensajeSaldo = cajaAhorro.Saldo();
                        var mensajeSaldo = cajaAhorro.ConsultarSaldo();// puedo usar un metodo o la propiedad
                        Console.WriteLine(mensajeSaldo);
                        break;
                }
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Seleccione una Opcion:");
                Console.WriteLine("1-Extraer:");
                Console.WriteLine("2-Depositar:");
                Console.WriteLine("3-Saldo:");
                Console.WriteLine("4-Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

            } while (opcion >0 && opcion < 4);
            
            Console.ReadKey();// Esto evita que se cierre el programa
        }

        private static void Clase1()
        {
            /*
            //Tipo nombreDeObjeto = new Tipo();
            Clase clase1 = new Clase();
            //Ejemplo de propiedad Lecto/Escritura
            clase1.Propiedad = "POO";
            string valor = clase1.Propiedad;
            //
            //Ejemplo de propiedad de solo lectura
            var valor2 = clase1.Propiedad;
            clase1.Propiedad2 = "";
            //Propiedad de solo escritura
            clase1.Propiedad3 = valor2;
            var valor3 = clase1.Propiedad3;
            */
        }

        private static void Parcial1()
        { }
    }
}
