using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    class OrdenPaga
    {
        public Pago Pago { get; set; }
        public OrdenCompra OrdenCompra { get; set; }

        public OrdenPaga(Pago Pago, OrdenCompra OrdenCompra)
        {
            this.Pago = Pago;
            this.OrdenCompra = OrdenCompra;
        }
    }
}
