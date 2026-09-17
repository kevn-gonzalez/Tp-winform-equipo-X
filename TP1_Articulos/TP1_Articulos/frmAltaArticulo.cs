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
    public partial class frmAltaArticulo : Form
    {

        private Articulos articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Artículo";
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marcaDatos = new MarcaDatos();
            CategoriaDatos categoriaDatos = new CategoriaDatos();

            try
            {
                cboMarca.DataSource = marcaDatos.Listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaDatos.Listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtImagenUrl.Text = articulo.ImagenUrl;

                    cboMarca.SelectedValue = articulo.IdMarca.Id;
                    cboCategoria.SelectedValue = articulo.IdCategoria.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();

            try
            {
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.IdMarca = (Marcas)cboMarca.SelectedItem;
                articulo.IdCategoria = (Categorias)cboCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    datos.Modificar(articulo);
                    MessageBox.Show("Artículo modificado correctamente.");
                }
                else
                {
                    datos.Agregar(articulo);
                    MessageBox.Show("Artículo agregado correctamente.");
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
