using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class Alumno : Persona
    {
        protected int _registro;

        public int Registro
        {
            get
            {
                return _registro;
            }
        }


        internal override string Display()
        {
            return $"{this._nombre}, {this._apellido} {this._registro}";
        }
    }
}
