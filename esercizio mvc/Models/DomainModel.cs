using DTMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MenuMvc;

namespace MenuMvc {
	public interface IMenu{
		void AggiungiMenu(Menu menu, Giornata oggi);
		List<MenuCompleto> ListaMenu();
	}
	public class DomainModel : IMenu {
		DataAccessObject dao = new DataAccessObject();
		public void AggiungiMenu(Menu menu, Giornata oggi){
			try{
				dao.AggiungiMenu(menu, oggi);
			}catch(Exception){
				throw new Exception("Qualcosa è andato storto!");
			}
		}
		public List<MenuCompleto> ListaMenu(){
			try{
				return dao.ListaMenu();
			}catch(Exception){
				throw new Exception("Qualcosa è andato storto!");
			}
		}
	}
}