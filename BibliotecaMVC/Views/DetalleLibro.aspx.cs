using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace BibliotecaMVC.Views
{
    public partial class DetalleLibro : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string codigo = Request.QueryString["codigo"];

                LibroController controller = new LibroController();
                var libro = controller.Obtener(codigo);

                if (libro != null)
                {
                    lblCodigo.Text = libro.Codigo;
                    lblTitulo.Text = libro.Titulo;
                    lblAutor.Text = libro.Autor;
                    lblFecha.Text = libro.FechaPublicacion.ToString();
                }
                else
                {
                    lblMensaje.Text = "El libro no fue encontrado.";
                }
            }
        }
    }
}