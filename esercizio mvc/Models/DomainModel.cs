using DTMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MenuMvc;

namespace MenuMvc {
	public interface IMenu{
		void AggiungiMenu(Menu menu);
	}
	public class DomainModel : IMenu {
		DataAccessObject dao = new DataAccessObject();
		public void AggiungiMenu(Menu menu){
			try{
				dao.AggiungiMenu(menu);
			}catch(Exception){
				throw new Exception("Qualcosa è andato storto!");
			}
		}
	}
}