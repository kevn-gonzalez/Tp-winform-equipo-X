using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TP1_Articulos
{
    public partial class Form1 : Form
    {
        private List<string> imagenesActuales = new List<string>();
        private int indiceImagen = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();

            ArticuloDatos negocio = new ArticuloDatos();
            dgvPrincipal.DataSource = negocio.Listar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloDatos neg = new ArticuloDatos();
            Articulos seleccionado;
            seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;
            neg.eliminar(seleccionado.Id);
            cargar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            try
            {
                List<Articulos> listaDeArticulos = new List<Articulos>();
                ArticuloDatos Negocio = new ArticuloDatos();

                dgvPrincipal.DataSource = Negocio.Listar();
                listaDeArticulos = Negocio.Listar();
                dgvPrincipal.DataSource = listaDeArticulos;

                dgvPrincipal.Columns["Precio"].DefaultCellStyle.Format = "0.##";

                if (listaDeArticulos.Count > 0)
                {
                    cargarImagen(listaDeArticulos[0].ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://ih1.redbubble.net/image.1693090018.7934/pp,504x498-pad,600x600,f8f8f8.jpg");
            }
        }

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrincipal.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;
                ArticuloDatos datos = new ArticuloDatos();

                imagenesActuales = datos.ListarImagenes(seleccionado.Id);
                indiceImagen = 0;

                if (imagenesActuales.Count > 0)
                    cargarImagen(imagenesActuales[indiceImagen]);
                else
                    pbxArticulos.Image = null;

                actualizarBotonesImagen();
            }
        }
        private void actualizarBotonesImagen()
        {
            btnAnteriorImagen.Enabled = imagenesActuales.Count > 1;
            btnSiguienteImagen.Enabled = imagenesActuales.Count > 1;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;

            seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();

            cargar();
        }

        private void btnAnteriorImagen_Click(object sender, EventArgs e)
        {
            if (imagenesActuales.Count > 0)
            {
                indiceImagen--;

                if (indiceImagen < 0)
                    indiceImagen = imagenesActuales.Count - 1;

                cargarImagen(imagenesActuales[indiceImagen]);
            }
        }

        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            if (imagenesActuales.Count > 0)
            {
                indiceImagen++;

                if (indiceImagen >= imagenesActuales.Count)
                    indiceImagen = 0;

                cargarImagen(imagenesActuales[indiceImagen]);
            }
        }
    }
}
