namespace TP1_Articulos
{
    partial class frmMarca
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
            lblMarca = new Label();
            btnEliminarMarca = new Button();
            btnModificarMarca = new Button();
            btnAgregarMarca = new Button();
            dgvMarca = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMarca).BeginInit();
            SuspendLayout();
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(158, 42);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(58, 15);
            lblMarca.TabIndex = 1;
            lblMarca.Text = "MARCAS:";
            // 
            // btnEliminarMarca
            // 
            btnEliminarMarca.Location = new Point(288, 351);
            btnEliminarMarca.Name = "btnEliminarMarca";
            btnEliminarMarca.Size = new Size(75, 29);
            btnEliminarMarca.TabIndex = 8;
            btnEliminarMarca.Text = "Eliminar";
            btnEliminarMarca.UseVisualStyleBackColor = true;
            btnEliminarMarca.Click += btnEliminarMarca_Click;
            // 
            // btnModificarMarca
            // 
            btnModificarMarca.Location = new Point(152, 351);
            btnModificarMarca.Name = "btnModificarMarca";
            btnModificarMarca.Size = new Size(75, 29);
            btnModificarMarca.TabIndex = 7;
            btnModificarMarca.Text = "Modificar";
            btnModificarMarca.UseVisualStyleBackColor = true;
            btnModificarMarca.Click += btnModificarMarca_Click;
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Location = new Point(32, 351);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(75, 29);
            btnAgregarMarca.TabIndex = 6;
            btnAgregarMarca.Text = "Agregar";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // dgvMarca
            // 
            dgvMarca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarca.Location = new Point(62, 71);
            dgvMarca.Name = "dgvMarca";
            dgvMarca.Size = new Size(240, 259);
            dgvMarca.TabIndex = 5;
            // 
            // frmMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(btnEliminarMarca);
            Controls.Add(btnModificarMarca);
            Controls.Add(btnAgregarMarca);
            Controls.Add(dgvMarca);
            Controls.Add(lblMarca);
            Name = "frmMarca";
            Text = "frmMarca";
            Load += frmMarca_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarca).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMarca;
        private Button btnEliminarMarca;
        private Button btnModificarMarca;
        private Button btnAgregarMarca;
        private DataGridView dgvMarca;
    }
}