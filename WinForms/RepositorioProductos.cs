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
        private List<Producto> productos; //atributo o variable de instancia

        public RepositorioProductos()//constructor de la clase
        {
            productos = new List<Producto>();
        }

        public string Agregar(Producto item)
        {
            if (item is null) return "Error al agregar el Producto.";
            var productoEncontrado = Buscar(item.Codigo);
            if (productoEncontrado == null)
            {
                productos.Add(item);
                return "El Producto se agregó correctamente.";
            }
            else return "El Producto ya existe";
        }

        public Producto Buscar(string parametro)
        {                                                           //Juan != juan
            return productos.FirstOrDefault(elemento => elemento.Codigo.ToLower() == parametro.ToLower());
        }

        public string Eliminar(Producto item)
        {
            productos.Remove(item);
            return "Producto eliminado correctamente";
        }

        public string EliminarProducto(string codigo)
        {
            var Producto = Buscar(codigo);
            if (Producto == null)
            {
                return "El producto no existe.";
            }
            else
            {
                productos.Remove(Producto);
                return "El producto se eliminó correctamente.";
            }
        }

        public ReadOnlyCollection<Producto> Listar()
        {
            return productos.AsReadOnly();
        }

        public string Modificar(Producto item)
        {
            return "El Producto se modificó correctamente.";
        }

        public string ModificarProducto(Producto item)//00001111
        {
            var productoEncontrado = Buscar(item.Codigo); //00001111
            if (productoEncontrado != null)
            {
                productoEncontrado = item;
                return "Producto modificado correctamente.";
            }
            else
            {
                return "Producto no encontrado";
            }
        }
    }
}
