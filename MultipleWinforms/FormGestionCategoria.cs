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
    public partial class FormGestionCategoria : Form
    {
        private RepositorioCategorias repositorioCategorias;
        private Categoria categoria;
        private bool modifica = false;

        public FormGestionCategoria(RepositorioCategorias repositorioCategorias)
        {
            InitializeComponent();
            this.repositorioCategorias = repositorioCategorias;
            gBoxCategoria.Text = "Agregar Categoria";
        }

        public FormGestionCategoria(RepositorioCategorias repositorioCategorias, Categoria categoria)
        {
            //si se ejecuta este codigo es porque voy a modificar el objeto categoria por ende voy a realizar unos cambios
            InitializeComponent();
            modifica = true;
            this.repositorioCategorias = repositorioCategorias;
            this.categoria = categoria;
            gBoxCategoria.Text = "Modificar Categoria";
            txtCodigo.Text = categoria.Codigo;
            txtCodigo.Enabled = false;
            txtNombre.Text = categoria.Nombre;
        }

        private void FormGestionCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (!modifica)
                {
                    var categoria = new Categoria();
                    categoria.Codigo = txtCodigo.Text;
                    categoria.Nombre = txtNombre.Text;
                    var mensaje = repositorioCategorias.Agregar(categoria);
                    MessageBox.Show(mensaje);

                }
                else
                {
                    categoria.Nombre = txtNombre.Text;
                    var mensaje = repositorioCategorias.Modificar(categoria);
                    MessageBox.Show(mensaje);
                }
                this.Close();
            }
        }
        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el código");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                return false;
            }
            return true;
        }
    }
}
