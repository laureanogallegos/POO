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
    public partial class FormGestionProducto : Form
    {
        private object categoria;

        public FormGestionProducto()
        {
            InitializeComponent();
        }

        public FormGestionProducto(object categoria)
        {
            this.categoria = categoria;
        }
    }
}
