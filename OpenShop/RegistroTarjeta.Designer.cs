namespace OpenShop
{
    partial class RegistroTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroTarjeta));
            this.botonVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeroIngresado = new System.Windows.Forms.TextBox();
            this.nombreIngresado = new System.Windows.Forms.TextBox();
            this.codigoSeguridadIngresado = new System.Windows.Forms.TextBox();
            this.entidadIngresada = new System.Windows.Forms.TextBox();
            this.fechaIngresada = new System.Windows.Forms.TextBox();
            this.dniIngresado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.errorNumero = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTitular = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEntidad = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorFecha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.botonCargarTarjeta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTipoTarjeta = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEntidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(688, 398);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 0;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número de la tarjeta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del titular";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo de seguridad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entidad bancaria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha de vencimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "DNI del titular";
            // 
            // numeroIngresado
            // 
            this.numeroIngresado.Location = new System.Drawing.Point(337, 60);
            this.numeroIngresado.Name = "numeroIngresado";
            this.numeroIngresado.Size = new System.Drawing.Size(121, 20);
            this.numeroIngresado.TabIndex = 7;
            this.numeroIngresado.TextChanged += new System.EventHandler(this.numeroIngresado_TextChanged);
            // 
            // nombreIngresado
            // 
            this.nombreIngresado.Location = new System.Drawing.Point(337, 107);
            this.nombreIngresado.Name = "nombreIngresado";
            this.nombreIngresado.Size = new System.Drawing.Size(121, 20);
            this.nombreIngresado.TabIndex = 8;
            this.nombreIngresado.TextChanged += new System.EventHandler(this.nombreIngresado_TextChanged);
            // 
            // codigoSeguridadIngresado
            // 
            this.codigoSeguridadIngresado.Location = new System.Drawing.Point(337, 154);
            this.codigoSeguridadIngresado.Name = "codigoSeguridadIngresado";
            this.codigoSeguridadIngresado.Size = new System.Drawing.Size(121, 20);
            this.codigoSeguridadIngresado.TabIndex = 9;
            this.codigoSeguridadIngresado.TextChanged += new System.EventHandler(this.codigoSeguridadIngresado_TextChanged);
            // 
            // entidadIngresada
            // 
            this.entidadIngresada.Location = new System.Drawing.Point(337, 200);
            this.entidadIngresada.Name = "entidadIngresada";
            this.entidadIngresada.Size = new System.Drawing.Size(121, 20);
            this.entidadIngresada.TabIndex = 10;
            this.entidadIngresada.TextChanged += new System.EventHandler(this.entidadIngresada_TextChanged);
            // 
            // fechaIngresada
            // 
            this.fechaIngresada.Location = new System.Drawing.Point(337, 246);
            this.fechaIngresada.Name = "fechaIngresada";
            this.fechaIngresada.Size = new System.Drawing.Size(121, 20);
            this.fechaIngresada.TabIndex = 11;
            this.fechaIngresada.TextChanged += new System.EventHandler(this.fechaIngresada_TextChanged);
            // 
            // dniIngresado
            // 
            this.dniIngresado.Location = new System.Drawing.Point(337, 296);
            this.dniIngresado.Name = "dniIngresado";
            this.dniIngresado.Size = new System.Drawing.Size(121, 20);
            this.dniIngresado.TabIndex = 12;
            this.dniIngresado.TextChanged += new System.EventHandler(this.dniIngresado_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Registro de tarjeta";
            // 
            // errorNumero
            // 
            this.errorNumero.ContainerControl = this;
            // 
            // errorTitular
            // 
            this.errorTitular.ContainerControl = this;
            // 
            // errorCodigo
            // 
            this.errorCodigo.ContainerControl = this;
            // 
            // errorEntidad
            // 
            this.errorEntidad.ContainerControl = this;
            // 
            // errorFecha
            // 
            this.errorFecha.ContainerControl = this;
            // 
            // errorDNI
            // 
            this.errorDNI.ContainerControl = this;
            // 
            // botonCargarTarjeta
            // 
            this.botonCargarTarjeta.Location = new System.Drawing.Point(87, 398);
            this.botonCargarTarjeta.Name = "botonCargarTarjeta";
            this.botonCargarTarjeta.Size = new System.Drawing.Size(75, 23);
            this.botonCargarTarjeta.TabIndex = 14;
            this.botonCargarTarjeta.Text = "Cargar";
            this.botonCargarTarjeta.UseVisualStyleBackColor = true;
            this.botonCargarTarjeta.Click += new System.EventHandler(this.botonCargarTarjeta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(128, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Tipo de tarjeta";
            // 
            // comboBoxTipoTarjeta
            // 
            this.comboBoxTipoTarjeta.FormattingEnabled = true;
            this.comboBoxTipoTarjeta.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.comboBoxTipoTarjeta.Location = new System.Drawing.Point(337, 345);
            this.comboBoxTipoTarjeta.Name = "comboBoxTipoTarjeta";
            this.comboBoxTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoTarjeta.TabIndex = 16;
            this.comboBoxTipoTarjeta.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoTarjeta_SelectedIndexChanged);
            // 
            // RegistroTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxTipoTarjeta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.botonCargarTarjeta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dniIngresado);
            this.Controls.Add(this.fechaIngresada);
            this.Controls.Add(this.entidadIngresada);
            this.Controls.Add(this.codigoSeguridadIngresado);
            this.Controls.Add(this.nombreIngresado);
            this.Controls.Add(this.numeroIngresado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botonVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistroTarjeta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Tarjeta";
            this.Load += new System.EventHandler(this.RegistroTarjeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTitular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEntidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox numeroIngresado;
        private System.Windows.Forms.TextBox nombreIngresado;
        private System.Windows.Forms.TextBox codigoSeguridadIngresado;
        private System.Windows.Forms.TextBox entidadIngresada;
        private System.Windows.Forms.TextBox fechaIngresada;
        private System.Windows.Forms.TextBox dniIngresado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorNumero;
        private System.Windows.Forms.ErrorProvider errorTitular;
        private System.Windows.Forms.ErrorProvider errorCodigo;
        private System.Windows.Forms.ErrorProvider errorEntidad;
        private System.Windows.Forms.ErrorProvider errorFecha;
        private System.Windows.Forms.ErrorProvider errorDNI;
        private System.Windows.Forms.Button botonCargarTarjeta;
        private System.Windows.Forms.ComboBox comboBoxTipoTarjeta;
        private System.Windows.Forms.Label label8;
    }
}