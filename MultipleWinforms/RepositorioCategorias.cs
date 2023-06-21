using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleWinforms
{
     //clase
    public class RepositorioCategorias : IAltaBajaModificacion<Categoria>  //interfaz
    {
        private List<Categoria> categorias; //atributo o variable de instancia

        public RepositorioCategorias()//constructor de la clase
        {
            categorias = new List<Categoria>(); categorias.Add(new Categoria() { Codigo = "11332", Nombre = "Zapatos" });
        }

        public string Agregar(Categoria item)
        {
            if (item is null) return "Error al agregar la categoria.";
            var categoriaEncontrada = Buscar(item.Codigo);
            if (categoriaEncontrada == null)
            {
                categorias.Add(item);
                return "La categoria se agregó correctamente.";
            }
            else return "La categoria ya existe";
        }

        public Categoria Buscar(string parametro)
        {                                                           //Juan != juan
            return categorias.FirstOrDefault(elemento => elemento.Codigo.ToLower() == parametro.ToLower());
        }

        public string Eliminar(Categoria item)
        {
            categorias.Remove(item);
            return "Categoria eliminada correctamente";
        }

        public string EliminarCategoria(string codigo)
        {
            var categoria = Buscar(codigo);
            if (categoria == null)
            {
                return "La categoría no existe.";
            }
            else
            {
                categorias.Remove(categoria);
                return "La categoría se eliminó correctamente.";
            }
        }

        public ReadOnlyCollection<Categoria> Listar()
        {
            return categorias.AsReadOnly();
        }

        public string Modificar(Categoria item)
        {
            return "La categoria se modificó correctamente.";
        }

        public string ModificarCategoria(Categoria item)//00001111
        {
            var categoriaEncontrada = Buscar(item.Codigo); //00001111
            if (categoriaEncontrada != null)
            {
                categoriaEncontrada = item;
                return "Categoria modificada correctamente.";
            }
            else
            {
                return "Categoría no encontrada";
            }
        }
    }
}
