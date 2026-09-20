namespace TP1_Articulos
{
    partial class frmCategoria
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
            dgvCategoria = new DataGridView();
            lblCategorias = new Label();
            btnAgregarCat = new Button();
            btnModificarCat = new Button();
            btnEliminarCat = new Button();
           
            
            
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            SuspendLayout();
            // 
            // dgvCategoria
            // 
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Location = new Point(62, 65);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.Size = new Size(240, 259);
            dgvCategoria.TabIndex = 0;
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(141, 47);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(78, 15);
            lblCategorias.TabIndex = 1;
            lblCategorias.Text = "CATEGORIAS:";
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(32, 345);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(75, 29);
            btnAgregarCat.TabIndex = 2;
            btnAgregarCat.Text = "Agregar";
            btnAgregarCat.UseVisualStyleBackColor = true;
            btnAgregarCat.Click += btnAgregarCat_Click;
            // 
            // btnModificarCat
            // 
            btnModificarCat.Location = new Point(152, 345);
            btnModificarCat.Name = "btnModificarCat";
            btnModificarCat.Size = new Size(75, 29);
            btnModificarCat.TabIndex = 3;
            btnModificarCat.Text = "Modificar";
            btnModificarCat.UseVisualStyleBackColor = true;
            btnModificarCat.Click += btnModificarCat_Click;
            // 
            // btnEliminarCat
            // 
            btnEliminarCat.Location = new Point(288, 345);
            btnEliminarCat.Name = "btnEliminarCat";
            btnEliminarCat.Size = new Size(75, 29);
            btnEliminarCat.TabIndex = 4;
            btnEliminarCat.Text = "Eliminar";
            btnEliminarCat.UseVisualStyleBackColor = true;
            btnEliminarCat.Click += btnEliminarCat_Click;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(btnEliminarCat);
            Controls.Add(btnModificarCat);
            Controls.Add(btnAgregarCat);
            Controls.Add(lblCategorias);
            Controls.Add(dgvCategoria);
            Name = "frmCategoria";
        
            Load += frmCategoria_Load;
            Text = "frmCategoria";
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoria;
        private Label lblCategorias;
        private Button btnAgregarCat;
        private Button btnModificarCat;
        private Button btnEliminarCat;
    }
}