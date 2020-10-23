using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShop
{
    class ArticulosVendidos
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }

        public ArticulosVendidos() { }
        public ArticulosVendidos(int IdArticulo, string Nombre, string Marca, decimal Precio, string Descripcion)
        {
            this.IdArticulo = IdArticulo;
            this.Nombre = Nombre;
            this.Marca = Marca;
            this.Precio = Precio;
            this.Descripcion = Descripcion;
        }
    }
}
