using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1
{
    internal class AutoConLimitadorVelocidad
    {
        #region Atributos
        private string _marca;
        private string _modelo;
        private int _velocidad;
        private int _velocidadMaxima;
        #endregion

        //Construnctor de la clase
        public AutoConLimitadorVelocidad()
        {
            //eventos
            AlExcederVelocidad += AutoConLimitadorVelocidad_AlExcederVelocidad;
        }

        #region Propiedades
        public string Marca { get => _marca; set => _marca = value; }
        public string Modelo { get => _modelo; set => _modelo = value; }
        public int VelocidadMaxima { get => _velocidadMaxima; set => _velocidadMaxima = value; }
        //Propiedad de solo lectura
        public int Velocidad { get => _velocidad; }

        #endregion

        //Declaracion de delegado (para crear un evento que permita enviar los parametros que necesito)
        private delegate void ExcesoVelocidadEventHandler(int velocidad);
        //Declaracion de evento
        private event ExcesoVelocidadEventHandler AlExcederVelocidad;
        #region Metodos
        public void Acelerar()
        {
            _velocidad++;
        }

        //Cuando existen dos métodos, pero cambia la firma (la cantidad y tipo de parametros) se llama sobrecarga
        public void Acelerar(int velocidad)
        {
            _velocidad += velocidad;
            if(_velocidad > _velocidadMaxima) AlExcederVelocidad(velocidad);
        }
        public void Desacelerar()
        {
            if (_velocidad >= 0) _velocidad--;
        }

        public void Desacelerar(int velocidad)
        {
            _velocidad =- velocidad;
            if (_velocidad >= 0) _velocidad = 0;
        }
        //Se puede definir que el comportamiento altera el estado de un objeto.


        //Metodo que se llamara cuando se produzca exceso de velocidad
        private void AutoConLimitadorVelocidad_AlExcederVelocidad(int velocidad)
        {
            Desacelerar(velocidad);
        }
        #endregion
    }
}
