using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMVC.Views
{
    public partial class ConsultarLibros : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LibroController controller = new LibroController();

                gvLibros.DataSource = controller.Listar();
                gvLibros.DataBind();
            }
        }
        protected void gvLibros_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Detalle" || e.CommandName == "Eliminar")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                string codigo = gvLibros.Rows[index].Cells[0].Text;

                LibroController controller = new LibroController();

                if (e.CommandName == "Detalle")
                {
                    Response.Redirect("~/Views/DetalleLibro.aspx?codigo=" + codigo);
                }

                if (e.CommandName == "Eliminar")
                {
                    controller.Eliminar(codigo);

                    gvLibros.DataSource = controller.Listar();
                    gvLibros.DataBind();
                }
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            LibroController controller = new LibroController();

            var lista = controller.Listar();

            string texto = txtBuscar.Text.ToLower();

            var resultado = lista.Where(l =>
                l.Codigo.ToLower().Contains(texto) ||
                l.Titulo.ToLower().Contains(texto)
            ).ToList();

            gvLibros.DataSource = resultado;
            gvLibros.DataBind();
        }
    }
}