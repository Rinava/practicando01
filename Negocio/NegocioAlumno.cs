using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;



namespace Negocio
{
    public class NegocioAlumno
    {
        public  List<EAlumno> RecuperarTodos()
        {
            //debo crear una instancia de adaptador alumno 
            AdaptadorAlumno alumnos = new AdaptadorAlumno();

            //devuelvo todos los alumnos que recuperó mi capa de datos de la base de datos mediante el adaptador de alumno
            return alumnos.RecuperarTodos();

        }

        public  EAlumno RecuperarUno(int id)
        {
            AdaptadorAlumno alumno = new AdaptadorAlumno();
            return alumno.RecuperarUno(id);
        }
    }
}
