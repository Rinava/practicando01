using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Entidades;
using System.Data;

namespace Datos
{
    public class AdaptadorAlumno:Adaptador
    {
        public  List<EAlumno> RecuperarTodos()
        {   //definimos la lista de alumnos
            List<EAlumno> Alumnos = new List<EAlumno>();

            try
            {
                //abro la conexion
                this.MiraComoTeAbroLaCon();

                //definimos el tipo de comando que necesitamos 
                SqlCommand comando = new SqlCommand("select * from Alumno ", sqlConexion);

                //ejecutamos el datareader sobre el comando que definimos 
                SqlDataReader drAlumnos = comando.ExecuteReader();

                while (drAlumnos.Read()) //mientras lea
                {   
                    //creo un alumno del tipo alumno definido en entidades
                    EAlumno alu = new EAlumno();

                    //relleno los atributos de 1 Alumno
                    alu.ApeNom = (string)drAlumnos["Ape_nom"];
                    alu.FechaNac = (DateTime)drAlumnos["Fecha_Nac"];
                    alu.Id = (int)drAlumnos["Id"];
                    alu.Email = (string)drAlumnos["Email"];
                    alu.NotaAvg = (decimal)drAlumnos["Nota_avg"];
                    

                    //añado a mi lista de alumnos 1 alumno
                    Alumnos.Add(alu);
                }
                //cierro el data reader y la conexion
                drAlumnos.Close();
                this.MiraComoTeCierroLaCon();}
            catch(Exception ex) { Exception ExcepcionManejada = new Exception("No se lograron recuperar los alumnos", ex);}
            return Alumnos;
        }
        public EAlumno RecuperarUno(int id)
        {
            this.MiraComoTeAbroLaCon(); //abro la conexion
            SqlCommand comando = new SqlCommand("select * from Alumno where @id=Id",sqlConexion);
            comando.Parameters.Add("@id", SqlDbType.Int).Value = id; //using System.Data
            SqlDataReader drAlumno = comando.ExecuteReader();
            EAlumno alu = new EAlumno();
            alu.ApeNom = (string)drAlumno["Ape_nom"];
            alu.FechaNac = (DateTime)drAlumno["Fecha_Nac"];
            alu.Id = (int)drAlumno["Id"];
            alu.Email = (string)drAlumno["Email"];
            alu.NotaAvg = (decimal)drAlumno["Nota_avg"];
            return alu;
            
        }
    }
}
