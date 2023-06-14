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

        internal Categoria Categoria { get => categoria; set => categoria = value; }
    }
}
