using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    internal class RepositorioProductos : IAltaBajaModificacion<Producto>
    {
        public string Agregar(Producto item)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public string Modificar(Producto item)
        {
            throw new NotImplementedException();
        }
    }
}
