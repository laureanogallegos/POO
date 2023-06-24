using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class Producto
    {
        private Categoria categoria;
        private string codigo;
        private string nombre;
        private decimal precioCompra;
        private decimal precioVenta;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        internal Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
