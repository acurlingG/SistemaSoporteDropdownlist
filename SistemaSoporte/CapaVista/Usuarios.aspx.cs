using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaSoporte.CapaModelo;
using SistemaSoporte.CapaLogica;

namespace SistemaSoporte.CapaVista
{
    public partial class Usuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
                string str = "Data Source=CURLING\\CURLING;Initial Catalog=soporte;Integrated Security=True";
                SqlConnection con = new SqlConnection(str);
                string com = "Select * from estados";
                SqlDataAdapter adpt = new SqlDataAdapter(com, con);
                DataTable dt = new DataTable();
                adpt.Fill(dt);
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
                DropDownList1.DataTextField = "descripcion";
                DropDownList1.DataValueField = "id";
                DropDownList1.DataBind();
            }

           
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT *  FROM usuarios "))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void bborrar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("update  usuarios set estado = 'inactivo'  where  usuarioid = " + tcodigo.Text + "", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        public void alertas(String texto)
        {
            string message = texto;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<script type = 'text/javascript'>");
            sb.Append("window.onload=function(){");
            sb.Append("alert('");
            sb.Append(message);
            sb.Append("')};");
            sb.Append("</script>");
            ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", sb.ToString());

        }

        protected void bagregar_Click(object sender, EventArgs e)
        {

            Clsusuario.Setnombre(tnombre.Text);
            Clsusuario.Setestado(DropDownList1.SelectedItem.ToString());
      
            int resultado = Usuario_Logica.Agregar(Clsusuario.Getnombre(), Clsusuario.Getestado());

            if (resultado > 0)
            {
                LlenarGrid();
            }
            else
            {
              //  alertas("Error al ingresar Usuario");

            }
        }
    }
}