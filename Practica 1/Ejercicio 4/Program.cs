/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 25/8/2022
 * Hora: 00:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese un número del 1 al 12:");
			int num = Int16.Parse(Console.ReadLine());
			
			switch (num) {
				case 1:
					Console.WriteLine("Enero");
					break;
				case 2:
					Console.WriteLine("Febrero");
					break;
				case 3:
					Console.WriteLine("Marzo");
					break;
				case 4:
					Console.WriteLine("Abril");
					break;
				case 5:
					Console.WriteLine("Mayo");
					break;
				case 6:
					Console.WriteLine("Junio");
					break;
				case 7:
					Console.WriteLine("Julio");
					break;
				case 8:
					Console.WriteLine("Agosto");
					break;
				case 9:
					Console.WriteLine("Septiembre");
					break;
				case 10:
					Console.WriteLine("Octubre");
					break;
				case 11:
					Console.WriteLine("Noviembre");
					break;
				case 12:
					Console.WriteLine("Diciembre");
					break;
			}
					
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}