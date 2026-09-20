
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace TP1_Articulos
{
    public partial class frmAltaCategoria : Form
    {
        private Categorias categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categorias categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
            btnAgregarCat.Text = "Modificar";
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            CategoriaDatos negocioCategoria = new CategoriaDatos();

            try
            {
                if (categoria == null)
                {
                    categoria = new Categorias();
                }
                categoria.Descripcion = txtAltaCat.Text;
                if (categoria.Id != 0)
                {
                    negocioCategoria.modificar(categoria);
                    MessageBox.Show("Modificado Exitosamente!");
                }
                else
                {
                    negocioCategoria.agregar(categoria.Descripcion);
                    MessageBox.Show("Agregado exitosamente!");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
                txtAltaCat.Text = categoria.Descripcion;
        }

    }
}