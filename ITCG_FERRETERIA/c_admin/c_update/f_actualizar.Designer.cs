namespace ITCG_FERRETERIA.c_admin.c_update
{
    partial class f_actualizar
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
            this.btnActualizarClientes = new System.Windows.Forms.Button();
            this.btnActualizarProduco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnActualizarClientes
            // 
            this.btnActualizarClientes.Location = new System.Drawing.Point(79, 12);
            this.btnActualizarClientes.Name = "btnActualizarClientes";
            this.btnActualizarClientes.Size = new System.Drawing.Size(125, 23);
            this.btnActualizarClientes.TabIndex = 0;
            this.btnActualizarClientes.Text = "Actualizar Clientes";
            this.btnActualizarClientes.UseVisualStyleBackColor = true;
            this.btnActualizarClientes.Click += new System.EventHandler(this.btnActualizarClientes_Click);
            // 
            // btnActualizarProduco
            // 
            this.btnActualizarProduco.Location = new System.Drawing.Point(79, 41);
            this.btnActualizarProduco.Name = "btnActualizarProduco";
            this.btnActualizarProduco.Size = new System.Drawing.Size(125, 23);
            this.btnActualizarProduco.TabIndex = 1;
            this.btnActualizarProduco.Text = "Actualizar Proveedores";
            this.btnActualizarProduco.UseVisualStyleBackColor = true;
            this.btnActualizarProduco.Click += new System.EventHandler(this.btnActualizarProduco_Click);
            // 
            // f_actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(275, 79);
            this.Controls.Add(this.btnActualizarProduco);
            this.Controls.Add(this.btnActualizarClientes);
            this.Name = "f_actualizar";
            this.Text = "Menú Actualizar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_actualizar_FormClosing);
            this.Load += new System.EventHandler(this.f_actualizar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarClientes;
        private System.Windows.Forms.Button btnActualizarProduco;
    }
}