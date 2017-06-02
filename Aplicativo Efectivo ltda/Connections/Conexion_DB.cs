using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aplicativo_Efectivo_ltda.Connections
{
    public class Conexion_DB
    {
        private string conenection_string = ConfigurationManager.ConnectionStrings["myConnection_Local"].ToString();
        private SqlConnection _con = null;

        #region Ejecutar Query SQL retornando un scalar
        public string Ejecutar_SQLComand(SqlCommand sql_cmd)
        {
            string result = "";

            try
            {
                _con = new SqlConnection(conenection_string);
                
                SqlCommand _cmd = sql_cmd;
                _cmd.Connection = _con;

                _con.Open();
                result = _cmd.ExecuteScalar().ToString();

                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                return "Error: " + result;
            }
            finally
            {
                _con.Close();
            }
        }
        #endregion

        #region Ejecutar Consulta SQL
        public DataSet Consultar_SQLComand(SqlCommand sql_cmd)
        {
            DataSet ds = null;
            SqlConnection _con = new SqlConnection(conenection_string);
            try
            {
                SqlCommand _cmd = sql_cmd;
                _cmd.Connection = _con;

                _con.Open();

                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = _cmd;
                ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                return ds;
            }
            finally
            {
                _con.Close();
            }
        }
        #endregion
    }
}