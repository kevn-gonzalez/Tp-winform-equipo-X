namespace TP1_Articulos
{
    partial class frmAltaArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            txtImagenUrl = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cboMarca = new ComboBox();
            cboCategoria = new ComboBox();
            btnAgregarImagen = new Button();
            lstImagenes = new ListBox();
            btnQuitarImagen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 52);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 89);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 128);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 2;
            label3.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 165);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Marca:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 202);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Categoria:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 243);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 5;
            label6.Text = "Precio:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(351, 47);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 6;
            label7.Text = "Imagen URL:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(135, 44);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(169, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(135, 128);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(169, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(135, 243);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(169, 23);
            txtPrecio.TabIndex = 12;
            // 
            // txtImagenUrl
            // 
            txtImagenUrl.Location = new Point(439, 44);
            txtImagenUrl.Name = "txtImagenUrl";
            txtImagenUrl.Size = new Size(134, 23);
            txtImagenUrl.TabIndex = 13;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(47, 311);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(135, 311);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(135, 162);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(169, 23);
            cboMarca.TabIndex = 16;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(135, 202);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(169, 23);
            cboCategoria.TabIndex = 17;
            // 
            // btnAgregarImagen
            // 
            btnAgregarImagen.Location = new Point(327, 311);
            btnAgregarImagen.Name = "btnAgregarImagen";
            btnAgregarImagen.Size = new Size(106, 23);
            btnAgregarImagen.TabIndex = 18;
            btnAgregarImagen.Text = "Agregar Imagen";
            btnAgregarImagen.UseVisualStyleBackColor = true;
            btnAgregarImagen.Click += btnAgregarImagen_Click;
            // 
            // lstImagenes
            // 
            lstImagenes.FormattingEnabled = true;
            lstImagenes.Location = new Point(351, 89);
            lstImagenes.Name = "lstImagenes";
            lstImagenes.Size = new Size(222, 199);
            lstImagenes.TabIndex = 19;
            lstImagenes.SelectedIndexChanged += lstImagenes_SelectedIndexChanged;
            // 
            // btnQuitarImagen
            // 
            btnQuitarImagen.Location = new Point(455, 311);
            btnQuitarImagen.Name = "btnQuitarImagen";
            btnQuitarImagen.Size = new Size(94, 23);
            btnQuitarImagen.TabIndex = 20;
            btnQuitarImagen.Text = "Quitar Imagen";
            btnQuitarImagen.UseVisualStyleBackColor = true;
            btnQuitarImagen.Click += btnQuitarImagen_Click;
            // 
            // frmAltaArticulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 371);
            Controls.Add(btnQuitarImagen);
            Controls.Add(lstImagenes);
            Controls.Add(btnAgregarImagen);
            Controls.Add(cboCategoria);
            Controls.Add(cboMarca);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtImagenUrl);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(txtCodigo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAltaArticulo";
            Text = "frmAltaArticulo";
            Load += frmAltaArticulo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private TextBox txtImagenUrl;
        private Button btnAceptar;
        private Button btnCancelar;
        private ComboBox cboMarca;
        private ComboBox cboCategoria;
        private Button btnAgregarImagen;
        private ListBox lstImagenes;
        private Button btnQuitarImagen;
    }
}