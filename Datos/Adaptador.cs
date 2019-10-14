using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;//no olvidar los using
using System.Configuration;// ni las referencias 

namespace Datos
{
    public class Adaptador
    {
        const string nameStrConPorDefecto = "NetGenerica";
        protected SqlConnection sqlConexion { get; set; }

        protected void MiraComoTeAbroLaCon()
        {
            //busco dentro de mis strings de conexion la que tenga el name que puse por default
            string strCon = ConfigurationManager.ConnectionStrings[nameStrConPorDefecto].ConnectionString; 

            //defino mi conexion con el string que encontre de conexion
            sqlConexion = new SqlConnection(strCon);

            //abro la conexion
            sqlConexion.Open();
        }

        protected void MiraComoTeCierroLaCon()
        {
            //en esta casa las cosas que se abren se pueden cerrar
            sqlConexion.Close();

            //guardala como nula pls pa el proximo que venga
            sqlConexion = null;
        }
    }
}
