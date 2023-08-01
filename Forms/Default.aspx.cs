using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace final_Valenzuela.Forms
{
    public partial class Default : System.Web.UI.Page
    {
        private readonly string mi_coneccion = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LINQ;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private SqlConnection conn;
        private Data_db_informacionDataContext db_context;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(mi_coneccion);
            conn.Open();
            db_context = new Data_db_informacionDataContext(conn);
        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            // Obtengo valores ingresados en el form
            string apellido = apellidoTextbox.Text;
            string nombre = nombreTextbox.Text;
            int legajo = 0;
            int categoriaID = 0;

            if (string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(nombre) ||
        !int.TryParse(legajoTextbox.Text, out legajo) || !int.TryParse(CategoriaTextbox.Text, out categoriaID))
            {
                // Validaciones
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showError", "alert('Por favor, ingrese todos los campos correctamente.');", true);
                return;
            }

            // Verifico si se repite N° de legajo
            var existeLegajo = db_context.informacion.FirstOrDefault(emp => emp.legajo == legajo);
            if (existeLegajo != null)
            {
                
                ScriptManager.RegisterStartupScript(this, this.GetType(), "showError", "alert('El número de legajo ya está registrado.');", true);
                return;
            }

            try
            {
                informacion empleado = new informacion();

                empleado.apellido = apellidoTextbox.Text;
                empleado.nombre = nombreTextbox.Text;
                empleado.legajo = Convert.ToInt32(legajoTextbox.Text);
                empleado.categoriaID = Convert.ToInt32(CategoriaTextbox.Text);

                db_context.informacion.InsertOnSubmit(empleado);
                db_context.SubmitChanges();

                Response.Redirect("Detalle.aspx");
         
            }
            catch (Exception)
            {
                throw;
            }           


        }
        protected void btn_limpiar_Click(object sender, EventArgs e)
        {
            apellidoTextbox.Text = string.Empty;
            nombreTextbox.Text = string.Empty;
            legajoTextbox.Text = string.Empty;
            CategoriaTextbox.Text = string.Empty;
        }


    }
}