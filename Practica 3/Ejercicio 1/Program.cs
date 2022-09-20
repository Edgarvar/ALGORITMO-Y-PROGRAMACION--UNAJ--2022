/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 6/9/2022
 * Hora: 02:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Cuantas palabras desea ingresar?");
			int res = int.Parse(Console.ReadLine());
			
			string [] lista = new string[res];
			string pal;
			
			for(int i = 0; i < lista.Length; i++){
				if(i == 0){
					Console.WriteLine("Ingrese la primer palabra:");
					pal = Console.ReadLine();
					lista[i] = pal;
				} else {
					Console.WriteLine("Ingrese siguiente palabra:");
					pal = Console.ReadLine();
					lista[i] = pal;
				}
				
			}
			
			Console.WriteLine("*********************");
			
			foreach(string e in lista) {
				palindromos(e);
			}
			
			Console.ReadKey(true);
		}
		static void palindromos(string palabra){
			Stack letras = new Stack();
			
			for(int i = 0; i < palabra.Length; i++){
				letras.Push(palabra[i]);
			}
			
			string newStr = "";
			
			while(letras.Count != 0){
				newStr = newStr + letras.Pop();
			}
			
			if(palabra == newStr){
				Console.WriteLine(palabra + " => ES PALINDROMO");
			} else {
				Console.WriteLine(palabra + " => NO ES PALINDROMO.");
			}
		}
	}
}