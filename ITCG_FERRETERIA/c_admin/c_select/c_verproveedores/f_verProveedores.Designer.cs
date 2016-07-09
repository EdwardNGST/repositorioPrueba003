namespace ITCG_FERRETERIA.c_admin.c_select.c_verproveedores
{
    partial class f_verProveedores
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
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.ferreteriaVerProveedores1 = new ITCG_FERRETERIA.ferreteriaVerProveedores();
            this.verproveedoresTableAdapter1 = new ITCG_FERRETERIA.ferreteriaVerProveedoresTableAdapters.verproveedoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerProveedores1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProveedores.Location = new System.Drawing.Point(0, 0);
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.Size = new System.Drawing.Size(683, 387);
            this.dgvProveedores.TabIndex = 1;
            // 
            // ferreteriaVerProveedores1
            // 
            this.ferreteriaVerProveedores1.DataSetName = "ferreteriaVerProveedores";
            this.ferreteriaVerProveedores1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verproveedoresTableAdapter1
            // 
            this.verproveedoresTableAdapter1.ClearBeforeFill = true;
            // 
            // f_verProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.dgvProveedores);
            this.Name = "f_verProveedores";
            this.Text = "Ver Proveedores";
            this.Load += new System.EventHandler(this.f_verProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferreteriaVerProveedores1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProveedores;
        private ferreteriaVerProveedores ferreteriaVerProveedores1;
        private ferreteriaVerProveedoresTableAdapters.verproveedoresTableAdapter verproveedoresTableAdapter1;
    }
}