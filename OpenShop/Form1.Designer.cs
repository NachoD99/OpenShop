namespace OpenShop
{
    partial class PaginaInicial
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaInicial));
            this.labelCliente = new System.Windows.Forms.Label();
            this.botonPagar = new System.Windows.Forms.Button();
            this.listaDeCompra = new System.Windows.Forms.DataGridView();
            this.botonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listaDeCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(12, 91);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(113, 24);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente: ";
            // 
            // botonPagar
            // 
            this.botonPagar.BackColor = System.Drawing.Color.Black;
            this.botonPagar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPagar.ForeColor = System.Drawing.Color.White;
            this.botonPagar.Location = new System.Drawing.Point(620, 388);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(130, 45);
            this.botonPagar.TabIndex = 2;
            this.botonPagar.Text = "Siguiente";
            this.botonPagar.UseVisualStyleBackColor = false;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // listaDeCompra
            // 
            this.listaDeCompra.AllowUserToAddRows = false;
            this.listaDeCompra.AllowUserToDeleteRows = false;
            this.listaDeCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaDeCompra.Location = new System.Drawing.Point(12, 118);
            this.listaDeCompra.Name = "listaDeCompra";
            this.listaDeCompra.ReadOnly = true;
            this.listaDeCompra.Size = new System.Drawing.Size(760, 245);
            this.listaDeCompra.TabIndex = 3;
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonSalir.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.Color.White;
            this.botonSalir.Location = new System.Drawing.Point(35, 388);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(113, 45);
            this.botonSalir.TabIndex = 4;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(95, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(580, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "RESUMEN DE COMPRA";
            // 
            // PaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.listaDeCompra);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.labelCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaginaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobranza";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaDeCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.DataGridView listaDeCompra;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label label1;
    }
}

