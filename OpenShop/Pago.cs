using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    public class Pago
    {
        public bool Efectivo { get; set; }
        public Tarjeta Tarjeta { get; set; }
        public string TipoTarjeta { get; set; }

        public Pago(bool Efectivo)
        {
            this.Efectivo = Efectivo;
        }
        public Pago(Tarjeta Tarjeta, string TipoTarjeta)
        {
            this.Tarjeta = Tarjeta;
            this.TipoTarjeta = TipoTarjeta;
        }
        public Pago() { }

        OrdenCompra OrdenJson = new OrdenCompra();
        public void generarPago(bool metodoSeleccionado, OrdenCompra ordenJson, int tipoTarjeta)
        {
            ordenJson = OrdenJson.obtenerDatosOrdenDeCompra();

            if(metodoSeleccionado)
            {
                Pago pagoRealizado = new Pago(true);
            }
            else
            {
                Tarjeta tarjeta = ordenJson.Cliente.Tarjeta.ElementAt(tipoTarjeta);
                Pago pagoRealizado = new Pago(tarjeta, tarjeta.EntidadEmisora);
            }
            
        }
    }
}
