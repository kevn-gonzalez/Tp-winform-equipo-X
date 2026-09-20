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
    public partial class frmCategoria : Form
    {

        private List<Categorias> listaCategorias;
        public frmCategoria()
        {
            InitializeComponent();
        }


        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            CategoriaDatos negocioCategoria = new CategoriaDatos();
            try
            {
                listaCategorias = negocioCategoria.Listar();
                dgvCategoria.DataSource = listaCategorias;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvCategoria.Columns["Id"].Visible = false;
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmAltaCategoria alta = new frmAltaCategoria();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificarCat_Click(object sender, EventArgs e)
        {
            Categorias seleccionado;
            seleccionado = (Categorias)dgvCategoria.CurrentRow.DataBoundItem;

            frmAltaCategoria modificar = new frmAltaCategoria(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            CategoriaDatos negocioCategoria = new CategoriaDatos();
            Categorias seleccionado;
            try
            {

                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categorias)dgvCategoria.CurrentRow.DataBoundItem;
                    if (logico)
                        negocioCategoria.eliminarLogico(seleccionado.Id);
                    else
                        negocioCategoria.eliminar(seleccionado.Id);

                    cargar();

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}