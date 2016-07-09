namespace ITCG_FERRETERIA.c_admin.c_update.c_actualizarClientes
{
    partial class f_actualizarClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbActualizar = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.chkNombre = new System.Windows.Forms.CheckBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.chkNum_tel = new System.Windows.Forms.CheckBox();
            this.verclientesTableAdapter1 = new ITCG_FERRETERIA.verClientesTableAdapters.verclientesTableAdapter();
            this.verClientes1 = new ITCG_FERRETERIA.verClientes();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbBuscar.SuspendLayout();
            this.gbActualizar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verClientes1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(290, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(507, 384);
            this.dgvClientes.TabIndex = 1;
            // 
            // gbBuscar
            // 
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.txtId);
            this.gbBuscar.Controls.Add(this.label3);
            this.gbBuscar.Controls.Add(this.label2);
            this.gbBuscar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbBuscar.Location = new System.Drawing.Point(2, 12);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Size = new System.Drawing.Size(282, 211);
            this.gbBuscar.TabIndex = 12;
            this.gbBuscar.TabStop = false;
            this.gbBuscar.Text = "Buscar Cliente";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(67, 85);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(155, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(101, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(174, 20);
            this.txtId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Id del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Introduce el id del proveedor que quieres buscar";
            // 
            // gbActualizar
            // 
            this.gbActualizar.Controls.Add(this.btnAceptar);
            this.gbActualizar.Controls.Add(this.label1);
            this.gbActualizar.Controls.Add(this.txtEstado);
            this.gbActualizar.Controls.Add(this.chkNombre);
            this.gbActualizar.Controls.Add(this.chkEstado);
            this.gbActualizar.Controls.Add(this.txtNombre);
            this.gbActualizar.Controls.Add(this.txtTelefono);
            this.gbActualizar.Controls.Add(this.chkNum_tel);
            this.gbActualizar.Enabled = false;
            this.gbActualizar.ForeColor = System.Drawing.Color.Snow;
            this.gbActualizar.Location = new System.Drawing.Point(2, 229);
            this.gbActualizar.Name = "gbActualizar";
            this.gbActualizar.Size = new System.Drawing.Size(282, 167);
            this.gbActualizar.TabIndex = 11;
            this.gbActualizar.TabStop = false;
            this.gbActualizar.Text = "Actualizar Datos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.ForeColor = System.Drawing.Color.Black;
            this.btnAceptar.Location = new System.Drawing.Point(112, 137);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione lo que quiere editar del Proveedor";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(137, 97);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(138, 20);
            this.txtEstado.TabIndex = 7;
            // 
            // chkNombre
            // 
            this.chkNombre.AutoSize = true;
            this.chkNombre.ForeColor = System.Drawing.Color.Snow;
            this.chkNombre.Location = new System.Drawing.Point(9, 47);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(63, 17);
            this.chkNombre.TabIndex = 1;
            this.chkNombre.Text = "Nombre";
            this.chkNombre.UseVisualStyleBackColor = true;
            this.chkNombre.CheckedChanged += new System.EventHandler(this.chkNombre_CheckedChanged);
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.ForeColor = System.Drawing.Color.Snow;
            this.chkEstado.Location = new System.Drawing.Point(9, 99);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(59, 17);
            this.chkEstado.TabIndex = 6;
            this.chkEstado.Text = "Estado";
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckedChanged += new System.EventHandler(this.chkEstado_CheckedChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(137, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(138, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 71);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(138, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // chkNum_tel
            // 
            this.chkNum_tel.AutoSize = true;
            this.chkNum_tel.ForeColor = System.Drawing.Color.Snow;
            this.chkNum_tel.Location = new System.Drawing.Point(9, 73);
            this.chkNum_tel.Name = "chkNum_tel";
            this.chkNum_tel.Size = new System.Drawing.Size(123, 17);
            this.chkNum_tel.TabIndex = 4;
            this.chkNum_tel.Text = "Número de Teléfono";
            this.chkNum_tel.UseVisualStyleBackColor = true;
            this.chkNum_tel.CheckedChanged += new System.EventHandler(this.chkNum_tel_CheckedChanged);
            // 
            // verclientesTableAdapter1
            // 
            this.verclientesTableAdapter1.ClearBeforeFill = true;
            // 
            // verClientes1
            // 
            this.verClientes1.DataSetName = "verClientes";
            this.verClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // f_actualizarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(809, 408);
            this.Controls.Add(this.gbBuscar);
            this.Controls.Add(this.gbActualizar);
            this.Controls.Add(this.dgvClientes);
            this.Name = "f_actualizarClientes";
            this.Text = "Actualizar Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_actualizarClientes_FormClosing);
            this.Load += new System.EventHandler(this.f_actualizarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbActualizar.ResumeLayout(false);
            this.gbActualizar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.verClientes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbActualizar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.CheckBox chkNombre;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.CheckBox chkNum_tel;
        private verClientesTableAdapters.verclientesTableAdapter verclientesTableAdapter1;
        private verClientes verClientes1;
    }
}