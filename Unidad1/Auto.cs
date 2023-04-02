using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1
{
    internal class Auto
    {
        #region Atributos
        private string _marca;
        private string _modelo;
        private int _velocidad;
        #endregion

        #region Propiedades
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        //Propiedad de solo lectura
        public int Velocidad { get => _velocidad; }
        #endregion

        #region Metodos
        public void Acelerar()
        {
            _velocidad++;
        }

        //Cuando existen dos métodos, pero cambia la firma (la cantidad y tipo de parametros) se llama sobrecarga
        public void Acelerar(int velocidad)
        {
            _velocidad += velocidad;
        }
        public void Desacelerar()
        {
            if (_velocidad >= 0) _velocidad--;
        }
        //Se puede definir que el comportamiento altera el estado de un objeto.
        #endregion
    }
}
