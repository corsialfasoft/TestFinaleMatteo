using DTMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuMvc {
	public interface IDataAccessObject{
		void AggiungiMenu(Menu menu, Giornata oggi);
		List<MenuCompleto> ListaMenu();
	}
	public class DataAccessObject : IDataAccessObject {
		public void AggiungiMenu(Menu menu, Giornata oggi) {
			//throw new NotImplementedException();
		}
		public List<MenuCompleto> ListaMenu(){
			List<MenuCompleto> menucompleto = new List<MenuCompleto>();
			MenuCompleto mock = new MenuCompleto{
				Primo="mock",
				Secondo="mock",
				Contorno="mock",
				Dolce="mock",
				Giorno="mock",
				Orario="mock"
			};
			menucompleto.Add(mock);
		return menucompleto;
		}
	}
}