using DTMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MenuMvc;

namespace esercizio_mvc.Controllers {
	public class HomeController : Controller {
		public ActionResult Index() {
			return View();
		}

		public ActionResult About() {
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact() {
			ViewBag.Message = "Your contact page.";

			return View();
		}

		public ActionResult aggiungimenu(){
			return View();
		}
		[HttpPost]
		public ActionResult aggiungimenu(string _Primo, string _Secondo, string _Contorno, string _Dolce){
			DomainModel dm = new DomainModel();
			Menu NuovoMenu = new Menu{
				Primo=_Primo,
				Secondo=_Secondo,
				Contorno=_Contorno,
				Dolce=_Dolce
			};
			try{
				dm.AggiungiMenu(NuovoMenu);
				ViewBag.Message="Menu inserito correttamente!";
			}catch(Exception){
				ViewBag.Message="Qualcosa è andato storto!";
			}
			return View();
		}
	}
}