namespace TP1_Articulos
{
    partial class frmAltaCategoria
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
            lblAltaCat = new Label();
            txtAltaCat = new TextBox();
            btnAgregarCat = new Button();
            SuspendLayout();
            // 
            // lblAltaCat
            // 
            lblAltaCat.AutoSize = true;
            lblAltaCat.Location = new Point(16, 109);
            lblAltaCat.Name = "lblAltaCat";
            lblAltaCat.Size = new Size(54, 15);
            lblAltaCat.TabIndex = 0;
            lblAltaCat.Text = "Nombre:";
            // 
            // txtAltaCat
            // 
            txtAltaCat.Location = new Point(76, 106);
            txtAltaCat.Name = "txtAltaCat";
            txtAltaCat.Size = new Size(113, 23);
            txtAltaCat.TabIndex = 1;
            // 
            // btnAgregarCat
            // 
            btnAgregarCat.Location = new Point(76, 159);
            btnAgregarCat.Name = "btnAgregarCat";
            btnAgregarCat.Size = new Size(75, 23);
            btnAgregarCat.TabIndex = 2;
            btnAgregarCat.Text = "Agregar";
            btnAgregarCat.UseVisualStyleBackColor = true;
            btnAgregarCat.Click += btnAgregarCat_Click;
            // 
            // frmAltaCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 224);
            Controls.Add(btnAgregarCat);
            Controls.Add(txtAltaCat);
            Controls.Add(lblAltaCat);
            Name = "frmAltaCategoria";
            Text = "frmAltaCategoria";
            Load += frmAltaCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAltaCat;
        private TextBox txtAltaCat;
        private Button btnAgregarCat;
    }
}