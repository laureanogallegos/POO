using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms
{
    public partial class frmGestion : Form
    {
        private RepositorioCategorias repositorioCategorias; //declare una variable de instancia
        private RepositorioProductos repositorioProductos;
        private Categoria categoriaEncontrada;
        private Producto productoEncontrado;
        public frmGestion()
        {
            InitializeComponent();
            repositorioCategorias= new RepositorioCategorias();
            repositorioProductos= new RepositorioProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (dgvCategorias.RowCount > 0)
            {
                var categoriaSeleccionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                if (categoriaSeleccionada != null)
                {
                    mensaje = repositorioCategorias.Eliminar(categoriaSeleccionada);
                    RefrescarGrilla();
                }
                else
                {
                    mensaje = "No hay elemntos";
                }
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No hay categorias para eliminar");
            }
        }

        private void frmGestion_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = repositorioProductos.Listar();
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = repositorioCategorias.Listar();
            cBoxCategorias.DataSource = null;
            cBoxCategorias.DisplayMember = "Nombre";
            cBoxCategorias.DataSource = repositorioCategorias.Listar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
                var categoria = new Categoria();
                categoria.Codigo = txtCodigo.Text;
                categoria.Nombre = txtNombre.Text;
                var mensaje = repositorioCategorias.Agregar(categoria);
                RefrescarGrilla();

                MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ingrese todos los datos de la categoria");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigo.Text) && !string.IsNullOrEmpty(txtNombre.Text))
            {
               
                var codigo = txtCodigo.Text;
                var nombre = txtNombre.Text;

                categoriaEncontrada.Nombre = txtNombre.Text;

                var mensaje = repositorioCategorias.Modificar(categoriaEncontrada);
                RefrescarGrilla();
                MessageBox.Show(mensaje);
    
            }
        }

        private void dgvCategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategorias.RowCount > 0)
            {
                categoriaEncontrada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                txtCodigo.Text = categoriaEncontrada.Codigo;
                txtNombre.Text = categoriaEncontrada.Nombre;

            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cBoxCategorias.Items.Count > 0)
            {
                var categoria = (Categoria)cBoxCategorias.SelectedItem;
                var producto = new Producto();
                producto.Codigo = txtCodigoProducto.Text;
                producto.Nombre = txtNombreProducto.Text;
                producto.Categoria = categoria;
                producto.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                producto.PrecioCompra= Convert.ToDecimal(txtPrecioCompra.Text);
                var mensaje = repositorioProductos.Agregar(producto);
                RefrescarGrilla();
                MessageBox.Show(mensaje);
            } 
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            if (dgvProductos.RowCount > 0)
            {
                var productoSeleccionado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                if (productoSeleccionado != null)
                {
                    mensaje = repositorioProductos.Eliminar(productoSeleccionado);
                    RefrescarGrilla();
                }
                else
                {
                    mensaje = "No hay elemntos";
                }
                MessageBox.Show(mensaje);
            }
            else
            {
                MessageBox.Show("No hay categorias para eliminar");
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoProducto.Text) && !string.IsNullOrEmpty(txtNombreProducto.Text))
            {

                productoEncontrado.Nombre = txtNombre.Text;
                productoEncontrado.Categoria = (Categoria)cBoxCategorias.SelectedItem;
                productoEncontrado.PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
                productoEncontrado.PrecioVenta = Convert.ToDecimal(txtPrecioVenta.Text);
                var mensaje = repositorioProductos.Modificar(productoEncontrado);
                RefrescarGrilla();
                MessageBox.Show(mensaje);

            }
        }
        
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.RowCount > 0)
            {
                productoEncontrado = (Producto)dgvProductos.CurrentRow.DataBoundItem;
                txtCodigoProducto.Text = productoEncontrado.Codigo;
                txtNombreProducto.Text = productoEncontrado.Nombre;
                txtPrecioCompra.Text = productoEncontrado.PrecioCompra.ToString();
                txtPrecioVenta.Text = productoEncontrado.PrecioVenta.ToString();

            }
        }
    }
}
