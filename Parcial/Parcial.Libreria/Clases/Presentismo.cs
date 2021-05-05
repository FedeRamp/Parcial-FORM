using Parcial.Libreria.Excepciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.Libreria.Clases
{
    public class Presentismo
    {
        private List<Alumno> _alumnos;
        private List<Preceptor> _preceptores;
        private List<Asistencia> _asistencias;

        public List<Asistencia> asists { get => _asistencias; }

        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos", true));
            _preceptores.Add(new Preceptor(6, "Juan", "Gutierrez", false));

            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juárez", "cj@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "carla@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
        }


        public bool AsistenciaRegistrada(string fecha)
        {
             foreach(Asistencia asistencia in _asistencias)
             {
                if(asistencia.FechaAsistencia == fecha)
                {
                    return true;
                }
             }
            return false;
        }

        public List<Preceptor> Preceptores
        {
            get => this._preceptores;
        }
        public int GetCantidadAlumnosRegulares()
        {
            int resultado = 0;
            foreach(Alumno alumno in _alumnos)
            {
                if (alumno is AlumnoRegular) resultado++;
            }
            return resultado;
        }

        public Preceptor GetPreceptorActivo()
        {
            return _preceptores.Single(p => p.Activo == true) ;
        }

        public List<Alumno> GetListaAlumnos() 
        {
            if(this._alumnos.Count > 0)
            {
                return this._alumnos;
            } else
            {
                throw new SinAlumnosRegistradosException();
            }
        }

        public void AgregarAsistencia(List<Asistencia> asistencias)
        {
            foreach(Asistencia asistencia in asistencias)
            {
                _asistencias.Add(asistencia);
            }
        }

        public void AddAlumno(Alumno alumno)
        {
            if (_alumnos.SingleOrDefault(a => a.Registro == alumno.Registro) == null)
            {
                _alumnos.Add(alumno);
            } else
            {
                throw new Exception("Alumno ya registrado");
            }
        }

        public List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            List<Asistencia> resultado = new List<Asistencia>();
            foreach(Asistencia asistencia in _asistencias)
            {
                if(asistencia.FechaAsistencia == fecha)
                {
                    resultado.Add(asistencia);
                }
            }
            if (resultado.Count > 0)
            {
                return resultado;
            } else
            {
                throw new Exception("No se encontro registro en esa fecha");
            }
            

        }

        public void ActivarPreceptor(int legajo)
        {
            foreach(Preceptor preceptor in _preceptores)
            {
                if(preceptor.Legajo == legajo || preceptor.Activo)
                {
                    preceptor.CambiarActivo();
                }
            }
        }



    }
}
