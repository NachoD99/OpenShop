namespace OpenShop
{
    partial class VentanaPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPago));
            this.label1 = new System.Windows.Forms.Label();
            this.opcionEfectivo = new System.Windows.Forms.RadioButton();
            this.botonPagar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.tarjetaCredito = new System.Windows.Forms.RadioButton();
            this.comboTarjetaDebito = new System.Windows.Forms.ComboBox();
            this.tarjetaDebito = new System.Windows.Forms.RadioButton();
            this.comboTarjetaCredito = new System.Windows.Forms.ComboBox();
            this.botonConfirmar = new System.Windows.Forms.Button();
            this.botonAgregarTarjeta = new System.Windows.Forms.Button();
            this.labelMonto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de pago";
            // 
            // opcionEfectivo
            // 
            this.opcionEfectivo.AutoSize = true;
            this.opcionEfectivo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opcionEfectivo.Location = new System.Drawing.Point(41, 120);
            this.opcionEfectivo.Name = "opcionEfectivo";
            this.opcionEfectivo.Size = new System.Drawing.Size(95, 26);
            this.opcionEfectivo.TabIndex = 1;
            this.opcionEfectivo.TabStop = true;
            this.opcionEfectivo.Text = "Efectivo";
            this.opcionEfectivo.UseVisualStyleBackColor = true;
            // 
            // botonPagar
            // 
            this.botonPagar.BackColor = System.Drawing.Color.Black;
            this.botonPagar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPagar.ForeColor = System.Drawing.Color.White;
            this.botonPagar.Location = new System.Drawing.Point(296, 276);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(111, 41);
            this.botonPagar.TabIndex = 3;
            this.botonPagar.Text = "Pagar";
            this.botonPagar.UseVisualStyleBackColor = false;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.Black;
            this.botonVolver.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.White;
            this.botonVolver.Location = new System.Drawing.Point(12, 276);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(119, 41);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // tarjetaCredito
            // 
            this.tarjetaCredito.AutoSize = true;
            this.tarjetaCredito.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjetaCredito.Location = new System.Drawing.Point(183, 120);
            this.tarjetaCredito.Name = "tarjetaCredito";
            this.tarjetaCredito.Size = new System.Drawing.Size(179, 26);
            this.tarjetaCredito.TabIndex = 5;
            this.tarjetaCredito.TabStop = true;
            this.tarjetaCredito.Text = "Tarjeta de Crédito";
            this.tarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // comboTarjetaDebito
            // 
            this.comboTarjetaDebito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTarjetaDebito.FormattingEnabled = true;
            this.comboTarjetaDebito.Location = new System.Drawing.Point(417, 170);
            this.comboTarjetaDebito.Name = "comboTarjetaDebito";
            this.comboTarjetaDebito.Size = new System.Drawing.Size(121, 27);
            this.comboTarjetaDebito.TabIndex = 8;
            this.comboTarjetaDebito.Text = "Tarjetas";
            // 
            // tarjetaDebito
            // 
            this.tarjetaDebito.AutoSize = true;
            this.tarjetaDebito.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarjetaDebito.Location = new System.Drawing.Point(417, 120);
            this.tarjetaDebito.Name = "tarjetaDebito";
            this.tarjetaDebito.Size = new System.Drawing.Size(171, 26);
            this.tarjetaDebito.TabIndex = 7;
            this.tarjetaDebito.TabStop = true;
            this.tarjetaDebito.Text = "Tarjeta de Débito";
            this.tarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // comboTarjetaCredito
            // 
            this.comboTarjetaCredito.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTarjetaCredito.FormattingEnabled = true;
            this.comboTarjetaCredito.Location = new System.Drawing.Point(183, 170);
            this.comboTarjetaCredito.Name = "comboTarjetaCredito";
            this.comboTarjetaCredito.Size = new System.Drawing.Size(121, 27);
            this.comboTarjetaCredito.TabIndex = 6;
            this.comboTarjetaCredito.Text = "Tarjetas";
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.BackColor = System.Drawing.Color.Black;
            this.botonConfirmar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonConfirmar.ForeColor = System.Drawing.Color.White;
            this.botonConfirmar.Location = new System.Drawing.Point(548, 276);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(152, 41);
            this.botonConfirmar.TabIndex = 10;
            this.botonConfirmar.Text = "Siguiente";
            this.botonConfirmar.UseVisualStyleBackColor = false;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // botonAgregarTarjeta
            // 
            this.botonAgregarTarjeta.BackColor = System.Drawing.Color.Black;
            this.botonAgregarTarjeta.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonAgregarTarjeta.ForeColor = System.Drawing.Color.White;
            this.botonAgregarTarjeta.Location = new System.Drawing.Point(592, 161);
            this.botonAgregarTarjeta.Name = "botonAgregarTarjeta";
            this.botonAgregarTarjeta.Size = new System.Drawing.Size(124, 33);
            this.botonAgregarTarjeta.TabIndex = 9;
            this.botonAgregarTarjeta.Text = "Agregar Tarjeta";
            this.botonAgregarTarjeta.UseVisualStyleBackColor = false;
            this.botonAgregarTarjeta.Click += new System.EventHandler(this.botonAgregarTarjeta_Click);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonto.Location = new System.Drawing.Point(37, 81);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(197, 22);
            this.labelMonto.TabIndex = 11;
            this.labelMonto.Text = "Su monto a pagar es: $";
            // 
            // VentanaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 329);
            this.Controls.Add(this.labelMonto);
            this.Controls.Add(this.botonConfirmar);
            this.Controls.Add(this.botonAgregarTarjeta);
            this.Controls.Add(this.comboTarjetaDebito);
            this.Controls.Add(this.tarjetaDebito);
            this.Controls.Add(this.comboTarjetaCredito);
            this.Controls.Add(this.tarjetaCredito);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonPagar);
            this.Controls.Add(this.opcionEfectivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPago";
            this.Load += new System.EventHandler(this.VentanaPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton opcionEfectivo;
        private System.Windows.Forms.Button botonPagar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.RadioButton tarjetaCredito;
        private System.Windows.Forms.ComboBox comboTarjetaDebito;
        private System.Windows.Forms.RadioButton tarjetaDebito;
        private System.Windows.Forms.ComboBox comboTarjetaCredito;
        private System.Windows.Forms.Button botonConfirmar;
        private System.Windows.Forms.Button botonAgregarTarjeta;
        private System.Windows.Forms.Label labelMonto;
    }
}