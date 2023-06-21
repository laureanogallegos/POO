using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MultipleWinforms
{
    public class Categoria
    {
        private string codigo;
        private string nombre;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}
