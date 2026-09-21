namespace TP1_Articulos
{
    partial class frmMenuPrincipal
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
            errorProvider1 = new ErrorProvider(components);
            btnArticulos = new Button();
            btnCategorias = new Button();
            btnMarcas = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnArticulos
            // 
            btnArticulos.Anchor = AnchorStyles.Left;
            btnArticulos.Location = new Point(54, 202);
            btnArticulos.Name = "btnArticulos";
            btnArticulos.Size = new Size(108, 75);
            btnArticulos.TabIndex = 3;
            btnArticulos.Text = "Articulos";
            btnArticulos.UseCompatibleTextRendering = true;
            btnArticulos.UseVisualStyleBackColor = true;
            btnArticulos.Click += btnArticulos_Click;
            // 
            // btnCategorias
            // 
            btnCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnCategorias.Location = new Point(239, 202);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(101, 75);
            btnCategorias.TabIndex = 4;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // btnMarcas
            // 
            btnMarcas.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnMarcas.Location = new Point(418, 202);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(99, 75);
            btnMarcas.TabIndex = 5;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(575, 463);
            Controls.Add(btnMarcas);
            Controls.Add(btnCategorias);
            Controls.Add(btnArticulos);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            Load += frmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnMarcas;
        private Button btnCategorias;
        private Button btnArticulos;
    }
}