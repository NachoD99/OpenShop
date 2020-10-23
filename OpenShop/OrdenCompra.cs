using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShop
{
    class OrdenCompra
    {
        public int IdOrden { get; set; }
        public List<ArticulosVendidos> ArticulosVendidos { get; set; } = new List<ArticulosVendidos>();
        public Cliente Cliente { get; set; }
        public int IdVenta { get; set; }
        static public OrdenCompra OrdenJson { get; set; } = new OrdenCompra();

        public OrdenCompra() { }
        public OrdenCompra(int IdOrden, List<ArticulosVendidos> ArticulosVendidos, Cliente Cliente, int IdVenta)
        {
            this.IdOrden = IdOrden;
            this.ArticulosVendidos = ArticulosVendidos;
            this.Cliente = Cliente;
            this.IdVenta = IdVenta;
        }

        public OrdenCompra obtenerDatosOrdenDeCompra()
        {
            if (System.IO.File.Exists("carrito.json"))
            {
                string contenidoOrdenCarritoEnJson = System.IO.File.ReadAllText("carrito.json");
                OrdenJson = JsonConvert.DeserializeObject<OrdenCompra>(contenidoOrdenCarritoEnJson);
                OrdenJson.IdOrden = 100;
            }
            
            return OrdenJson;
        }

        public void mostrarArchivoJson()
        {
           
        }
    }
}
