using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GIV.Models
{
    public class CategoriaProducto
    {
        public Guid     IdCategoria     { get; set; }
        public string   Nombre          { get; set; }
        public string   Descripcion     { get; set; }

    }
}