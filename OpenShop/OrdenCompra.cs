using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShop
{
    public class OrdenCompra
    {
        public List<ArticulosVendidos> ArticulosVendidos { get; set; } = new List<ArticulosVendidos>();
        public Cliente Cliente { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Monto { get; set; }
        static public OrdenCompra OrdenJson { get; set; } = new OrdenCompra();

        public OrdenCompra() { }
        public OrdenCompra(List<ArticulosVendidos> ArticulosVendidos, Cliente Cliente, DateTime FechaVenta, decimal Monto)
        {
            this.ArticulosVendidos = ArticulosVendidos;
            this.Cliente = Cliente;
            this.FechaVenta = FechaVenta;
            this.Monto = Monto;
        }

        public OrdenCompra obtenerDatosOrdenDeCompra()
        {
            var file = @"c:\datos\carrito.json";

            if (System.IO.File.Exists(file))
            {
                string contenidoOrdenCarritoEnJson = System.IO.File.ReadAllText(file);
                return JsonConvert.DeserializeObject<OrdenCompra>(contenidoOrdenCarritoEnJson);
            }
            else
            {
                throw new Exception("No existen datos a importar");
            }
        }
    }
}
