using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Unidad1.TrabajoIntegradorUnidad1
{
    internal class ListaDeAlumnos
    {
        private List<Alumno> listaAlumnos;//Atributo--> declaro una  variable a nivel de clase para que el alcance sea para todos los miembros

        public ListaDeAlumnos()
        {
            listaAlumnos = new List<Alumno>();//Instancio dela clase List<Alumno> y lo almaceno en la variable listaAlumnos
        }

        /// <summary>
        /// Permite agregar un alumno siempre y cuando el numero de legajo no exista
        /// </summary>
        /// <param name="alumno"></param>
        public string AgregarAlumno(Alumno alumno)
        {
            //el método FirstOrDefault devuelve la primer  coincidencia o devuelve null si no encuentra ningun elemento.
            //alumnoExistente es el nombre de la variable que utilizo dentro del metodo para indicar que de esa variable voy a 
            //utilizar el NumeroLegajo para comparar con el numero de legajo del alumno que quiero agregar. Si coincide es porque ya existe y
            //no deberia poder agregarlo, caso contrario lo agreglo a la listaAlumno
            var alumnoExiste = listaAlumnos.FirstOrDefault(alumnoExistente => alumnoExistente.NumeroLegajo == alumno.NumeroLegajo);
            if (alumnoExiste != null)//si el alumno es distinto de null existe entonces deberia mostrar un mensaje indicando queno se puede ingresar
            {                        // el alumno
                return $"La operacion no se puede completar. El numero de legajo {alumno.NumeroLegajo} ya existe.";
            }
            else
            {
                listaAlumnos.Add(alumno);
                return $"El alumno {alumno.Nombre} {alumno.Apellido} ha sido registrado correctamente";
            }
        }

        public ReadOnlyCollection<Alumno> ListarAlumnos()
        {
            return listaAlumnos.AsReadOnly();
        }

        public string QuitarAlumno(Alumno alumno)
        {
            var alumnoQuitado = listaAlumnos.Remove(alumno);
            if (alumnoQuitado) return $"El alumno {alumno.Nombre} {alumno.Apellido} fue quitado del listado correctamente";
            return $"El alumno {alumno.Nombre} {alumno.Apellido} no existe en el listado";
        }

        public string QuitarAlumno(string numeroLegajo)
        {
            var alumnoExiste = listaAlumnos.FirstOrDefault(alumnoExistente => alumnoExistente.NumeroLegajo == numeroLegajo);
            if (alumnoExiste != null)
            {
                listaAlumnos.Remove(alumnoExiste);
                return $"El alumno {alumnoExiste.Nombre} {alumnoExiste.Apellido} ha sido registrado correctamente";
            }
            else
            {
                return $"La operacion no se puede completar. El numero de legajo {numeroLegajo} no existe.";
            }
        }
    }
}