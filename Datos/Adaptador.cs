using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//no olvidar los using
using System.Configuration;// ni las referencias 

namespace Datos
{
    public class Adaptador
    {
        const string nameStrConPorDefecto = "NetGenericaa";
        protected SqlConnection SqlConexion { get; set; }

        protected void MiraComoTeAbroLaCon()
        {
            //busco dentro de mis strings de conexion la que tenga el name que puse por default
            string strCon = ConfigurationManager.ConnectionStrings[nameStrConPorDefecto].ConnectionString; 

            //defino mi conexion con el string que encontre de conexion
            SqlConexion = new SqlConnection(strCon);

            //abro la conexion
            SqlConexion.Open();
        }

        protected void MiraComoTeCierroLaCon()
        {
            //en esta casa las cosas que se abren se pueden cerrar
            SqlConexion.Close();

            //guardala como nula pls pa el proximo que venga
            SqlConexion = null;
        }
    }
}
