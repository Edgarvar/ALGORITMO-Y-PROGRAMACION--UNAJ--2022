/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 30/8/2022
 * Hora: 15:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			string palabra = "i";
			ArrayList palabras = new ArrayList();
			double cantS = 0, lonArr, por;
			
			Console.WriteLine("Ingrese una sucesión de palabras: ");
			
			while(palabra != ""){
				palabra = Console.ReadLine();
				palabras.Add(palabra);
			}
			
			palabras.Remove("");

			lonArr = palabras.Count;
			
//			En este bloque sacamos el porcentaje de palabras que empiezan con 's'
			for(int i = 0; i < palabras.Count; i++) {
				palabra = (string) palabras[i];
				char l = palabra[0];
				if(l == 's'){
					cantS++;
				}
			}
			por = cantS*100/lonArr;
			Console.WriteLine("El porcentaje de palabras con 's' es: " + por + "%");
			
//			En este bloque mostraremos la longitus de cada palabras
			foreach(string e in palabras) {
				Console.WriteLine("La longitud de la palabras " + e + " es: " + e.Length);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}