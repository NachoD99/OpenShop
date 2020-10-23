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
            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();

            dataGridViewArticulos.DataSource = OrdenJson.ArticulosVendidos;

            labelNombre.Text = "Nombre: " + OrdenJson.Cliente.Nombre + " " + OrdenJson.Cliente.Apellido;

            labelProvincia.Text = "Provincia: " + OrdenJson.Cliente.Provincia;

            labelCiudad.Text = "Ciudad: " + OrdenJson.Cliente.Ciudad;

            labelDireccion.Text = "Dirección: " + OrdenJson.Cliente.Domicilio;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Close();

            VentanaPago ventanaPago = new VentanaPago();
            ventanaPago.Show();
        }

    
    }
}
