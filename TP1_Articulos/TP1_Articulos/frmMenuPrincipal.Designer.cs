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
            lblSeleccion = new Label();
            cbMenuSeleccionado = new ComboBox();
            btnSeleccionMenu = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(135, 160);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(225, 15);
            lblSeleccion.TabIndex = 0;
            lblSeleccion.Text = "Seleccione el menú al que quiere ingresar";
            // 
            // cbMenuSeleccionado
            // 
            cbMenuSeleccionado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMenuSeleccionado.FormattingEnabled = true;
            cbMenuSeleccionado.Location = new Point(375, 157);
            cbMenuSeleccionado.Name = "cbMenuSeleccionado";
            cbMenuSeleccionado.Size = new Size(121, 23);
            cbMenuSeleccionado.TabIndex = 1;
            // 
            // btnSeleccionMenu
            // 
            btnSeleccionMenu.Location = new Point(545, 136);
            btnSeleccionMenu.Name = "btnSeleccionMenu";
            btnSeleccionMenu.Size = new Size(80, 62);
            btnSeleccionMenu.TabIndex = 2;
            btnSeleccionMenu.Text = "Seleccionar";
            btnSeleccionMenu.UseVisualStyleBackColor = true;
            btnSeleccionMenu.Click += btnSeleccionMenu_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSeleccionMenu);
            Controls.Add(cbMenuSeleccionado);
            Controls.Add(lblSeleccion);
            Name = "frmMenuPrincipal";
            Text = "frmMenuPrincipal";
            Load += frmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeleccion;
        private ComboBox cbMenuSeleccionado;
        private Button btnSeleccionMenu;
        private ErrorProvider errorProvider1;
    }
}