using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    class Efectivo
    {
        public Cliente Cliente { get; set; }
        public long NumeroDePago { get; set; }
        public DateTime FechaDePago { get; set; }

        public Efectivo(Cliente Cliente, long NumeroDePago, DateTime FechaDePago)
        {
            this.Cliente = Cliente;
            this.NumeroDePago = NumeroDePago;
            this.FechaDePago = FechaDePago;
        }

        public void pagar(decimal montoTotal)
        {
            System.Console.WriteLine("El monto a pagar es: " + montoTotal);
        }
    }
}
