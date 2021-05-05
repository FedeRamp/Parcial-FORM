using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class Preceptor : Persona
    {
        private int _legajo;
        private bool _activo;

        public Preceptor(int legajo,string nombre ,string apellido,bool activo)
        {
            this._legajo = legajo;
            this._nombre = nombre;
            this._apellido = apellido;
            this._activo = activo;
        }

        public bool Activo { get => _activo; }
        public int Legajo { get => _legajo; }

        public void CambiarActivo()
        {
            if (this._activo)
            {
                _activo = false;
            } else
            {
                _activo = true;
            }
        }
        internal override string Display()
        {
            return $"{this._apellido} {this._legajo}";
        }
    }
}
