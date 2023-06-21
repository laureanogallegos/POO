using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleWinforms
{
    internal class Producto
    {
        private Categoria categoria;
        private int codigo;
        private decimal precioCompra;
        private decimal precioVenta;
        private int cantidad;
        public Categoria Categoria { get => categoria; set => categoria = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public decimal PrecioCompra { get => precioCompra; set => precioCompra = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
    }
}
