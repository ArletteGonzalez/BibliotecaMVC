using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BibliotecaMVC.Views
{
    public partial class RegistrarLibro : Page

    {
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            LibroController controller = new LibroController();

            Libro libro = new Libro();

            libro.Codigo = txtCodigo.Text;
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            libro.FechaPublicacion = Convert.ToDateTime(txtFecha.Text);

            controller.Registrar(libro);

            lblMensaje.Text = "Libro registrado correctamente";
        }
    }
}