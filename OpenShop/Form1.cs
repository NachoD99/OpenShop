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
    public partial class PaginaInicial : Form
    {
        
        public PaginaInicial()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrdenCompra OrdenJson = new OrdenCompra();
            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();
           
            labelCliente.Text = "Cliente: "+OrdenJson.Cliente.Nombre +" "+ OrdenJson.Cliente.Apellido;

            listaDeCompra.DataSource = OrdenJson.ArticulosVendidos;
        }

        private void botonPagar_Click(object sender, EventArgs e)
        {
            
            VentanaPago ventanaPago = new VentanaPago();

            ventanaPago.Show();

            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
