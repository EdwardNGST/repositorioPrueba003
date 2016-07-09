namespace ITCG_FERRETERIA.c_admin.c_select.c_verCompras
{
    partial class f_verCompras
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
            this.dgvCompras = new System.Windows.Forms.DataGridView();
            this.verCompras = new ITCG_FERRETERIA.verCompras();
            this.vercomprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vercomprasTableAdapter = new ITCG_FERRETERIA.verComprasTableAdapters.vercomprasTableAdapter();
            this.codigoDeCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDelProveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vercomprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCompras
            // 
            this.dgvCompras.AutoGenerateColumns = false;
            this.dgvCompras.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeCompraDataGridViewTextBoxColumn,
            this.codigoDeProductoDataGridViewTextBoxColumn,
            this.codigoDelProveedorDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaCDataGridViewTextBoxColumn});
            this.dgvCompras.DataSource = this.vercomprasBindingSource;
            this.dgvCompras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompras.Location = new System.Drawing.Point(0, 0);
            this.dgvCompras.Name = "dgvCompras";
            this.dgvCompras.Size = new System.Drawing.Size(683, 387);
            this.dgvCompras.TabIndex = 0;
            // 
            // verCompras
            // 
            this.verCompras.DataSetName = "verCompras";
            this.verCompras.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vercomprasBindingSource
            // 
            this.vercomprasBindingSource.DataMember = "vercompras";
            this.vercomprasBindingSource.DataSource = this.verCompras;
            // 
            // vercomprasTableAdapter
            // 
            this.vercomprasTableAdapter.ClearBeforeFill = true;
            // 
            // codigoDeCompraDataGridViewTextBoxColumn
            // 
            this.codigoDeCompraDataGridViewTextBoxColumn.DataPropertyName = "Codigo de Compra";
            this.codigoDeCompraDataGridViewTextBoxColumn.HeaderText = "Codigo de Compra";
            this.codigoDeCompraDataGridViewTextBoxColumn.Name = "codigoDeCompraDataGridViewTextBoxColumn";
            // 
            // codigoDeProductoDataGridViewTextBoxColumn
            // 
            this.codigoDeProductoDataGridViewTextBoxColumn.DataPropertyName = "Codigo de Producto";
            this.codigoDeProductoDataGridViewTextBoxColumn.HeaderText = "Codigo de Producto";
            this.codigoDeProductoDataGridViewTextBoxColumn.Name = "codigoDeProductoDataGridViewTextBoxColumn";
            // 
            // codigoDelProveedorDataGridViewTextBoxColumn
            // 
            this.codigoDelProveedorDataGridViewTextBoxColumn.DataPropertyName = "Codigo del Proveedor";
            this.codigoDelProveedorDataGridViewTextBoxColumn.HeaderText = "Codigo del Proveedor";
            this.codigoDelProveedorDataGridViewTextBoxColumn.Name = "codigoDelProveedorDataGridViewTextBoxColumn";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // fechaCDataGridViewTextBoxColumn
            // 
            this.fechaCDataGridViewTextBoxColumn.DataPropertyName = "Fecha_C";
            this.fechaCDataGridViewTextBoxColumn.HeaderText = "Fecha_C";
            this.fechaCDataGridViewTextBoxColumn.Name = "fechaCDataGridViewTextBoxColumn";
            // 
            // f_verCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.dgvCompras);
            this.Name = "f_verCompras";
            this.Text = "Ver Compras";
            this.Load += new System.EventHandler(this.f_verCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vercomprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCompras;
        private verCompras verCompras;
        private System.Windows.Forms.BindingSource vercomprasBindingSource;
        private verComprasTableAdapters.vercomprasTableAdapter vercomprasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDelProveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCDataGridViewTextBoxColumn;
    }
}