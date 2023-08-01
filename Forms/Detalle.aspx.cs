using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_Valenzuela.Forms
{
    public partial class Detalle : System.Web.UI.Page
    {
        private readonly string mi_coneccion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LINQ;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private SqlConnection conn;
        private Data_db_informacionDataContext db_context;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }        

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            // Obtengo el número de legajo ingresado por el usuario y lo convierto a un valor numérico (int)
            if (int.TryParse(txtLegajo.Text, out int legajo))
            {
                // LLamo funcion que realiza la consulta y muestro el resultado
                MostrarResultado(legajo);
            }
            else
            {
                lblMensaje.Text = "El número de legajo ingresado no es válido.";
                lblMensaje.Visible = true;
                lblResultado.Text = "";
            }
        }

        private void MostrarResultado(int legajo)
        {

            // CConsulta a la BD
            string query = "SELECT nombre, apellido, categoriaID FROM informacion WHERE Legajo = @Legajo";

            // Se crea la coneccion a la BD
            using (SqlConnection conn = new SqlConnection(mi_coneccion))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    // Agregar el parámetro legajo a la consulta
                    command.Parameters.AddWithValue("@Legajo", legajo);

                    try
                    {
                        // Se abre coneccion
                        conn.Open();

                        // Ejecuto la consulta y obtengo el resultado en un DataTable
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }

                        // Verificacion si se encuentra resultado
                        if (dt.Rows.Count > 0)
                        {
                            
                            string resultado = "Nombre: " + dt.Rows[0]["nombre"].ToString() + "<br />";
                            resultado += "Apellido: " + dt.Rows[0]["apellido"].ToString() + "<br />";
                            resultado += "Categoría: " + dt.Rows[0]["categoriaID"].ToString() + "<br />";

                            
                            lblResultado.Text = resultado;
                            lblMensaje.Text = ""; // Limpiar el mensaje de error si hubiera alguno
                            lblMensaje.Visible = false;
                        }
                        else
                        {
                            // Msj si no se encuentra resultados
                            lblMensaje.Text = "No se encontró ningún empleado con el legajo proporcionado.";
                            lblMensaje.Visible = true;
                            lblResultado.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                     
                        lblMensaje.Text = "Error al realizar la consulta: " + ex.Message;
                        lblMensaje.Visible = true;
                        lblResultado.Text = "";
                    }
                }
            }
        }



    }
}