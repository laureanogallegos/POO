using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Unidad1.Parcial1TN
{
    internal class Colectivo
    {
        private string marca;
        private string modelo;
        private string añoDeFabribracion;
        private int costoBoleto;
        private readonly int capacidadMaxima = 40;
        private readonly List<Pasajero> pasajeros;
        private int montoTotalBoletos;

        public Colectivo()
        {
            pasajeros = new List<Pasajero>();
        }
        public Colectivo(int capacidadMaxima)
        {
            this.capacidadMaxima = capacidadMaxima;
            pasajeros = new List<Pasajero>();
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        
        public string Modelo 
        {
            get { return modelo; }
            set { modelo = value; }
        }
        
        public string AñoDeFabricacion
        {
            get { return añoDeFabribracion; }
            set { añoDeFabribracion = value; }
        }
        
        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
        }

        public int CostoBoleto
        {
            get { return costoBoleto; }
            set { costoBoleto = value; }
        }

        public int CantidadPasajeros()
        {
            return pasajeros.Count;
        }

        public int MontoTotalPasajesVendidos()
        {
            return montoTotalBoletos;
        }

        public ReadOnlyCollection<Pasajero> ListarPasajeros()
        {
            return pasajeros.AsReadOnly();
        }

        public string VenderBoleto(Pasajero pasajero)
        {
            if (pasajeros.Count < capacidadMaxima)
            {
                var pasajeroExiste = pasajeros.FirstOrDefault(pasajeroExistente => pasajeroExistente.DNI.ToLower() == pasajeroExistente.DNI.ToLower());
                if (pasajeroExiste == null)
                {
                    var costoBoletoAbonar = 0;
                    pasajeros.Add(pasajero);
                    if (pasajero is Estudiante)
                    {
                        costoBoletoAbonar = Convert.ToInt32(costoBoleto / 0.5);
                        montoTotalBoletos += costoBoletoAbonar;
                    }
                    else if (pasajero is Pasajero)
                    {
                        montoTotalBoletos += costoBoleto;
                    }
                    return $"El pasajero {pasajero.Nombre} {pasajero.Apellido} debe abonar {costoBoletoAbonar}";
                }
                else
                {
                    return $"El pasajero {pasajero.Nombre} {pasajero.Apellido} con DNI: {pasajero.DNI} ya se encuentra registrado";
                }
            }
            else
            {
                return $"No se pueden vender mas boletos, se alcanzó la capacidad máxima permitida.";
            }
        }
    }
}
