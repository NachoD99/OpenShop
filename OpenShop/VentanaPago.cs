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
    public partial class VentanaPago : Form
    {
        OrdenCompra OrdenJson = new OrdenCompra();
        Pago pago = new Pago();

        public VentanaPago()
        {
            InitializeComponent();
            string contenidoOrdenCarritoEnJson = System.IO.File.ReadAllText("carrito.json");
            OrdenCompra OrdenJson = JsonConvert.DeserializeObject<OrdenCompra>(contenidoOrdenCarritoEnJson);
        }

        private void VentanaPago_Load(object sender, EventArgs e)
        {
            

            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();

            labelMonto.Text ="Su monto a pagar es: "+ pago.sumarTotalDeCompra(OrdenJson);

            for (int i = 0; i < OrdenJson.Cliente.Tarjeta.Count(); i++)
            {
                if (OrdenJson.Cliente.Tarjeta.ElementAt(i).TipoTarjeta == "Crédito")
                {
                    comboTarjetaCredito.Items.Add(OrdenJson.Cliente.Tarjeta.ElementAt(i).NumeroDeTarjeta);
                }
                if (OrdenJson.Cliente.Tarjeta.ElementAt(i).TipoTarjeta == "Débito")
                {
                    comboTarjetaDebito.Items.Add(OrdenJson.Cliente.Tarjeta.ElementAt(i).NumeroDeTarjeta);
                }
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            PaginaInicial ventanaPrincipal = new PaginaInicial();

            ventanaPrincipal.Show();
        }

        private void botonAgregarTarjeta_Click(object sender, EventArgs e)
        {
            this.Close();

            RegistroTarjeta registroTarjeta = new RegistroTarjeta();

            registroTarjeta.Show();
        }

        private void botonPagar_Click(object sender, EventArgs e)
        {
            if (opcionEfectivo.Checked == true)
            {
                //LLAMAR AL METODO DE PAGO EN EFECTIVO
                
            }

            if (tarjetaCredito.Checked == true)
            {
                
            }

            if (tarjetaDebito.Checked == true)
            {
                
            }
        }

        private void tarjetaCredito_CheckedChanged(object sender, EventArgs e)
        {
            botonConfirmar.Enabled = true;
        }

        private void tarjetaDebito_CheckedChanged(object sender, EventArgs e)
        {
            botonConfirmar.Enabled = true;
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();

            ConfirmacionCompra confirmacionCompra = new ConfirmacionCompra();
            confirmacionCompra.Show();
        }
    }
}
