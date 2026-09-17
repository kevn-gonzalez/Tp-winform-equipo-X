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
            ((System.ComponentModel.ISupportInitialize)dgvPrincipal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxArticulos).BeginInit();
            SuspendLayout();
            // 
            // dgvPrincipal
            // 
            dgvPrincipal.BackgroundColor = SystemColors.ButtonHighlight;
            dgvPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrincipal.Location = new Point(333, 12);
            dgvPrincipal.Name = "dgvPrincipal";
            dgvPrincipal.Size = new Size(455, 346);
            dgvPrincipal.TabIndex = 0;
            dgvPrincipal.CellContentClick += dgvPrincipal_CellContentClick;
            dgvPrincipal.SelectionChanged += dgvPrincipal_SelectionChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(85, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(113, 46);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(85, 23);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pbxArticulos
            // 
            pbxArticulos.Location = new Point(57, 126);
            pbxArticulos.Name = "pbxArticulos";
            pbxArticulos.Size = new Size(206, 189);
            pbxArticulos.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxArticulos.TabIndex = 3;
            pbxArticulos.TabStop = false;
            pbxArticulos.Click += pictureBox1_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(215, 46);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(85, 23);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        }

        #endregion

        private DataGridView dgvPrincipal;
        private Button btnAgregar;
        private Button btnEliminar;
        private PictureBox pbxArticulos;
        private Button btnModificar;
    }
}
