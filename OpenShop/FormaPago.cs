using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    class FormaPago
    {
        public OrdenCompra OrdenCompra { get; set; }
        public Efectivo Efectivo { get; set; }
        public Tarjeta Tarjeta { get; set; }

        public FormaPago(OrdenCompra OrdenCompra, Efectivo Efectivo)
        {
            this.OrdenCompra = OrdenCompra;
            this.Efectivo = Efectivo;
        }
        public FormaPago(OrdenCompra OrdenCompra, Tarjeta Tarjeta)
        {
            this.OrdenCompra = OrdenCompra;
            this.Tarjeta = Tarjeta;
        }
    }
}
