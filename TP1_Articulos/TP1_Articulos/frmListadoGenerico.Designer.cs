namespace TP1_Articulos
{
    partial class frmListadoGenerico
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
            components = new System.ComponentModel.Container();
            dgvElementos = new DataGridView();
            lblElemento = new Label();
            btnAgregarGenerico = new Button();
            btnModificarGenerico = new Button();
            btnEliminarGenerico = new Button();
            errorProvider1 = new ErrorProvider(components);
            txtElemento = new TextBox();
            lblElm = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvElementos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvElementos
            // 
            dgvElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElementos.Location = new Point(57, 62);
            dgvElementos.Name = "dgvElementos";
            dgvElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElementos.Size = new Size(275, 259);
            dgvElementos.TabIndex = 0;
            dgvElementos.MouseClick += dgvElementos_MouseClick;
            // 
            // lblElemento
            // 
            lblElemento.AutoSize = true;
            lblElemento.Location = new Point(152, 32);
            lblElemento.Name = "lblElemento";
            lblElemento.Size = new Size(78, 15);
            lblElemento.TabIndex = 1;
            lblElemento.Text = "CATEGORIAS:";
            // 
            // btnAgregarGenerico
            // 
            btnAgregarGenerico.Location = new Point(12, 345);
            btnAgregarGenerico.Name = "btnAgregarGenerico";
            btnAgregarGenerico.Size = new Size(75, 29);
            btnAgregarGenerico.TabIndex = 2;
            btnAgregarGenerico.Text = "Agregar";
            btnAgregarGenerico.UseVisualStyleBackColor = true;
            btnAgregarGenerico.Click += btnAgregarGenerico_Click;
            // 
            // btnModificarGenerico
            // 
            btnModificarGenerico.Location = new Point(155, 345);
            btnModificarGenerico.Name = "btnModificarGenerico";
            btnModificarGenerico.Size = new Size(75, 29);
            btnModificarGenerico.TabIndex = 3;
            btnModificarGenerico.Text = "Modificar";
            btnModificarGenerico.UseVisualStyleBackColor = true;
            btnModificarGenerico.Click += btnModificarGenerico_Click;
            // 
            // btnEliminarGenerico
            // 
            btnEliminarGenerico.Location = new Point(307, 345);
            btnEliminarGenerico.Name = "btnEliminarGenerico";
            btnEliminarGenerico.Size = new Size(75, 29);
            btnEliminarGenerico.TabIndex = 4;
            btnEliminarGenerico.Text = "Eliminar";
            btnEliminarGenerico.UseVisualStyleBackColor = true;
            btnEliminarGenerico.Click += btnEliminarGenerico_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(93, 407);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(209, 23);
            txtElemento.TabIndex = 5;
            // 
            // lblElm
            // 
            lblElm.AutoSize = true;
            lblElm.Location = new Point(12, 410);
            lblElm.Name = "lblElm";
            lblElm.Size = new Size(72, 15);
            lblElm.TabIndex = 6;
            lblElm.Text = "Descripción:";
            // 
            // frmListadoGenerico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 450);
            Controls.Add(lblElm);
            Controls.Add(txtElemento);
            Controls.Add(btnEliminarGenerico);
            Controls.Add(btnModificarGenerico);
            Controls.Add(btnAgregarGenerico);
            Controls.Add(lblElemento);
            Controls.Add(dgvElementos);
            Name = "frmListadoGenerico";
            Text = "Listado";
            Load += frmListadoGenerico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvElementos).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvElementos;
        private Label lblElemento;
        private Button btnAgregarGenerico;
        private Button btnModificarGenerico;
        private Button btnEliminarGenerico;
        private ErrorProvider errorProvider1;
        private Label lblElm;
        private TextBox txtElemento;
    }
}