using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShop
{
    public class OrdenPaga
    {
        public OrdenCompra OrdenCompra { get; set; }
        public bool EstadoConfirmacion { get; set; }
        public Pago Pago { get; set; }

        public OrdenPaga() { }

        //PARA SERIALIZAR LA INFORMACIÓN QUE NECESITA DESPACHO
        public OrdenPaga(OrdenCompra ordenCompra, bool estadoConfirmacion)
        {
            OrdenCompra = ordenCompra;
            EstadoConfirmacion = estadoConfirmacion;
        }

        // PARA SERIALIZAR LA FACTURA
        //public OrdenPaga(OrdenCompra OrdenCompra, Pago Pago)
        //{
        //    this.OrdenCompra = OrdenCompra;
        //    this.Pago = Pago;
        //}

        OrdenCompra OrdenJson = new OrdenCompra();
        
        public void generarOrdenACarrito()
        {
            OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();
            OrdenPaga ordenConfirmada = new OrdenPaga(OrdenJson, true);
            var file = @"c:\datos\orden.json";

            if (System.IO.File.Exists(file))
            {
                var ordenEnArchivoJson = JsonConvert.SerializeObject(ordenConfirmada, Formatting.Indented);
                System.IO.File.WriteAllText("orden.json", ordenEnArchivoJson);
            }
            else
            {
                throw new Exception("No existen datos a importar");
            }
        }
    }
}
