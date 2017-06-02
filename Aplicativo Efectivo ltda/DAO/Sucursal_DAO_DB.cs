using Aplicativo_Efectivo_ltda.Connections;
using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.DAO
{
    public class Sucursal_DAO_DB : Sucursal_DAO
    {
        private Conexion_DB my_conexion_DB = null;

        public override List<Sucursal> Consultar_Sucursales()
        {
            Sucursal my_sucursal = null;
            List<Sucursal> my_list_sucursal = new List<Sucursal>();
            my_conexion_DB = new Conexion_DB();

            SqlCommand cmd = new SqlCommand("USP_Administrar_Sucursales");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDConsulta", "CONSULTAR_SUCURSALES");

            foreach(DataRow Row in my_conexion_DB.Consultar_SQLComand(cmd).Tables[0].Rows){
                my_sucursal = new Sucursal();
                my_sucursal.cod_sucursal = Convert.ToInt32(Row["Id_Sucusal"].ToString());
                my_sucursal.nom_sucursal = Row["Nom_Sucursal"].ToString();
                my_list_sucursal.Add(my_sucursal);
            }

            return my_list_sucursal;
        }
    }
}