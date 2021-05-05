using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Excepciones
{
    class AsistenciaExistenteEseDiaException : Exception
    {
        public override string Message => "Ya se tomo asistencia ese dia";
    }
}
