namespace ITCG_FERRETERIA.c_admin.c_select.c_verClientes
{
    partial class f_verClientes
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
            this.dgvVerClientes = new System.Windows.Forms.DataGridView();
            this.verClientes1 = new ITCG_FERRETERIA.verClientes();
            this.verclientesTableAdapter1 = new ITCG_FERRETERIA.verClientesTableAdapters.verclientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClientes1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerClientes
            // 
            this.dgvVerClientes.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvVerClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVerClientes.Location = new System.Drawing.Point(0, 0);
            this.dgvVerClientes.Name = "dgvVerClientes";
            this.dgvVerClientes.Size = new System.Drawing.Size(683, 387);
            this.dgvVerClientes.TabIndex = 0;
            // 
            // verClientes1
            // 
            this.verClientes1.DataSetName = "verClientes";
            this.verClientes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verclientesTableAdapter1
            // 
            this.verclientesTableAdapter1.ClearBeforeFill = true;
            // 
            // f_verClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.dgvVerClientes);
            this.Name = "f_verClientes";
            this.Text = "Ver Clientes";
            this.Load += new System.EventHandler(this.f_verClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verClientes1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerClientes;
        private verClientes verClientes1;
        private verClientesTableAdapters.verclientesTableAdapter verclientesTableAdapter1;
    }
}