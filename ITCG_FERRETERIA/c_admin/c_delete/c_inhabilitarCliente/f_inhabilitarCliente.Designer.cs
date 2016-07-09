namespace ITCG_FERRETERIA.c_admin.c_delete.c_inhabilitarCliente
{
    partial class f_inhabilitarCliente
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.codigoCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verclientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verClientes = new ITCG_FERRETERIA.verClientes();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verclientesTableAdapter = new ITCG_FERRETERIA.verClientesTableAdapters.verclientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verclientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoCDataGridViewTextBoxColumn,
            this.nombreCDataGridViewTextBoxColumn,
            this.numTelDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.verclientesBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(274, 31);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(618, 350);
            this.dgvClientes.TabIndex = 7;
            // 
            // codigoCDataGridViewTextBoxColumn
            // 
            this.codigoCDataGridViewTextBoxColumn.DataPropertyName = "Codigo_C";
            this.codigoCDataGridViewTextBoxColumn.HeaderText = "Codigo_C";
            this.codigoCDataGridViewTextBoxColumn.Name = "codigoCDataGridViewTextBoxColumn";
            this.codigoCDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoCDataGridViewTextBoxColumn.Width = 78;
            // 
            // nombreCDataGridViewTextBoxColumn
            // 
            this.nombreCDataGridViewTextBoxColumn.DataPropertyName = "Nombre_C";
            this.nombreCDataGridViewTextBoxColumn.HeaderText = "Nombre_C";
            this.nombreCDataGridViewTextBoxColumn.Name = "nombreCDataGridViewTextBoxColumn";
            this.nombreCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCDataGridViewTextBoxColumn.Width = 82;
            // 
            // numTelDataGridViewTextBoxColumn
            // 
            this.numTelDataGridViewTextBoxColumn.DataPropertyName = "Num_Tel";
            this.numTelDataGridViewTextBoxColumn.HeaderText = "Num_Tel";
            this.numTelDataGridViewTextBoxColumn.Name = "numTelDataGridViewTextBoxColumn";
            this.numTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTelDataGridViewTextBoxColumn.Width = 75;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 64;
            // 
            // verclientesBindingSource
            // 
            this.verclientesBindingSource.DataMember = "verclientes";
            this.verclientesBindingSource.DataSource = this.verClientes;
            // 
            // verClientes
            // 
            this.verClientes.DataSetName = "verClientes";
            this.verClientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(105, 66);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnInhabilitar.TabIndex = 6;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(105, 31);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(163, 20);
            this.txtIDCliente.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id del Cliente";
            // 
            // verclientesTableAdapter
            // 
            this.verclientesTableAdapter.ClearBeforeFill = true;
            // 
            // f_inhabilitarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(904, 413);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label1);
            this.Name = "f_inhabilitarCliente";
            this.Text = "Inhabilitar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_inhabilitarCliente_FormClosing);
            this.Load += new System.EventHandler(this.f_inhabilitarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verclientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Label label1;
        private verClientes verClientes;
        private System.Windows.Forms.BindingSource verclientesBindingSource;
        private verClientesTableAdapters.verclientesTableAdapter verclientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}