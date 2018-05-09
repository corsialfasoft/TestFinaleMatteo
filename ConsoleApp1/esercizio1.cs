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
			Console.WriteLine("-----------");
			List<int> test1= new List<int>{9,8,7,6,5,4,3,2,1};
			List<int> test2= new List<int>{0,9,8,7,6,5,4,3,2,1,7,6,5,4,3,2,1};
			List<int> test1Ordinato = Ordina(test1);
			List<int> test2Ordinato = Ordina(test2);
			Console.WriteLine("stampo la prima lista ordinata");
			for(int a=0; a<test1.Count;a++){
				Console.Write("{0}  ",test1Ordinato[a]);
			}
			Console.WriteLine("");
			Console.WriteLine("stampo la seconda lista ordinata");
			for(int a=0; a<test2.Count;a++){
				Console.Write("{0}  ",test2Ordinato[a]);
			}
			Console.WriteLine("");
			Console.WriteLine("stampo la lista congiunta ordinata");
			List<int> concatenazione = test1.Concat(test2).ToList();
			for(int a=0; a<concatenazione.Count;a++){
				Console.Write("{0}  ",concatenazione[a]);
			}
		}
		public static List<int> Ordina(List<int> input){
			for(int i=0;i<input.Count;i++){
				for(int j=i;j<input.Count;j++){
					if(input[i]>input[j]){
						int tmp;
						tmp= input[i];
						input[i]=input[j];
						input[j]=tmp;
					}
				}
			}
			return input;
		}
	}
}
