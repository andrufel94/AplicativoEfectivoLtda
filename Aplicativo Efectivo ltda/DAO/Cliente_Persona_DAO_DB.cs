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
    public class Cliente_Persona_DAO_DB : Cliente_Persona_DAO
    {
        private Conexion_DB my_conexion_DB = null;

        public override List<Cliente_Persona> Consultar_Clientes_Personas()
        {
            Cliente_Persona my_cliente_persona = null;
            List<Cliente_Persona> my_list_cliente_persona = new List<Cliente_Persona>();
            my_conexion_DB = new Conexion_DB();

            SqlCommand cmd = new SqlCommand("USP_Administrar_Clientes");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDConsulta", "CONSULTAR_PERSONAS_CLIENTE");

            foreach (DataRow Row in my_conexion_DB.Consultar_SQLComand(cmd).Tables[0].Rows)
            {
                my_cliente_persona = new Cliente_Persona();
                my_cliente_persona.cod_cliente_persona = Convert.ToInt32(Row["Id_Cliente_Persona"].ToString());
                my_cliente_persona.num_identificacion = Row["Num_Identificacion"].ToString();
                my_cliente_persona.nom_cliente_persona = Row["Nom_Cliente_Persona"].ToString();
                my_list_cliente_persona.Add(my_cliente_persona);
            }

            return my_list_cliente_persona;
        }

    }
}