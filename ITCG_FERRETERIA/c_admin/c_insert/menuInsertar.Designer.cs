namespace ITCG_FERRETERIA.c_admin.c_insert
{
    partial class menuInsertar
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
            this.btnInsertarCliente = new System.Windows.Forms.Button();
            this.btnComprarArticulos = new System.Windows.Forms.Button();
            this.btnInsertarArticulo = new System.Windows.Forms.Button();
            this.btnInsertarProveedor = new System.Windows.Forms.Button();
            this.btnInsertarEmpleado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertarCliente
            // 
            this.btnInsertarCliente.Location = new System.Drawing.Point(33, 64);
            this.btnInsertarCliente.Name = "btnInsertarCliente";
            this.btnInsertarCliente.Size = new System.Drawing.Size(129, 23);
            this.btnInsertarCliente.TabIndex = 7;
            this.btnInsertarCliente.Text = "Insertar Nuevo Cliente";
            this.btnInsertarCliente.UseVisualStyleBackColor = true;
            // 
            // btnComprarArticulos
            // 
            this.btnComprarArticulos.Location = new System.Drawing.Point(33, 93);
            this.btnComprarArticulos.Name = "btnComprarArticulos";
            this.btnComprarArticulos.Size = new System.Drawing.Size(113, 23);
            this.btnComprarArticulos.TabIndex = 6;
            this.btnComprarArticulos.Text = "Compra de Articulos";
            this.btnComprarArticulos.UseVisualStyleBackColor = true;
            // 
            // btnInsertarArticulo
            // 
            this.btnInsertarArticulo.Location = new System.Drawing.Point(33, 35);
            this.btnInsertarArticulo.Name = "btnInsertarArticulo";
            this.btnInsertarArticulo.Size = new System.Drawing.Size(129, 23);
            this.btnInsertarArticulo.TabIndex = 5;
            this.btnInsertarArticulo.Text = "Insertar Nuevo Articulo";
            this.btnInsertarArticulo.UseVisualStyleBackColor = true;
            this.btnInsertarArticulo.Click += new System.EventHandler(this.btnInsertarArticulo_Click);
            // 
            // btnInsertarProveedor
            // 
            this.btnInsertarProveedor.Location = new System.Drawing.Point(168, 64);
            this.btnInsertarProveedor.Name = "btnInsertarProveedor";
            this.btnInsertarProveedor.Size = new System.Drawing.Size(138, 23);
            this.btnInsertarProveedor.TabIndex = 4;
            this.btnInsertarProveedor.Text = "Insertar Nuevo Proveedor";
            this.btnInsertarProveedor.UseVisualStyleBackColor = true;
            this.btnInsertarProveedor.Click += new System.EventHandler(this.btnInsertarProveedor_Click);
            // 
            // btnInsertarEmpleado
            // 
            this.btnInsertarEmpleado.Location = new System.Drawing.Point(168, 35);
            this.btnInsertarEmpleado.Name = "btnInsertarEmpleado";
            this.btnInsertarEmpleado.Size = new System.Drawing.Size(138, 23);
            this.btnInsertarEmpleado.TabIndex = 8;
            this.btnInsertarEmpleado.Text = "Insertar Nuevo Empleado";
            this.btnInsertarEmpleado.UseVisualStyleBackColor = true;
            // 
            // menuInsertar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(335, 137);
            this.Controls.Add(this.btnInsertarEmpleado);
            this.Controls.Add(this.btnInsertarCliente);
            this.Controls.Add(this.btnComprarArticulos);
            this.Controls.Add(this.btnInsertarArticulo);
            this.Controls.Add(this.btnInsertarProveedor);
            this.Name = "menuInsertar";
            this.Text = "Menu Insertar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menuInsertar_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertarCliente;
        private System.Windows.Forms.Button btnComprarArticulos;
        private System.Windows.Forms.Button btnInsertarArticulo;
        private System.Windows.Forms.Button btnInsertarProveedor;
        private System.Windows.Forms.Button btnInsertarEmpleado;
    }
}