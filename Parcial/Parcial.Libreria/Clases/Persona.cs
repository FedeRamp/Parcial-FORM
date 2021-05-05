using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;

        public override string ToString()
        {
            return Display();
        }
        internal virtual string Display()
        {
            return "";
        }
    }
}
