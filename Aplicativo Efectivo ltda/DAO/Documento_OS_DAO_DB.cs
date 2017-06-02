using Aplicativo_Efectivo_ltda.DAO;
using Aplicativo_Efectivo_ltda.Connections;
using Aplicativo_Efectivo_ltda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Aplicativo_Efectivo_ltda.DAO
{
    public class Documento_OS_DAO_DB : Documento_OS_DAO
    {
        private Conexion_DB my_conexion_DB = null;

        public override string Insertar_Documento_OS(Documento_OS obj_documento)
        {
            string result = "";

            my_conexion_DB = new Conexion_DB();

            SqlCommand cmd = new SqlCommand("USP_Administrar_Documentos");
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IDConsulta", "INSERTAR_DOCUMENTO");
            cmd.Parameters.AddWithValue("@Id_Sucursal_Origen", obj_documento.cod_sucursal_origen);
            cmd.Parameters.AddWithValue("@Id_Cliente_Persona_Origen", obj_documento.cod_persona_remitente);
            cmd.Parameters.AddWithValue("@Valor", obj_documento.valor);
            cmd.Parameters.AddWithValue("@Id_Sucursal_Destino", obj_documento.cod_sucursal_destino);
            cmd.Parameters.AddWithValue("@Id_Cliente_Persona_Destino", obj_documento.cod_persona_destino);
            cmd.Parameters.AddWithValue("@Tipo_Documento", "OS");

            result = my_conexion_DB.Ejecutar_SQLComand(cmd);

            return result;
        }
    }
}