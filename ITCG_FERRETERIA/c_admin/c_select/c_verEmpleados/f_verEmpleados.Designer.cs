namespace ITCG_FERRETERIA.c_admin.c_select.c_verEmpleados
{
    partial class f_verEmpleados
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
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.verEmpleados1 = new ITCG_FERRETERIA.verEmpleados();
            this.verempleadosTableAdapter1 = new ITCG_FERRETERIA.verEmpleadosTableAdapters.verempleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verEmpleados1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.Maroon;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(683, 387);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // verEmpleados1
            // 
            this.verEmpleados1.DataSetName = "verEmpleados";
            this.verEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verempleadosTableAdapter1
            // 
            this.verempleadosTableAdapter1.ClearBeforeFill = true;
            // 
            // f_verEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 387);
            this.Controls.Add(this.dgvEmpleados);
            this.Name = "f_verEmpleados";
            this.Text = "Ver Empleados";
            this.Load += new System.EventHandler(this.f_verEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verEmpleados1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpleados;
        private verEmpleados verEmpleados1;
        private verEmpleadosTableAdapters.verempleadosTableAdapter verempleadosTableAdapter1;
    }
}