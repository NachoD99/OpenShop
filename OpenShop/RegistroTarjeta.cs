using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OpenShop
{
    public partial class RegistroTarjeta : Form
    {
        OrdenCompra OrdenJson = new OrdenCompra();

        public RegistroTarjeta()
        {
            InitializeComponent();
        }
        private void RegistroTarjeta_Load(object sender, EventArgs e)
        {
            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();
            botonCargarTarjeta.Enabled = false;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaPago ventanaPago = new VentanaPago();
            ventanaPago.Show();
        }

        private void numeroIngresado_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(numeroIngresado.Text)) errorNumero.SetError(numeroIngresado, "Debe introducir su código de seguridad");

            else
            {
                if (numeroIngresado.Text.Trim().Length < 16 || numeroIngresado.Text.Trim().Length > 16)
                    errorNumero.SetError(numeroIngresado, "El largo del código es incorrecto");
                else errorNumero.Clear();
            }

        }

        private void nombreIngresado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreIngresado.Text)) errorTitular.SetError(nombreIngresado, "Debe introducir su nombre");
            else
            {
                if (!nombreIngresado.Text.All(x => char.IsLetter(x))) errorTitular.SetError(nombreIngresado, "Debe introducir solo letras");
                else errorTitular.Clear();
            }
        }

        private void codigoSeguridadIngresado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoSeguridadIngresado.Text)) errorCodigo.SetError(codigoSeguridadIngresado, "Debe introducir su código de seguridad");
            
            else
            {
                if (codigoSeguridadIngresado.Text.Trim().Length < 3 || codigoSeguridadIngresado.Text.Trim().Length > 3)
                    errorCodigo.SetError(codigoSeguridadIngresado, "Debe introducir solo 3 números");
                else errorCodigo.Clear();
            }
        }

        private void entidadIngresada_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entidadIngresada.Text)) errorEntidad.SetError(entidadIngresada, "Debe introducir un banco");
            else
            {
                if (!entidadIngresada.Text.All(x => char.IsLetter(x))) errorEntidad.SetError(entidadIngresada, "Debe introducir solo letras");
                else errorEntidad.Clear();
            }
        }
        private void fechaIngresada_ValueChanged(object sender, EventArgs e)
        {
            if (fechaIngresada.Value.Year > DateTime.Today.Year)
            {
                if (fechaIngresada.Value.Month > DateTime.Today.Month)
                {
                    errorFecha.SetError(fechaIngresada, "La fecha de vencimiento no puede ser menor a la fecha actual");
                }
            }
            else
            {
                errorFecha.Clear();
            }
            
        }

        private void dniIngresado_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(dniIngresado.Text)) errorDNI.SetError(dniIngresado, "Debe introducir el numero");
            
            else
            {
                int DNIIngresado;
                bool esDni = int.TryParse(dniIngresado.Text.Trim(), out DNIIngresado);
                if (esDni == false) errorDNI.SetError(dniIngresado, "Deben ser solo numeros");
                else
                {
                    if (dniIngresado.Text.Trim().Length < 8 || dniIngresado.Text.Trim().Length > 8)
                        errorDNI.SetError(dniIngresado, "Debe introducir 8 números");
                    else errorDNI.Clear();
                }
            }
        }

        private void comboBoxTipoTarjeta_SelectedIndexChanged(object sender, EventArgs e)
        {
            botonCargarTarjeta.Enabled = true;
        }

        private void botonCargarTarjeta_Click(object sender, EventArgs e)
        {
            vincularTarjetaACliente();
        }

        public void vincularTarjetaACliente()
        {
            if(comboBoxTipoTarjeta.Text == "Crédito")
            {
                Tarjeta tarjeta = new Tarjeta(long.Parse(numeroIngresado.Text), nombreIngresado.Text, int.Parse(codigoSeguridadIngresado.Text),
                entidadIngresada.Text, fechaIngresada.Text, long.Parse(dniIngresado.Text), comboBoxTipoTarjeta.Text);

                OrdenJson.Cliente.Tarjeta.Add(tarjeta);
            }

            if (comboBoxTipoTarjeta.Text == "Débito")
            {
                Tarjeta tarjeta = new Tarjeta(long.Parse(numeroIngresado.Text), nombreIngresado.Text, int.Parse(codigoSeguridadIngresado.Text),
                entidadIngresada.Text, fechaIngresada.Text, long.Parse(dniIngresado.Text), comboBoxTipoTarjeta.Text);

                OrdenJson.Cliente.Tarjeta.Add(tarjeta);
            }
        }

       
    }
}
