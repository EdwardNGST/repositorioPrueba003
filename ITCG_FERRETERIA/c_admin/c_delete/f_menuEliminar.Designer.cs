namespace ITCG_FERRETERIA.c_admin.c_delete
{
    partial class f_menuEliminar
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
            this.btndespedirEmpleado = new System.Windows.Forms.Button();
            this.btnInhabilitarCliente = new System.Windows.Forms.Button();
            this.btnInhabilitarProducto = new System.Windows.Forms.Button();
            this.btnInhabilitarProveedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btndespedirEmpleado
            // 
            this.btndespedirEmpleado.Location = new System.Drawing.Point(12, 21);
            this.btndespedirEmpleado.Name = "btndespedirEmpleado";
            this.btndespedirEmpleado.Size = new System.Drawing.Size(152, 23);
            this.btndespedirEmpleado.TabIndex = 0;
            this.btndespedirEmpleado.Text = "Despedir Empleado";
            this.btndespedirEmpleado.UseVisualStyleBackColor = true;
            this.btndespedirEmpleado.Click += new System.EventHandler(this.btndespedirEmpleado_Click);
            // 
            // btnInhabilitarCliente
            // 
            this.btnInhabilitarCliente.Location = new System.Drawing.Point(170, 21);
            this.btnInhabilitarCliente.Name = "btnInhabilitarCliente";
            this.btnInhabilitarCliente.Size = new System.Drawing.Size(122, 23);
            this.btnInhabilitarCliente.TabIndex = 1;
            this.btnInhabilitarCliente.Text = "Inhabilitar Cliente";
            this.btnInhabilitarCliente.UseVisualStyleBackColor = true;
            this.btnInhabilitarCliente.Click += new System.EventHandler(this.btnInhabilitarCliente_Click);
            // 
            // btnInhabilitarProducto
            // 
            this.btnInhabilitarProducto.Location = new System.Drawing.Point(12, 50);
            this.btnInhabilitarProducto.Name = "btnInhabilitarProducto";
            this.btnInhabilitarProducto.Size = new System.Drawing.Size(122, 23);
            this.btnInhabilitarProducto.TabIndex = 2;
            this.btnInhabilitarProducto.Text = "Inhabilitar Producto";
            this.btnInhabilitarProducto.UseVisualStyleBackColor = true;
            this.btnInhabilitarProducto.Click += new System.EventHandler(this.btnInhabilitarProducto_Click);
            // 
            // btnInhabilitarProveedor
            // 
            this.btnInhabilitarProveedor.Location = new System.Drawing.Point(140, 50);
            this.btnInhabilitarProveedor.Name = "btnInhabilitarProveedor";
            this.btnInhabilitarProveedor.Size = new System.Drawing.Size(152, 23);
            this.btnInhabilitarProveedor.TabIndex = 3;
            this.btnInhabilitarProveedor.Text = "Inhabilitar Proveedor";
            this.btnInhabilitarProveedor.UseVisualStyleBackColor = true;
            this.btnInhabilitarProveedor.Click += new System.EventHandler(this.btnInhabilitarProveedor_Click);
            // 
            // f_menuEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(304, 84);
            this.Controls.Add(this.btnInhabilitarProveedor);
            this.Controls.Add(this.btnInhabilitarProducto);
            this.Controls.Add(this.btnInhabilitarCliente);
            this.Controls.Add(this.btndespedirEmpleado);
            this.Name = "f_menuEliminar";
            this.Text = "Menu Eliminar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_menuEliminar_FormClosing);
            this.Load += new System.EventHandler(this.f_menuEliminar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btndespedirEmpleado;
        private System.Windows.Forms.Button btnInhabilitarCliente;
        private System.Windows.Forms.Button btnInhabilitarProducto;
        private System.Windows.Forms.Button btnInhabilitarProveedor;
    }
}