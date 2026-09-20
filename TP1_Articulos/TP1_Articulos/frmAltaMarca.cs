
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
    public partial class frmAltaMarca : Form
    {
        private Marcas marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marcas marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            btnAgregarMarca.Text = "Modificar";
            txtAltaMarca.Text = marca.Descripcion;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MarcaDatos negocioMarca = new MarcaDatos();
            try
            {
                errorProvider1.Clear();
                if(string.IsNullOrWhiteSpace(txtAltaMarca.Text) )
                {
                    errorProvider1.SetError(txtAltaMarca, "Debe ingresar una marca.");
                    return;
                }
               
                if (marca == null)
                {
                    marca = new Marcas();
                }
                marca.Descripcion = txtAltaMarca.Text;
                if(marca.Id != 0)
                {
                    negocioMarca.modificar(marca);
                    MessageBox.Show("Modificado Exitosamente!");
                }else
                {
                    negocioMarca.agregar(marca.Descripcion);
                    MessageBox.Show("Agregado exitosamente!");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
