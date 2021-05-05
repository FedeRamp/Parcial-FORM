using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class Asistencia
    {
        private string _fechaAsistencia;
        private DateTime _fechaHoraReal;
        private Alumno _alumno;
        private Preceptor _preceptor;
        private bool _estaPresente;

        public Asistencia(DateTime fechaHoraReal, Alumno alumno, Preceptor preceptor, bool estaPresente)
        {
            _fechaAsistencia = fechaHoraReal.ToString("yyyy-MM-dd");
            _fechaHoraReal = fechaHoraReal;
            _alumno = alumno;
            _preceptor = preceptor;
            _estaPresente = estaPresente;
        }

        public string FechaAsistencia { get => _fechaAsistencia; }
        public Alumno Alumno { get => _alumno;}
        public Preceptor Preceptor { get => _preceptor;}
        public bool EstaPresente { get => _estaPresente;}

        public override string ToString()
        {
            string siNo = _estaPresente ? "Si" : "No";
            return $"{this._fechaAsistencia}, {this._alumno.ToString()} está presente: {siNo} por" +
                $" {this._preceptor.ToString()} registrado el {this._fechaHoraReal}";
        }
    }
}
