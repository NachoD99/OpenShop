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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija su método de pago";
            // 
            // opcionEfectivo
            // 
            this.opcionEfectivo.AutoSize = true;
            this.opcionEfectivo.Location = new System.Drawing.Point(77, 120);
            this.opcionEfectivo.Name = "opcionEfectivo";
            this.opcionEfectivo.Size = new System.Drawing.Size(64, 17);
            this.opcionEfectivo.TabIndex = 1;
            this.opcionEfectivo.TabStop = true;
            this.opcionEfectivo.Text = "Efectivo";
            this.opcionEfectivo.UseVisualStyleBackColor = true;
            // 
            // botonPagar
            // 
            this.botonPagar.Location = new System.Drawing.Point(77, 320);
            this.botonPagar.Name = "botonPagar";
            this.botonPagar.Size = new System.Drawing.Size(75, 23);
            this.botonPagar.TabIndex = 3;
            this.botonPagar.Text = "PAGAR";
            this.botonPagar.UseVisualStyleBackColor = true;
            this.botonPagar.Click += new System.EventHandler(this.botonPagar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(659, 399);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 4;
            this.botonVolver.Text = "VOLVER";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // tarjetaCredito
            // 
            this.tarjetaCredito.AutoSize = true;
            this.tarjetaCredito.Location = new System.Drawing.Point(77, 170);
            this.tarjetaCredito.Name = "tarjetaCredito";
            this.tarjetaCredito.Size = new System.Drawing.Size(109, 17);
            this.tarjetaCredito.TabIndex = 5;
            this.tarjetaCredito.TabStop = true;
            this.tarjetaCredito.Text = "Tarjeta de Crédito";
            this.tarjetaCredito.UseVisualStyleBackColor = true;
            // 
            // comboTarjetaDebito
            // 
            this.comboTarjetaDebito.FormattingEnabled = true;
            this.comboTarjetaDebito.Location = new System.Drawing.Point(210, 221);
            this.comboTarjetaDebito.Name = "comboTarjetaDebito";
            this.comboTarjetaDebito.Size = new System.Drawing.Size(121, 21);
            this.comboTarjetaDebito.TabIndex = 8;
            this.comboTarjetaDebito.Text = "Tarjetas";
            // 
            // tarjetaDebito
            // 
            this.tarjetaDebito.AutoSize = true;
            this.tarjetaDebito.Location = new System.Drawing.Point(77, 221);
            this.tarjetaDebito.Name = "tarjetaDebito";
            this.tarjetaDebito.Size = new System.Drawing.Size(113, 17);
            this.tarjetaDebito.TabIndex = 7;
            this.tarjetaDebito.TabStop = true;
            this.tarjetaDebito.Text = "Tarjetda de Débito";
            this.tarjetaDebito.UseVisualStyleBackColor = true;
            // 
            // comboTarjetaCredito
            // 
            this.comboTarjetaCredito.FormattingEnabled = true;
            this.comboTarjetaCredito.Location = new System.Drawing.Point(210, 170);
            this.comboTarjetaCredito.Name = "comboTarjetaCredito";
            this.comboTarjetaCredito.Size = new System.Drawing.Size(121, 21);
            this.comboTarjetaCredito.TabIndex = 6;
            this.comboTarjetaCredito.Text = "Tarjetas";
            // 
            // botonConfirmar
            // 
            this.botonConfirmar.Location = new System.Drawing.Point(437, 399);
            this.botonConfirmar.Name = "botonConfirmar";
            this.botonConfirmar.Size = new System.Drawing.Size(150, 23);
            this.botonConfirmar.TabIndex = 10;
            this.botonConfirmar.Text = "Confirmar medio de pago";
            this.botonConfirmar.UseVisualStyleBackColor = true;
            this.botonConfirmar.Click += new System.EventHandler(this.botonConfirmar_Click);
            // 
            // botonAgregarTarjeta
            // 
            this.botonAgregarTarjeta.Location = new System.Drawing.Point(363, 194);
            this.botonAgregarTarjeta.Name = "botonAgregarTarjeta";
            this.botonAgregarTarjeta.Size = new System.Drawing.Size(124, 23);
            this.botonAgregarTarjeta.TabIndex = 9;
            this.botonAgregarTarjeta.Text = "Agregar Tarjeta";
            this.botonAgregarTarjeta.UseVisualStyleBackColor = true;
            this.botonAgregarTarjeta.Click += new System.EventHandler(this.botonAgregarTarjeta_Click);
            // 
            // labelMonto
            // 
            this.labelMonto.AutoSize = true;
            this.labelMonto.Location = new System.Drawing.Point(77, 84);
            this.labelMonto.Name = "labelMonto";
            this.labelMonto.Size = new System.Drawing.Size(108, 13);
            this.labelMonto.TabIndex = 11;
            this.labelMonto.Text = "Su monto a pagar es:";
            // 
            // VentanaPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
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