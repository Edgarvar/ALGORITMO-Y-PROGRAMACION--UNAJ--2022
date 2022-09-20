/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 30/8/2022
 * Hora: 20:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string palabra = "psicologicamente";
			int [] cantVoc = new int[] {0,0,0,0,0};
			char [] voc = new char[] {'a','e','i','o','u'};
			
			cantidadVocales(palabra, ref cantVoc);
			imprimir(cantVoc, voc);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void cantidadVocales (string palabra, ref int[] cant){
			for(int i = 0; i < palabra.Length; i++){
				char l = palabra[i];
				switch (l){
					case 'a': cant[0] = cant[0] + 1; break;
					case 'e': cant[1] = cant[1] + 1; break;
					case 'i': cant[2] = cant[2] + 1; break;
					case 'o': cant[3] = cant[3] + 1; break;
					case 'u': cant[4] = cant[4] + 1; break;
				}
			}
		}
		
		static void imprimir(int []vec, char []voc){
			for(int i = 0; i < vec.Length; i++){
				Console.WriteLine("Cantidad Vocal " + voc[i] + ": " + vec[i]);
			}
		}
		
		
	}
}