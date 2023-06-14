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
        Categoria categoriaEncontrada;
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
                producto.Categoria = categoria;
                var mensaje = repositorioProductos.Agregar(producto);
                MessageBox.Show(mensaje);
            } 
        }
    }
}
