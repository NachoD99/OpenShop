using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    public class Pago
    {
        public OrdenCompra OrdenCompra { get; set; }
        public bool Efectivo { get; set; }
        public Tarjeta Tarjeta { get; set; }

        public Pago(OrdenCompra OrdenCompra, bool Efectivo)
        {
            this.OrdenCompra = OrdenCompra;
            this.Efectivo = Efectivo;
        }
        public Pago(OrdenCompra OrdenCompra, Tarjeta Tarjeta)
        {
            this.OrdenCompra = OrdenCompra;
            this.Tarjeta = Tarjeta;
        }
        public Pago() { }
    }
}
