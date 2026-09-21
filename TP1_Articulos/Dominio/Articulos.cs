using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Dominio
{
    public class Articulos : EntidadBase
    {

            
            [DisplayName("Cod. de artículo")]
            public string Codigo { get; set; }
            public string Nombre { get; set; }
      
            public decimal Precio { get; set; }
            public string ImagenUrl { get; set; }
            [DisplayName("Marca")]
            public List<string> Imagenes { get; set; } = new List<string>();
            public Marcas IdMarca { get; set; } = new Marcas();
            [DisplayName("Categoria")]
            public Categorias IdCategoria { get; set; } = new Categorias();
        
            
    }
}
