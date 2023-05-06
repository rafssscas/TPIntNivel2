using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDominio
{
    public class Articulo
    {
        [DisplayName("Código")]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public int Precio { get; set; }

    }
}
