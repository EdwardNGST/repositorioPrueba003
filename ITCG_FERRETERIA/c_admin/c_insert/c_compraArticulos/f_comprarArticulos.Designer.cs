namespace ITCG_FERRETERIA.c_admin.c_insert.c_compraArticulos
{
    partial class f_comprarArticulos
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClaveproducto = new System.Windows.Forms.TextBox();
            this.txtClaveproveedor = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.ferreteriaVerArticulos = new ITCG_FERRETERIA.ferreteriaVerArticulos();
            this.verarticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verarticulosTableAdapter = new ITCG_FERRETERIA.ferreteriaVerArticulosTableAdapters.verarticulosTableAdapter();
            this.codigoADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.ferreteriaVerProveedores = new ITCG_FERRETERIA.ferreteriaVerProveedores();
            this.verproveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verproveedoresTableAdapter = new ITCG_FERRETERIA.ferreteriaVerProveedoresTableAdapters.verproveedoresTableAdapter();
            this.codigoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrePDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verarticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verproveedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(119, 121);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(29, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clave de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Clave de Proveedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(29, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad";
            // 
            // txtClaveproducto
            // 
            this.txtClaveproducto.Location = new System.Drawing.Point(130, 34);
            this.txtClaveproducto.Name = "txtClaveproducto";
            this.txtClaveproducto.Size = new System.Drawing.Size(175, 20);
            this.txtClaveproducto.TabIndex = 17;
            // 
            // txtClaveproveedor
            // 
            this.txtClaveproveedor.Location = new System.Drawing.Point(130, 60);
            this.txtClaveproveedor.Name = "txtClaveproveedor";
            this.txtClaveproveedor.Size = new System.Drawing.Size(175, 20);
            this.txtClaveproveedor.TabIndex = 18;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(130, 86);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(90, 20);
            this.txtCant.TabIndex = 19;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(311, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(628, 459);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Maroon;
            this.tabPage1.Controls.Add(this.dgvProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(620, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver Productos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Maroon;
            this.tabPage2.Controls.Add(this.dgvProveedores);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(620, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ver Proveedores";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoGenerateColumns = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoADataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.dgvProductos.DataSource = this.verarticulosBindingSource;
            this.dgvProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductos.Location = new System.Drawing.Point(3, 3);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(614, 427);
            this.dgvProductos.TabIndex = 0;
            // 
            // ferreteriaVerArticulos
            // 
            this.ferreteriaVerArticulos.DataSetName = "ferreteriaVerArticulos";
            this.ferreteriaVerArticulos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verarticulosBindingSource
            // 
            this.verarticulosBindingSource.DataMember = "verarticulos";
            this.verarticulosBindingSource.DataSource = this.ferreteriaVerArticulos;
            // 
            // verarticulosTableAdapter
            // 
            this.verarticulosTableAdapter.ClearBeforeFill = true;
            // 
            // codigoADataGridViewTextBoxColumn
            // 
            this.codigoADataGridViewTextBoxColumn.DataPropertyName = "Codigo_A";
            this.codigoADataGridViewTextBoxColumn.HeaderText = "Codigo_A";
            this.codigoADataGridViewTextBoxColumn.Name = "codigoADataGridViewTextBoxColumn";
            this.codigoADataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoADataGridViewTextBoxColumn.Width = 78;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 69;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 53;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Width = 62;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "Stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockDataGridViewTextBoxColumn.Width = 60;
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AutoGenerateColumns = false;
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoPDataGridViewTextBoxColumn,
            this.nombrePDataGridViewTextBoxColumn,
            this.numTelDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn});
            this.dgvProveedores.DataSource = this.verproveedoresBindingSource;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(3, 3);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(614, 427);
            this.dgvProveedores.TabIndex = 0;
            // 
            // ferreteriaVerProveedores
            // 
            this.ferreteriaVerProveedores.DataSetName = "ferreteriaVerProveedores";
            this.ferreteriaVerProveedores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verproveedoresBindingSource
            // 
            this.verproveedoresBindingSource.DataMember = "verproveedores";
            this.verproveedoresBindingSource.DataSource = this.ferreteriaVerProveedores;
            // 
            // verproveedoresTableAdapter
            // 
            this.verproveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // codigoPDataGridViewTextBoxColumn
            // 
            this.codigoPDataGridViewTextBoxColumn.DataPropertyName = "Codigo_P";
            this.codigoPDataGridViewTextBoxColumn.HeaderText = "Codigo_P";
            this.codigoPDataGridViewTextBoxColumn.Name = "codigoPDataGridViewTextBoxColumn";
            this.codigoPDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoPDataGridViewTextBoxColumn.Width = 78;
            // 
            // nombrePDataGridViewTextBoxColumn
            // 
            this.nombrePDataGridViewTextBoxColumn.DataPropertyName = "Nombre_P";
            this.nombrePDataGridViewTextBoxColumn.HeaderText = "Nombre_P";
            this.nombrePDataGridViewTextBoxColumn.Name = "nombrePDataGridViewTextBoxColumn";
            this.nombrePDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombrePDataGridViewTextBoxColumn.Width = 82;
            // 
            // numTelDataGridViewTextBoxColumn
            // 
            this.numTelDataGridViewTextBoxColumn.DataPropertyName = "Num_Tel";
            this.numTelDataGridViewTextBoxColumn.HeaderText = "Num_Tel";
            this.numTelDataGridViewTextBoxColumn.Name = "numTelDataGridViewTextBoxColumn";
            this.numTelDataGridViewTextBoxColumn.ReadOnly = true;
            this.numTelDataGridViewTextBoxColumn.Width = 75;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 77;
            // 
            // f_comprarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(951, 483);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtClaveproveedor);
            this.Controls.Add(this.txtClaveproducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Name = "f_comprarArticulos";
            this.Text = "Comprar Articulos";
            this.Load += new System.EventHandler(this.f_comprarArticulos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verarticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verproveedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClaveproducto;
        private System.Windows.Forms.TextBox txtClaveproveedor;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TabPage tabPage2;
        private ferreteriaVerArticulos ferreteriaVerArticulos;
        private System.Windows.Forms.BindingSource verarticulosBindingSource;
        private ferreteriaVerArticulosTableAdapters.verarticulosTableAdapter verarticulosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private ferreteriaVerProveedores ferreteriaVerProveedores;
        private System.Windows.Forms.BindingSource verproveedoresBindingSource;
        private ferreteriaVerProveedoresTableAdapters.verproveedoresTableAdapter verproveedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrePDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
    }
}