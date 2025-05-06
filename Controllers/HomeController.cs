using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP3_Usoz.Models;

namespace TP3_Usoz.Controllers;

public class HomeController : Controller
{
  public IActionResult Index()
    {
        Catalogo.InicializarDisco();
        ViewBag.disco = Catalogo.disco;
        return View();
    }
     public IActionResult ListadeTemas(int dni) 
    {
      
           if(Catalogo.disco.ContainsKey(dni)){
      
            ViewBag.Disco = Catalogo.disco[dni];
               ViewBag.DNI = dni;
       }
            return View("ListadeTemas");}
}
