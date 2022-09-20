/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 25/8/2022
 * Hora: 00:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int i=0, valMax=-9999, valMin=9999, promedio=0, suma=0;
			int num = -9999;
			
			Console.WriteLine("Ingrese una seguidilla de numeros o 0 para terminar:");
			num = Int16.Parse(Console.ReadLine());
			
			while(num != 0){				
				if(num > valMax){
					valMax = num;
				};
				
				if(num < valMin){
					valMin = num;
				};
				
				
				suma+=num;
				i++;		
				
				Console.WriteLine("Ingrese una seguidilla de numeros o 0 para terminar:");
				num = Int16.Parse(Console.ReadLine());
				
			}
			promedio = suma / i;
			
			
			Console.WriteLine("El valor minimo es: " + valMin);
			Console.WriteLine("El valor maximo es: " + valMax);
			Console.WriteLine("El promedio es: " + promedio);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}