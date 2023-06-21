using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleWinforms
{
    internal interface IAltaBajaModificacion<T>
    {
        string Agregar(T item);
        string Modificar(T item);
        string Eliminar(T item);
        ReadOnlyCollection<T> Listar();
        T Buscar(string parametro);
    }
}
