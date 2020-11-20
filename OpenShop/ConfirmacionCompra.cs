using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenShop
{
    public partial class ConfirmacionCompra : Form
    {
        OrdenCompra OrdenJson = new OrdenCompra();
        

        public ConfirmacionCompra()
        {
            InitializeComponent();
        }

        private void ConfirmacionCompra_Load(object sender, EventArgs e)
        {
            botonConfirmar.Enabled = false;

            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();

            dataGridViewArticulos.DataSource = OrdenJson.ArticulosVendidos;
           
            labelNombre.Text = "Nombre: " + OrdenJson.Cliente.Nombre;
            labelApellido.Text = "Apellido: " +OrdenJson.Cliente.Apellido;
            labelDNI.Text = "DNI: " + OrdenJson.Cliente.Dni;

            labelProvincia.Text = "Provincia: " + OrdenJson.Cliente.Provincia;

            labelCiudad.Text = "Ciudad: " + OrdenJson.Cliente.Ciudad;

            labelDireccion.Text = "Dirección: " + OrdenJson.Cliente.Domicilio;

            labelMontoPagado.Text = "Monto total: $" + OrdenJson.Monto;

        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaPago ventanaPago = new VentanaPago();
            ventanaPago.Show();
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {
            Pago pago = new Pago();
            bool metodoDePagoSeleccionado = false;

            if (VentanaPago.MetodoElegido == "Efectivo")
            {
                metodoDePagoSeleccionado = true;
                pago.generarPago(metodoDePagoSeleccionado, OrdenJson, VentanaPago.IndiceSeleccionado);
            }

            if (VentanaPago.MetodoElegido == "Tarjeta de crédito" || VentanaPago.MetodoElegido == "Tarjeta de débito")
            {
                metodoDePagoSeleccionado = false;
                pago.generarPago(metodoDePagoSeleccionado, OrdenJson, VentanaPago.IndiceSeleccionado);
            }

            OrdenPaga ordenParaCarrito = new OrdenPaga();

            ordenParaCarrito.generarOrdenACarrito();
            
            OrdenPaga factura = new OrdenPaga(OrdenJson, pago);

            var facturaEnArchivo = JsonConvert.SerializeObject(factura, Formatting.Indented);
            System.IO.File.WriteAllText("factura.json", facturaEnArchivo);

            MessageBox.Show("Su compra fue registrada con éxito.\n¡Muchas gracias por comprar en Open Shop!");
            
        }

        private void botonOK_Click(object sender, EventArgs e)
        {
            if (VentanaPago.CodigoVerificacion == long.Parse(textBoxConfirmacion.Text))
            {
                botonConfirmar.Enabled = true;

                MessageBox.Show("Código correcto!");
            }
            else
            {
                MessageBox.Show("Código incorrecto, por favor intente nuevamente.");
            }
        }
    }
}
