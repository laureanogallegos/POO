namespace Unidad1.Clase2
{
    internal class CajaAhorro
    {
        private int nroCuenta;
        private int saldo;
        private string titular;
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

        public string Titular
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
                return $"Se ha extraido {monto} {tipoMoneda}";
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
                return $"Se ha depositado {monto} {tipoMoneda}";   
            }
        }

        public string ConsultarSaldo()
        {
            return $"El saldo en {tipoMoneda} es de :{saldo}"; //este tipo de concatenacion se denomina string interpolation
        }
    }
}
