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
    public partial class frmMarca : Form
    {

        private List<Marcas> listaMarcas;
        public frmMarca()
        {
            InitializeComponent();
        }



        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            MarcaDatos negocioMarca = new MarcaDatos();
            try
            {
                listaMarcas = negocioMarca.Listar();
                dgvMarca.DataSource = listaMarcas;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ocultarColumnas()
        {
            dgvMarca.Columns["Id"].Visible = false;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAltaMarca alta = new frmAltaMarca();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marcas seleccionado;
            seleccionado = (Marcas)dgvMarca.CurrentRow.DataBoundItem;

            frmAltaMarca modificar = new frmAltaMarca(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            MarcaDatos negocio = new MarcaDatos();
            Marcas seleccionado;
            try
            {
                
                DialogResult respuesta = MessageBox.Show("De verdad queres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marcas)dgvMarca.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

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
