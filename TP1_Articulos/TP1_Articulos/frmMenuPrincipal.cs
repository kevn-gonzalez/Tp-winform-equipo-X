using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TP1_Articulos
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void btnArticulos_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            new frmListadoGenerico(new CategoriaDatos()).ShowDialog(); 
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            new frmListadoGenerico(new MarcaDatos()).ShowDialog();
        }
    }
}
