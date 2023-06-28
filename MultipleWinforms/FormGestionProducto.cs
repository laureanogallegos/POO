using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleWinforms
{
    internal partial class FormGestionProducto : Form
    {
      
        private RepositorioProductos Productos;
        private RepositorioCategorias repositorioCategorias;
        public FormGestionProducto(RepositorioProductos repositorioProductos, RepositorioCategorias repositorioCategorias)
        {
            Productos = repositorioProductos;
            this.repositorioCategorias = repositorioCategorias;
            InitializeComponent();

            cBoxCategorias.DataSource = null;
            cBoxCategorias.DataSource = repositorioCategorias.Listar();
            cBoxCategorias.DisplayMember = "Codigo";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var producto = new Producto();
            producto.Categoria = (Categoria)cBoxCategorias.SelectedItem;
            producto.Codigo = txtCodigo.Text;
            producto.PrecioVenta = Convert.ToInt32(txtPrecioVenta.Text);
            producto.PrecioCompra = Convert.ToInt32(txtPrecioCompra.Text);
            producto.Cantidad = Convert.ToInt32(txtCantidad.Text);
            
            var mensaje = Productos.Agregar(producto);
            MessageBox.Show(mensaje);
            this.Close();
        }

        private void FormGestionProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
