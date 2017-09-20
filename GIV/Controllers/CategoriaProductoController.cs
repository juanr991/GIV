using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GIV.Models;

namespace GIV.Controllers
{
    public class CategoriaProductoController : Controller
    {
        // GET: CategoriaProducto
        public ActionResult CategoriaControler()
        {
            List<CategoriaProducto> lista = new List<CategoriaProducto>();

            CategoriaProducto categoria1 = new CategoriaProducto();
            categoria1.IdCategoria = new Guid();
            categoria1.Nombre = "Renault";
            categoria1.Descripcion = "Categoria Francesa";
            lista.Add(categoria1);

            CategoriaProducto categoria2 = new CategoriaProducto();
            categoria2.IdCategoria = new Guid();
            categoria2.Nombre = "Mazda";
            categoria2.Descripcion = "Categoria Japonesa";
            lista.Add(categoria2);

            CategoriaProducto categoria3 = new CategoriaProducto();
            categoria3.IdCategoria = new Guid();
            categoria3.Nombre = "Chevrolet";
            categoria3.Descripcion = "Categoria Estadounidense";
            lista.Add(categoria3);




            return View(lista);
        }
    }
}