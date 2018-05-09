using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
	class esercizio1 {
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
			Console.WriteLine("------------");
			string input="sto testando il testando il testando";
			char[] separatore = {' '};
			string[] splittata = input.Split(separatore);
			int tot = 0;		
			int indice=0;
			for(indice=0;indice<splittata.Length;indice++){
				if(tot <splittata.Length){
				int count=0;
					for(int j=0; j<splittata.Length; j++){
						if(splittata[indice]==splittata[j]){
							count++;
						}
					}
			Console.WriteLine("{0}---- {1}",splittata[indice], count);
			tot = tot+count;
			count=0;
			//indice++;
				}
			}
				
		}
		//public List<int> Ordina(List<int>)
	}
}
