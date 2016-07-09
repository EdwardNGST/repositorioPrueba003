namespace ITCG_FERRETERIA.c_empleado
{
    partial class f_asignarCodCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodClie = new System.Windows.Forms.TextBox();
            this.lblNuevoCliente = new System.Windows.Forms.LinkLabel();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo del Cliente";
            // 
            // txtCodClie
            // 
            this.txtCodClie.Location = new System.Drawing.Point(141, 39);
            this.txtCodClie.Name = "txtCodClie";
            this.txtCodClie.Size = new System.Drawing.Size(148, 20);
            this.txtCodClie.TabIndex = 1;
            // 
            // lblNuevoCliente
            // 
            this.lblNuevoCliente.AutoSize = true;
            this.lblNuevoCliente.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblNuevoCliente.Location = new System.Drawing.Point(128, 62);
            this.lblNuevoCliente.Name = "lblNuevoCliente";
            this.lblNuevoCliente.Size = new System.Drawing.Size(74, 13);
            this.lblNuevoCliente.TabIndex = 2;
            this.lblNuevoCliente.TabStop = true;
            this.lblNuevoCliente.Text = "Nuevo Cliente";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(127, 90);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // f_asignarCodCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(323, 131);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblNuevoCliente);
            this.Controls.Add(this.txtCodClie);
            this.Controls.Add(this.label1);
            this.Name = "f_asignarCodCliente";
            this.Text = "Ventas - Codigo del Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.f_asignarCodCliente_FormClosing);
            this.Load += new System.EventHandler(this.f_asignarCodCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodClie;
        private System.Windows.Forms.LinkLabel lblNuevoCliente;
        private System.Windows.Forms.Button btnSiguiente;
    }
}