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
                    articulo.Imagenes = new ArticuloDatos().ListarImagenes(articulo.Id);
                    foreach (string imagen in articulo.Imagenes)
                    {
                        lstImagenes.Items.Add(imagen);
                    }
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
                errorProvider1.Clear();
                bool hayError = false;

                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    errorProvider1.SetError(txtCodigo, "Debe ingresar un código.");
                    hayError= true;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "Debe ingresar un nombre.");
                    hayError = true;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    errorProvider1.SetError(txtDescripcion, "Debe ingresar una descripción.");
                    hayError = true;
                }
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
                {
                    errorProvider1.SetError(txtPrecio, "Precio invalido. Por favor, utilice solo números y mayores a 0");
                    hayError = true;
                }

                if (cboMarca.SelectedItem == null)
                {
                    errorProvider1.SetError(cboMarca, "Debe seleccionar una Marca.");
                    hayError = true;
                }
                if (cboCategoria.SelectedItem == null)
                {
                    errorProvider1.SetError(cboCategoria, "Debe seleccionar una Categoría.");
                    hayError = true;
                }
                if (lstImagenes.Items.Count == 0)
                {
                    errorProvider1.SetError(lstImagenes, "Debe agregar al menos una imagern.");
                    hayError = true;
                }
                if (hayError) return;

                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio = precio;
                articulo.Imagenes.Clear();
                foreach (string imagen in lstImagenes.Items)
                {
                    articulo.Imagenes.Add(imagen);
                }

                articulo.ImagenUrl = articulo.Imagenes[0];
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

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (txtImagenUrl.Text != "")
            {
                lstImagenes.Items.Add(txtImagenUrl.Text);
                txtImagenUrl.Clear();
            }
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (lstImagenes.SelectedItem != null)
                lstImagenes.Items.Remove(lstImagenes.SelectedItem);
        }

        private void lstImagenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
