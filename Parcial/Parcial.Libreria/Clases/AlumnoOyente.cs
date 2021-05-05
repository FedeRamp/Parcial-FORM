using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class AlumnoOyente : Alumno
    {
        public AlumnoOyente(int registro, string nombre, string apellido)
        {
            this._registro = registro;
            this._nombre = nombre;
            this._apellido = apellido;
        }
    }
}
