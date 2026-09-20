namespace TP1_Articulos
{
    partial class frmAltaMarca
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
            txtAltaMarca = new TextBox();
            lblAltaMarca = new Label();
            btnAgregarMarca = new Button();
            SuspendLayout();
            // 
            // txtAltaMarca
            // 
            txtAltaMarca.Location = new Point(102, 99);
            txtAltaMarca.Name = "txtAltaMarca";
            txtAltaMarca.Size = new Size(100, 23);
            txtAltaMarca.TabIndex = 0;
            // 
            // lblAltaMarca
            // 
            lblAltaMarca.AutoSize = true;
            lblAltaMarca.Location = new Point(45, 102);
            lblAltaMarca.Name = "lblAltaMarca";
            lblAltaMarca.Size = new Size(51, 15);
            lblAltaMarca.TabIndex = 1;
            lblAltaMarca.Text = "Nombre";
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.Location = new Point(102, 148);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(75, 23);
            btnAgregarMarca.TabIndex = 2;
            btnAgregarMarca.Text = "Agregar";
            btnAgregarMarca.UseVisualStyleBackColor = true;
            btnAgregarMarca.Click += btnAgregarMarca_Click;
            // 
            // frmAltaMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 225);
            Controls.Add(btnAgregarMarca);
            Controls.Add(lblAltaMarca);
            Controls.Add(txtAltaMarca);
            Name = "frmAltaMarca";
            Text = "frmAltaMarca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAltaMarca;
        private Label lblAltaMarca;
        private Button btnAgregarMarca;
    }
}