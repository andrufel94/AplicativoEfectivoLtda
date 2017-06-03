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
    public class Cliente_Empresa_DAO_DB : Cliente_Empresa_DAO
    {
        private Conexion_DB my_conexion_DB = null;

        public override List<Models.Cliente_Empresa> Consultar_Clientes_Empresas()
        {
            Cliente_Empresa my_cliente_empresa = null;
            List<Cliente_Empresa> my_list_cliente_empresa = new List<Cliente_Empresa>();
            my_conexion_DB = new Conexion_DB();

            SqlCommand cmd = new SqlCommand("USP_Administrar_Clientes");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDConsulta", "CONSULTAR_PERSONAS_EMPRESA");

            foreach (DataRow Row in my_conexion_DB.Consultar_SQLComand(cmd).Tables[0].Rows)
            {
                my_cliente_empresa = new Cliente_Empresa();
                my_cliente_empresa.cod_cliente_empresa = Convert.ToInt32(Row["Id_Cliente_Empresa"].ToString());
                my_cliente_empresa.nom_cliente_empresa = Row["Nom_Cliente_Empresa"].ToString();
                my_list_cliente_empresa.Add(my_cliente_empresa);
            }

            return my_list_cliente_empresa;
        }
    }
}