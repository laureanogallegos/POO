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
    public partial class FormGestionProductos : Form
    {
        private static RepositorioProductos repositorioProductos;
        private static RepositorioCategorias repositorioCategorias;
        public FormGestionProductos()
        {
            InitializeComponent();
            repositorioProductos= new RepositorioProductos();
            repositorioCategorias = new RepositorioCategorias();
            ActualizarGrillas();
        }

        private void ActualizarGrillas()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = repositorioCategorias.Listar();
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = repositorioProductos.Listar();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            var formGestionProducto = new FormGestionCategoria(repositorioCategorias);
            formGestionProducto.ShowDialog();
            ActualizarGrillas();
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.RowCount >0)
            {
                var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                var formGestionProducto = new FormGestionCategoria(repositorioCategorias, categoria);
                formGestionProducto.ShowDialog();
            }
            else MessageBox.Show("No se ha seleccionado ninguna categoria.");
            ActualizarGrillas();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow.DataBoundItem != null)
            {
                var categoria = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
                var mensaje = repositorioCategorias.Eliminar(categoria);
                MessageBox.Show(mensaje);
            }
            else MessageBox.Show("No se ha seleccionado ninguna categoria.");
            ActualizarGrillas();
        }
    }
}
