using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Excepciones
{
    class SinAlumnosRegistradosException : Exception
    {
        public override string Message => "No hay alumnos para mostrar";
    }
}
