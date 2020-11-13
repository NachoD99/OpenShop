using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    class Pago
    {
        public int IdPago { get; set; }
        public FormaPago FormaDePago { get; set; }
        public decimal Monto { get; set; }

        public Pago(int IdPago, FormaPago FormaDePago, decimal Monto)
        {
            this.IdPago = IdPago;
            this.FormaDePago = FormaDePago;
            this.Monto = Monto;
        }
        public Pago() { }
    }
}
