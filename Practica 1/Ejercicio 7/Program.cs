/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 25/8/2022
 * Hora: 00:23
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double suma = 0, num = -1;
			
			while(num != 0) {
				Console.WriteLine("Ingrese un numero o 0 para terminar:");
				num = Double.Parse(Console.ReadLine());
				suma+=num;
			}
			
			Console.WriteLine("La suma es: " + suma);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}