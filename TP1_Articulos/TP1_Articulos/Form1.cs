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
        private List<Articulos> listaDeArticulos;

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
            try
            {
                if (dgvPrincipal.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un artículo de la lista.");
                    return;
                }
                DialogResult respuesta = MessageBox.Show("Esta a punto de eliminar un articulo. ¿Esta seguro?", "Eliminando articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvPrincipal.CurrentRow.DataBoundItem;
                    neg.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbBuscar.Items.Add("todos");
            cbBuscar.Items.Add("por nombre");
            cbBuscar.Items.Add("por descripcion");
            cbBuscar.Items.Add("por marca");
            cbBuscar.Items.Add("por categoria");
            cbBuscar.SelectedIndex = 0;
            cargar();
        }

        private void cargar()
        {
            try
            {
                ArticuloDatos Negocio = new ArticuloDatos();

                listaDeArticulos = Negocio.Listar();
                dgvPrincipal.DataSource = listaDeArticulos;

                dgvPrincipal.Columns["Precio"].DefaultCellStyle.Format = "N2";

                if (listaDeArticulos.Count > 0)
                {
                    ocultar();
                    cargarImagen(listaDeArticulos[0].ImagenUrl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private  void cargarImagen(string imagen)
        {
            try
            {
                 pbxArticulos.LoadAsync(imagen);
            }
            catch (Exception)
            {
                pbxArticulos.LoadAsync("https://imgs.search.brave.com/bInLnvoN33pG-W4upTXrPPHjvb9xv_qN29l38jyQYuM/rs:fit:860:0:0:0/g:ce/aHR0cHM6Ly9paDEu/cmVkYnViYmxlLm5l/dC9pbWFnZS4yODQ1/Nzk3NzEuMTcyNS9n/YnJmLDd4NSxmLDU0/MHg1NDAtcGFkLDQ1/MHg0NTAsZjhmOGY4/LnU0LmpwZw");
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


        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaParcial;

            string filtro = tbBuscar.Text;
            if (filtro.Length > 1)
            {

                string seleccion = cbBuscar.SelectedItem.ToString();
                switch (seleccion)
                {
                    case "por nombre":
                        {
                            listaParcial = listaDeArticulos.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    case "por descripcion":
                        {
                            listaParcial = listaDeArticulos.FindAll(item => item.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    case "por marca":
                        {
                            listaParcial = listaDeArticulos.FindAll(item => item.IdMarca != null && item.IdMarca.Descripcion != null && item.IdMarca.Descripcion.ToUpper().Contains(filtro.ToUpper())); break;
                        }
                    case "por categoria":
                        {
                            listaParcial = listaDeArticulos.FindAll(item => item.IdCategoria != null && item.IdCategoria.Descripcion != null && item.IdCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper()));
                            break;
                        }
                    default:
                        listaParcial = listaDeArticulos.FindAll(item => item.Nombre.ToUpper().Contains(filtro.ToUpper()) || item.Descripcion.ToUpper().Contains(filtro.ToUpper()) || (item.IdCategoria != null && item.IdCategoria.Descripcion != null && item.IdCategoria.Descripcion.ToUpper().Contains(filtro.ToUpper())) || (item.IdMarca != null && item.IdMarca.Descripcion != null && item.IdMarca.Descripcion.ToUpper().Contains(filtro.ToUpper())));
                        break;
                }
            }
            else
            {
                listaParcial = listaDeArticulos;
            }

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = listaParcial;
            ocultar();
        }

        private void ocultar()
        {
            if (dgvPrincipal.Columns.Contains("ImagenUrl"))
            {
                dgvPrincipal.Columns["ImagenUrl"].Visible = false;
            }
            if (dgvPrincipal.Columns.Contains("Id"))
            {
                dgvPrincipal.Columns["Id"].Visible = false;
            }
        }

        private void dgvPrincipal_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CBBuscarpor_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
