using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleWinforms
{
    internal class RepositorioProductos : IAltaBajaModificacion<Producto>
    {
        private List<Producto> productos;

        public RepositorioProductos()
        {
            productos = new List<Producto>();
        }

        public string Agregar(Producto item)
        {
            productos.Add(item);
            return "Producto agregado exitosamente.";
        }

        public Producto Buscar(string parametro)
        {
            throw new NotImplementedException();
        }

        public string Eliminar(Producto item)
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<Producto> Listar()
        {
            return productos.AsReadOnly();
        }

        public string Modificar(Producto item)
        {
            throw new NotImplementedException();
        }
    }
}
