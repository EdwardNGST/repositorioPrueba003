namespace ITCG_FERRETERIA.c_admin.c_delete.c_despedirEmpleado
{
    partial class f_despedirEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.codigoDelEmpleadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeTelefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verempleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verEmpleados = new ITCG_FERRETERIA.verEmpleados();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verempleadosTableAdapter = new ITCG_FERRETERIA.verEmpleadosTableAdapters.verempleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verempleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AutoGenerateColumns = false;
            this.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmpleados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDelEmpleadoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.puestoDataGridViewTextBoxColumn,
            this.numeroDeTelefonoDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dgvEmpleados.DataSource = this.verempleadosBindingSource;
            this.dgvEmpleados.Location = new System.Drawing.Point(274, 51);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(618, 350);
            this.dgvEmpleados.TabIndex = 4;
            // 
            // codigoDelEmpleadoDataGridViewTextBoxColumn
            // 
            this.codigoDelEmpleadoDataGridViewTextBoxColumn.DataPropertyName = "Codigo del Empleado";
            this.codigoDelEmpleadoDataGridViewTextBoxColumn.HeaderText = "Codigo del Empleado";
            this.codigoDelEmpleadoDataGridViewTextBoxColumn.Name = "codigoDelEmpleadoDataGridViewTextBoxColumn";
            this.codigoDelEmpleadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoDelEmpleadoDataGridViewTextBoxColumn.Width = 121;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // puestoDataGridViewTextBoxColumn
            // 
            this.puestoDataGridViewTextBoxColumn.DataPropertyName = "Puesto";
            this.puestoDataGridViewTextBoxColumn.HeaderText = "Puesto";
            this.puestoDataGridViewTextBoxColumn.Name = "puestoDataGridViewTextBoxColumn";
            this.puestoDataGridViewTextBoxColumn.ReadOnly = true;
            this.puestoDataGridViewTextBoxColumn.Width = 65;
            // 
            // numeroDeTelefonoDataGridViewTextBoxColumn
            // 
            this.numeroDeTelefonoDataGridViewTextBoxColumn.DataPropertyName = "Numero de Telefono";
            this.numeroDeTelefonoDataGridViewTextBoxColumn.HeaderText = "Numero de Telefono";
            this.numeroDeTelefonoDataGridViewTextBoxColumn.Name = "numeroDeTelefonoDataGridViewTextBoxColumn";
            this.numeroDeTelefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroDeTelefonoDataGridViewTextBoxColumn.Width = 118;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 77;
            // 
            // verempleadosBindingSource
            // 
            this.verempleadosBindingSource.DataMember = "verempleados";
            this.verempleadosBindingSource.DataSource = this.verEmpleados;
            // 
            // verEmpleados
            // 
            this.verEmpleados.DataSetName = "verEmpleados";
            this.verEmpleados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(105, 86);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnInhabilitar.TabIndex = 7;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(105, 51);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(163, 20);
            this.txtIdEmpleado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id del Empleado";
            // 
            // verempleadosTableAdapter
            // 
            this.verempleadosTableAdapter.ClearBeforeFill = true;
            // 
            // f_despedirEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(904, 413);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.txtIdEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "f_despedirEmpleado";
            this.Text = "Despedir Empleado";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_despedirEmpleado_FormClosing);
            this.Load += new System.EventHandler(this.f_despedirEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verempleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.Label label1;
        private verEmpleados verEmpleados;
        private System.Windows.Forms.BindingSource verempleadosBindingSource;
        private verEmpleadosTableAdapters.verempleadosTableAdapter verempleadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDelEmpleadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeTelefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}