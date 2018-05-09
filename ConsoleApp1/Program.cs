using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
	class Program {
		static void Main(string[] args) {
			int i=2;
			while(i<31){
				Console.WriteLine("{0}",i);
				i= i+2;
			}
			Console.WriteLine("-----------");
			i= i-3;
			while(i>0){
				Console.WriteLine("{0}",i);
				i = i-2;
			}
		}
	}
}
