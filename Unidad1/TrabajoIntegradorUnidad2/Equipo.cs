using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Unidad1.TrabajoIntegradorUnidad2
{
    internal class Equipo
    {
        private string nombre;
        private List<Jugador> jugadores;
        private const int cantidadMaximaArqueros = 3;
        private const int cantidadMaximaDefensores = 6;
        private const int cantidadMaximaMediocampistas = 5;
        private const int cantidadMaximaDelanteros = 4;
        private int cantidadArqueros;
        private int cantidadDefensores;
        private int cantidadMediocampistas;
        private int cantidadDelanteros;

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public Equipo()
        {
            jugadores = new List<Jugador>();   
        }

        public string RegistrarJugador(Jugador jugador)
        {
            if (jugador is Arquero)
            {
                if (cantidadMaximaArqueros > cantidadArqueros)
                {
                    jugadores.Add(jugador);
                    cantidadArqueros++;
                    return $"El arquero {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas arqueros";
            }
            else if (jugador is Defensor)
            {
                if (cantidadMaximaDefensores > cantidadDefensores)
                {
                    jugadores.Add(jugador);
                    cantidadDefensores++;
                    return $"El defensor {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas defensores";
            }
            else if (jugador is Mediocampista)
            {
                if (cantidadMaximaMediocampistas > cantidadMediocampistas)
                {
                    jugadores.Add(jugador);
                    cantidadMediocampistas++;
                    return $"El mediocampista {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas mediocampistas";
            }
            else 
            {
                if (cantidadMaximaDelanteros > cantidadDelanteros)
                {
                    jugadores.Add(jugador);
                    cantidadDelanteros++;
                    return $"El delantero {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas delanteros";
            }
        }
        
        public string RegistrarJugadorV2(Jugador jugador)
        {
            if (jugador is Arquero)
            {
                if (jugadores.OfType<Arquero>().Count() < cantidadMaximaArqueros)
                {
                    jugadores.Add(jugador);
                    return $"El arquero {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas arqueros";
            }
            else if (jugador is Defensor)
            {
                if (jugadores.OfType<Defensor>().Count() < cantidadMaximaDefensores)
                {
                    jugadores.Add(jugador);
                    return $"El defensor {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas defensores";
            }
            else if (jugador is Mediocampista)
            {
                if (jugadores.OfType<Mediocampista>().Count() < cantidadMaximaMediocampistas)
                {
                    jugadores.Add(jugador);
                    return $"El mediocampista {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas mediocampistas";
            }
            else 
            {
                if (jugadores.OfType<Delantero>().Count() < cantidadMaximaDelanteros)
                {
                    jugadores.Add(jugador);
                    return $"El delantero {jugador.Nombre} {jugador.Apellido} ha sido registrado correctamente.";
                }
                else return "No se pueden registrar mas delantero";
            }
        }
        public ReadOnlyCollection<Jugador> ListarJugadores()
        {
            return jugadores.AsReadOnly();
        }
        public ReadOnlyCollection<string> ListarJugadoresV2()
        {
            var listaJugadores = new List<string>();
            foreach (var item in jugadores)
            {
                listaJugadores.Add(item.ToString());
            }
            return listaJugadores.AsReadOnly();
        }
    }
}
