using DTMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenuMvc {
	public interface IDataAccessObject{
		void AggiungiMenu(Menu menu);
	}
	public class DataAccessObject : IDataAccessObject {
		public void AggiungiMenu(Menu menu) {
			//throw new NotImplementedException();
		}
	}
}