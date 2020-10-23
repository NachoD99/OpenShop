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
        public OrdenCompra OrdenDeCompra { get; set; }

        public Pago(int IdPago, FormaPago FormaDePago, decimal Monto, OrdenCompra OrdenDeCompra)
        {
            this.IdPago = IdPago;
            this.FormaDePago = FormaDePago;
            this.Monto = Monto;
            this.OrdenDeCompra = OrdenDeCompra;
        }
        public Pago() { }
        public decimal sumarTotalDeCompra(OrdenCompra orden)
        {
            decimal montoTotal = 0;

            foreach (var i in orden.ArticulosVendidos)
            {
                montoTotal = i.Precio + montoTotal;
            }
            return montoTotal;
        }



        //public Pago generarOrdenDePago ()
        //{
        //7   OrdenDeCompra.obtenerDatosOrdenDeCompra();

        //Pago pago = new Pago (100,FormaDePago, Monto, OrdenDeCompra);
        //return pago;
        //}
    }
}
