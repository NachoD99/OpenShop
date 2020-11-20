using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShop
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Dni { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Provincia { get; set; }
        public List<Tarjeta> Tarjeta { get; set; }

        public Cliente() { }

        public Cliente(int IdCliente, string Nombre, string Apellido, string Correo,
            string Dni, string Domicilio, string Ciudad, string Provincia, List<Tarjeta> Tarjeta)
        {
            this.IdCliente = IdCliente;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Correo = Correo;
            this.Dni = Dni;
            this.Domicilio = Domicilio;
            this.Ciudad = Ciudad;
            this.Provincia = Provincia;
            this.Tarjeta = Tarjeta;
        }
    }
}
