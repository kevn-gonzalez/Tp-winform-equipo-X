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
            cbMenuSeleccionado.Items.Add("Marca");
            cbMenuSeleccionado.Items.Add("Categoría");
            cbMenuSeleccionado.Items.Add("Artículos");
        }

        private void btnSeleccionMenu_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (cbMenuSeleccionado.SelectedItem == null)
            {
                errorProvider1.SetError( cbMenuSeleccionado, "Elegí una opción");
                return;
               
            }

            switch (cbMenuSeleccionado.SelectedItem.ToString())
            {
                case "Marca":
                    new frmMarca().ShowDialog();
                    break;
                case "Categoría":
                    new frmCategoria().ShowDialog();
                    break;
                case "Artículos":
                    new Form1().ShowDialog();
                    break;
            }
        }
    }
}
