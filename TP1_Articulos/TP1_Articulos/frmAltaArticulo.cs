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
                if (articulo == null)
                    articulo = new Articulos();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("Precio invalido. Por favor, utilice solo números en dicho campo.");
                    return;
                }
                articulo.Precio = precio;
                articulo.Imagenes.Clear();
                foreach (string imagen in lstImagenes.Items)
                {
                    articulo.Imagenes.Add(imagen);
                }

                if (articulo.Imagenes.Count > 0)
                    articulo.ImagenUrl = articulo.Imagenes[0];

                if (cboMarca.SelectedItem == null || cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una Marca y una Categoría.");
                    return;
                }
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
    }
}
