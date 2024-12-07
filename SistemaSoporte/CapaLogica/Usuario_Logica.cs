using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using SistemaSoporte.CapaModelo;
using Microsoft.SqlServer.Server;

namespace SistemaSoporte.CapaLogica
{
    public class Usuario_Logica
    {

        public static int Agregar( string nombre, string Estado)
        {
            int retorno = 0;
           
            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = ClsConexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("ingresar_usuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
            //        cmd.Parameters.Add(new SqlParameter("@Correo", Correo));
                    cmd.Parameters.Add(new SqlParameter("@Nombre", nombre));
                    cmd.Parameters.Add(new SqlParameter("@Estado", Estado));
                   // cmd.Parameters.Add(new SqlParameter("@Telefono", telefono));

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }


        public static int Borrar(int codigo)
        {
            int retorno = 0;

            SqlConnection Conn = new SqlConnection();
            try
            {
                using (Conn = ClsConexion.obtenerConexion())
                {
                    SqlCommand cmd = new SqlCommand("borrar_usuario", Conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                   cmd.Parameters.Add(new SqlParameter("@Codigo", codigo));
                   

                    retorno = cmd.ExecuteNonQuery();
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                retorno = -1;
            }
            finally
            {
                Conn.Close();
            }

            return retorno;
        }


    }
}