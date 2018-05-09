using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTMenu {
	public class MenuCompleto{
		string _Primo;
		string _Secondo;
		string _Contorno;
		string _Dolce;
		string _Giorno;
		string _Orario;

		public MenuCompleto() {
		}

		public string Primo { get => _Primo; set => _Primo = value; }
		public string Secondo { get => _Secondo; set => _Secondo = value; }
		public string Contorno { get => _Contorno; set => _Contorno = value; }
		public string Dolce { get => _Dolce; set => _Dolce = value; }
		public string Giorno { get => _Giorno; set => _Giorno = value; }
		public string Orario { get => _Orario; set => _Orario = value; }
	}
	public class Menu {
		string _Primo;
		string _Secondo;
		string _Contorno;
		string _Dolce;

		public Menu() {}

		public string Primo { get => _Primo; set => _Primo = value; }
		public string Secondo { get => _Secondo; set => _Secondo = value; }
		public string Contorno { get => _Contorno; set => _Contorno = value; }
		public string Dolce { get => _Dolce; set => _Dolce = value; }
	}
	public class Giornata {
		string _Giorno;
		string _Orario;

		public Giornata() {
		}

		public string Giorno { get => _Giorno; set => _Giorno = value; }
		public string Orario { get => _Orario; set => _Orario = value; }
	}

}