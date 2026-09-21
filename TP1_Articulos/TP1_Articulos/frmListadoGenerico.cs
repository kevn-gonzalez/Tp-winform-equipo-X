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
    public partial class frmListadoGenerico : Form
    {
        private GenericoDatos genericoDatos;
        private List<EntidadBase> listaElementos;
        public frmListadoGenerico(GenericoDatos genericoDatos)
        {
            InitializeComponent();
            this.genericoDatos = genericoDatos;
        }



        private void frmListadoGenerico_Load(object sender, EventArgs e)
        {

            cargar();
            string elemento;
            lblElemento.Text = genericoDatos.ToString();
            lblElm.Text = "Descripcion";
        }


        private void cargar()
        {

            try
            {
                listaElementos = genericoDatos.Listar();
                dgvElementos.DataSource = listaElementos;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvElementos.Columns["Id"].Visible = false;
        }

        private void btnAgregarGenerico_Click(object sender, EventArgs e)
        {
            genericoDatos.agregar(txtElemento.Text);
            cargar();
        }

        private void btnModificarGenerico_Click(object sender, EventArgs e)
        {
            EntidadBase seleccionado;
            seleccionado = (EntidadBase)dgvElementos.CurrentRow.DataBoundItem;

            seleccionado.Descripcion = txtElemento.Text;

            genericoDatos.modificar(seleccionado);
            cargar();
        }

        private void btnEliminarGenerico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            EntidadBase seleccionado;
            seleccionado = (EntidadBase)dgvElementos.CurrentRow.DataBoundItem;
            try
            {

                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {

                    if (logico)
                        genericoDatos.eliminarLogico(seleccionado.Id);
                    else
                        genericoDatos.eliminar(seleccionado.Id);

                    cargar();

                }
            }

            catch (Exception)
            {
                throw;
            }
        }

        private void dgvElementos_MouseClick(object sender, MouseEventArgs e)
        {

            EntidadBase seleccionado;
            seleccionado = (EntidadBase)dgvElementos.CurrentRow.DataBoundItem;
            txtElemento.Text = seleccionado.ToString();
        }
    }
}