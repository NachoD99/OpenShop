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
            /*
            int n = 0;
             foreach (var i in OrdenJson.ArticulosVendidos)
            {
                dataGridViewArticulos.Rows[n].Cells[0].Value = i.Nombre;
                dataGridViewArticulos.Rows[n].Cells[1].Value = i.Descripcion;
                dataGridViewArticulos.Rows[n].Cells[2].Value = i.Marca;
                dataGridViewArticulos.Rows[n].Cells[3].Value = i.Precio;
                
                n++;
            }
             */
            labelNombre.Text = "Nombre: " + OrdenJson.Cliente.Nombre;
            labelApellido.Text = "Apellido: " +OrdenJson.Cliente.Apellido;
            labelDNI.Text = "DNI: " + OrdenJson.Cliente.Dni;

            labelProvincia.Text = "Provincia: " + OrdenJson.Cliente.Provincia;

            labelCiudad.Text = "Ciudad: " + OrdenJson.Cliente.Ciudad;

            labelDireccion.Text = "Dirección: " + OrdenJson.Cliente.Domicilio;

            labelMontoPagado.Text = "Monto total: $" + OrdenJson.Monto;

            
            if (VentanaPago.MetodoElegido == "Efectivo")
            {
                Pago Pago = new Pago(OrdenJson, true);
            }
            
            if (VentanaPago.MetodoElegido == "Tarjeta de crédito")
            {
                
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaPago ventanaPago = new VentanaPago();
            ventanaPago.Show();
        }

        private void botonConfirmar_Click(object sender, EventArgs e)
        {


            OrdenPaga ordenParaCarrito = new OrdenPaga();

            ordenParaCarrito.generarOrdenACarrito();

            //OrdenPaga factura = new OrdenPaga(OrdenJson, Pago);

            //var facturaEnArchivo = JsonConvert.SerializeObject(ordenConfirmada, Formatting.Indented);
            //System.IO.File.WriteAllText("factura.json", facturaEnArchivo);

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
