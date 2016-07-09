namespace ITCG_FERRETERIA.c_admin.c_select.c_verVentas
{
    partial class f_verVentas
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
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.verVentas = new ITCG_FERRETERIA.verVentas();
            this.verventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verventasTableAdapter = new ITCG_FERRETERIA.verVentasTableAdapters.verventasTableAdapter();
            this.nVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verventasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AutoGenerateColumns = false;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nVDataGridViewTextBoxColumn,
            this.codigoCDataGridViewTextBoxColumn,
            this.codigoPDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.iVACDataGridViewTextBoxColumn,
            this.totalCDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.dgvVentas.DataSource = this.verventasBindingSource;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.Size = new System.Drawing.Size(683, 387);
            this.dgvVentas.TabIndex = 0;
            // 
            // verVentas
            // 
            this.verVentas.DataSetName = "verVentas";
            this.verVentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verventasBindingSource
            // 
            this.verventasBindingSource.DataMember = "verventas";
            this.verventasBindingSource.DataSource = this.verVentas;
            // 
            // verventasTableAdapter
            // 
            this.verventasTableAdapter.ClearBeforeFill = true;
            // 
            // nVDataGridViewTextBoxColumn
            // 
            this.nVDataGridViewTextBoxColumn.DataPropertyName = "NV";
            this.nVDataGridViewTextBoxColumn.HeaderText = "NV";
            this.nVDataGridViewTextBoxColumn.Name = "nVDataGridViewTextBoxColumn";
            this.nVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoCDataGridViewTextBoxColumn
            // 
            this.codigoCDataGridViewTextBoxColumn.DataPropertyName = "Codigo_C";
            this.codigoCDataGridViewTextBoxColumn.HeaderText = "Codigo_C";
            this.codigoCDataGridViewTextBoxColumn.Name = "codigoCDataGridViewTextBoxColumn";
            this.codigoCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoPDataGridViewTextBoxColumn
            // 
            this.codigoPDataGridViewTextBoxColumn.DataPropertyName = "Codigo_P";
            this.codigoPDataGridViewTextBoxColumn.HeaderText = "Codigo_P";
            this.codigoPDataGridViewTextBoxColumn.Name = "codigoPDataGridViewTextBoxColumn";
            this.codigoPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "Subtotal";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            this.subtotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iVACDataGridViewTextBoxColumn
            // 
            this.iVACDataGridViewTextBoxColumn.DataPropertyName = "IVA_C";
            this.iVACDataGridViewTextBoxColumn.HeaderText = "IVA_C";
            this.iVACDataGridViewTextBoxColumn.Name = "iVACDataGridViewTextBoxColumn";
            this.iVACDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalCDataGridViewTextBoxColumn
            // 
            this.totalCDataGridViewTextBoxColumn.DataPropertyName = "Total_C";
            this.totalCDataGridViewTextBoxColumn.HeaderText = "Total_C";
            this.totalCDataGridViewTextBoxColumn.Name = "totalCDataGridViewTextBoxColumn";
            this.totalCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // f_verVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.dgvVentas);
            this.Name = "f_verVentas";
            this.Text = "Ver Ventas";
            this.Load += new System.EventHandler(this.f_verVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verventasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private verVentas verVentas;
        private System.Windows.Forms.BindingSource verventasBindingSource;
        private verVentasTableAdapters.verventasTableAdapter verventasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}