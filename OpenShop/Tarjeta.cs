using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop
{
    class Tarjeta
    {
        public long NumeroDeTarjeta { get; set; }
        public string NombreTitular { get; set; }
        public int CodigoDeSeguridad { get; set; }
        public string EntidadEmisora { get; set; }
        public string FechaDeVencimiento { get; set; }
        public long DniTitular { get; set; }
        public string TipoTarjeta { get; set; }

        //Para tarjeta de crédito
        public int CantidadDeCuotas { get; set; }

        //Para tarjeta de débito
        public int SaldoDisponible { get; set; }

        public Tarjeta() { }
        public Tarjeta(long NumeroDeTarjeta, string NombreTitular, int CodigoDeSeguridad,
                     string EntidadEmisora, string FechaDeVencimiento, long DniTitular, string TipoTarjeta)
        {
            this.NumeroDeTarjeta = NumeroDeTarjeta;
            this.NombreTitular = NombreTitular;
            this.CodigoDeSeguridad = CodigoDeSeguridad;
            this.EntidadEmisora = EntidadEmisora;
            this.FechaDeVencimiento = FechaDeVencimiento;
            this.DniTitular = DniTitular;
            this.TipoTarjeta = TipoTarjeta;
        }
        public void pagarConTarjeta(decimal montoTotal)
        {
            System.Console.WriteLine("El monto a pagar es: " + montoTotal);
            System.Console.WriteLine("Seleccione su tipo de tarjeta:\n1-Crédito\n2-Débito");
            var opcionTarjeta = int.Parse(System.Console.ReadLine());

            if (opcionTarjeta == 1)
            {
                System.Console.WriteLine("Seleccione la cantidad de cuotas que desea pagar:");
                System.Console.WriteLine("a) 1\nb) 3\nc) 6\nd) 12");
                string opcionCantidadCuotas = System.Console.ReadLine().ToString();

                if (opcionCantidadCuotas.Contains('a'))
                {
                    System.Console.WriteLine("Pagará 1 cuota de: $" + montoTotal);
                }

                else if (opcionCantidadCuotas.Contains('b'))
                {
                    System.Console.WriteLine("Pagará 3 cuotas de: $" + (montoTotal / 3));
                }

                else if (opcionCantidadCuotas.Contains('c'))
                {
                    System.Console.WriteLine("Pagará 6 cuotas de: $" + (montoTotal / 6));
                }

                else if (opcionCantidadCuotas.Contains('d'))
                {
                    System.Console.WriteLine("Pagará 12 cuotas de: $" + (montoTotal / 12));
                }
            }
            if (opcionTarjeta == 2)
            {
                System.Console.WriteLine("Su saldo en la cuenta es: $");
            }
        }
    }
}
