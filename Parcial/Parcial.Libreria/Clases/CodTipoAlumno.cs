using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class CodTipoAlumno
    {
        private int codigo;
        private string descripcion;

        public CodTipoAlumno(int codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }

        public int Codigo { get => codigo; }
        public string Descripcion { get => descripcion; }
    }
}
