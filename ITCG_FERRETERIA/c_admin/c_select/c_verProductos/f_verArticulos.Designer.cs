namespace ITCG_FERRETERIA.c_admin.c_select.c_verProductos
{
    partial class f_verArticulos
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
            this.verArticulos = new System.Windows.Forms.DataGridView();
            this.ferreteriaVerArticulos1 = new ITCG_FERRETERIA.ferreteriaVerArticulos();
            this.verarticulosTableAdapter1 = new ITCG_FERRETERIA.ferreteriaVerArticulosTableAdapters.verarticulosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.verArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerArticulos1)).BeginInit();
            this.SuspendLayout();
            // 
            // verArticulos
            // 
            this.verArticulos.AllowUserToAddRows = false;
            this.verArticulos.AllowUserToDeleteRows = false;
            this.verArticulos.BackgroundColor = System.Drawing.Color.Maroon;
            this.verArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.verArticulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verArticulos.Location = new System.Drawing.Point(0, 0);
            this.verArticulos.Name = "verArticulos";
            this.verArticulos.ReadOnly = true;
            this.verArticulos.Size = new System.Drawing.Size(683, 387);
            this.verArticulos.TabIndex = 0;
            // 
            // ferreteriaVerArticulos1
            // 
            this.ferreteriaVerArticulos1.DataSetName = "ferreteriaVerArticulos";
            this.ferreteriaVerArticulos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verarticulosTableAdapter1
            // 
            this.verarticulosTableAdapter1.ClearBeforeFill = true;
            // 
            // f_verArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.verArticulos);
            this.Name = "f_verArticulos";
            this.Text = "Ver Articulos";
            this.Load += new System.EventHandler(this.f_verArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.verArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerArticulos1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView verArticulos;
        private ferreteriaVerArticulosTableAdapters.verarticulosTableAdapter verarticulosTableAdapter1;
        private ferreteriaVerArticulos ferreteriaVerArticulos1;
    }
}