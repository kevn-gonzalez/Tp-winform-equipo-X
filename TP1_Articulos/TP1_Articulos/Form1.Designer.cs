namespace TP1_Articulos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPrincipal = new DataGridView();
            btnAgregar = new Button();
            btnEliminar = new Button();
            pbxArticulos = new PictureBox();
            btnModificar = new Button();
            btnAnteriorImagen = new Button();
            btnSiguienteImagen = new Button();
            cbBuscar = new ComboBox();
            labelFiltrar = new Label();
            tbBuscar = new TextBox();
            labelBuscar = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).BeginInit();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(259, 12);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Size = new Size(529, 328);
            dgvPrincipal.TabIndex = 0;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            dgvPrincipal.DataError += dgvPrincipal_DataError;
            dgvPrincipal.SelectionChanged += dgvPrincipal_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(22, 21);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(22, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pbxArticulos
            // 
            pbxArticulos.Location = new Point(22, 151);
            pbxArticulos.Name = "pbxArticulos";
            pbxArticulos.Size = new Size(206, 189);
            pbxArticulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxArticulos.TabIndex = 3;
            pbxArticulos.TabStop = false;
            pbxArticulos.Click += pictureBox1_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(22, 59);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAnteriorImagen
            // 
            btnAnteriorImagen.Location = new Point(73, 360);
            btnAnteriorImagen.Name = "btnAnteriorImagen";
            btnAnteriorImagen.Size = new Size(34, 23);
            btnAnteriorImagen.TabIndex = 5;
            btnAnteriorImagen.Text = "<";
            btnAnteriorImagen.UseVisualStyleBackColor = true;
            btnAnteriorImagen.Click += btnAnteriorImagen_Click;
            // 
            // btnSiguienteImagen
            // 
            btnSiguienteImagen.Location = new Point(124, 360);
            btnSiguienteImagen.Name = "btnSiguienteImagen";
            btnSiguienteImagen.Size = new Size(34, 23);
            btnSiguienteImagen.TabIndex = 6;
            btnSiguienteImagen.Text = ">";
            btnSiguienteImagen.UseVisualStyleBackColor = true;
            btnSiguienteImagen.Click += btnSiguienteImagen_Click;
            // 
            // cbBuscar
            // 
            cbBuscar.FormattingEnabled = true;
            cbBuscar.Location = new Point(328, 352);
            cbBuscar.Name = "cbBuscar";
            cbBuscar.Size = new Size(194, 23);
            cbBuscar.TabIndex = 7;
            cbBuscar.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            cbBuscar.TextChanged += CBBuscarpor_TextChanged;
            // 
            // labelFiltrar
            // 
            labelFiltrar.AutoSize = true;
            labelFiltrar.Location = new Point(261, 355);
            labelFiltrar.Name = "labelFiltrar";
            labelFiltrar.Size = new Size(61, 15);
            labelFiltrar.TabIndex = 8;
            labelFiltrar.Text = "Filtrar por:";
            labelFiltrar.Click += labelFiltrar_Click;
            // 
            // tbBuscar
            // 
            tbBuscar.Location = new Point(328, 391);
            tbBuscar.Name = "tbBuscar";
            tbBuscar.Size = new Size(286, 23);
            tbBuscar.TabIndex = 9;
            tbBuscar.TextChanged += tbBuscar_TextChanged;
            // 
            // labelBuscar
            // 
            labelBuscar.AutoSize = true;
            labelBuscar.Location = new Point(261, 391);
            labelBuscar.Name = "labelBuscar";
            labelBuscar.Size = new Size(45, 15);
            labelBuscar.TabIndex = 10;
            labelBuscar.Text = "Buscar:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBuscar);
            Controls.Add(tbBuscar);
            Controls.Add(labelFiltrar);
            Controls.Add(cbBuscar);
            Controls.Add(btnSiguienteImagen);
            Controls.Add(btnAnteriorImagen);
            Controls.Add(btnModificar);
            Controls.Add(pbxArticulos);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPrincipal);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPrincipal;
        private Button btnAgregar;
        private Button btnEliminar;
        private PictureBox pbxArticulos;
        private Button btnModificar;
        private Button btnAnteriorImagen;
        private Button btnSiguienteImagen;
        private ComboBox cbBuscar;
        private Label labelFiltrar;
        private TextBox tbBuscar;
        private Label labelBuscar;
    }
}
