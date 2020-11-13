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

        public static long CodigoVerificacion { get; set; }

        public VentanaPago()
        {
            InitializeComponent();
            string contenidoOrdenCarritoEnJson = System.IO.File.ReadAllText("carrito.json");
            OrdenCompra OrdenJson = JsonConvert.DeserializeObject<OrdenCompra>(contenidoOrdenCarritoEnJson);
        }

        private void VentanaPago_Load(object sender, EventArgs e)
        {

            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();

            labelMonto.Text ="Su monto a pagar es: "+ OrdenJson.Monto;

            for (int i = 0; i < OrdenJson.Cliente.Tarjeta.Count(); i++)
            {
                if (OrdenJson.Cliente.Tarjeta.ElementAt(i).TipoTarjeta == "Crédito")
                {
                    comboTarjetaCredito.Items.Add(OrdenJson.Cliente.Tarjeta.ElementAt(i).EntidadEmisora);
                }
                if (OrdenJson.Cliente.Tarjeta.ElementAt(i).TipoTarjeta == "Débito")
                {
                    comboTarjetaDebito.Items.Add(OrdenJson.Cliente.Tarjeta.ElementAt(i).EntidadEmisora);
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
            var rand = new Random();

            if (opcionEfectivo.Checked == true)
            {
                
                long codigoPago = rand.Next();
                CodigoVerificacion = codigoPago;
                MessageBox.Show("Usted ha pagado en efectivo.\nSu código de pago es: \n\t\t"+codigoPago.ToString()+"\nPor favor, anótelo para finalizar su compra");
            }

            if (tarjetaCredito.Checked == true)
            {
                long codigoPago = rand.Next();
                CodigoVerificacion = codigoPago;
                MessageBox.Show("Usted ha pagado con tarjeta de crédito.\nSu código de pago es: \n\t\t" + codigoPago.ToString() + "\nPor favor, anótelo para finalizar su compra");
            }

            if (tarjetaDebito.Checked == true)
            {
                long codigoPago = rand.Next();
                CodigoVerificacion = codigoPago;
                MessageBox.Show("Usted ha pagado con tarjeta de débito.\nSu código de pago es: \n\t\t" + codigoPago.ToString() + "\nPor favor, anótelo para finalizar su compra");
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

        private void opcionEfectivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tarjetaCredito_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void labelMonto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
