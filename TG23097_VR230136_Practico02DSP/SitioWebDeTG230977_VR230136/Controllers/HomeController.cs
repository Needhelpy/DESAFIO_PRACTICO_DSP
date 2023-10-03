using SitioWebDeAM232253.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebDeAM232253.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Dropdown categorias
            categorias ct = new categorias();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            ViewBag.Ofertas = obj.CargarDatos();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}