using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTMenu {
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
}