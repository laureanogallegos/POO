using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.Parcial1TN
{
    internal class Jubilado : Pasajero
    {
        private string numeroAfiliado;
        public string NumeroAfiliado
        {
            get { return numeroAfiliado;}
            set { numeroAfiliado = value;}
        }
    }
}
