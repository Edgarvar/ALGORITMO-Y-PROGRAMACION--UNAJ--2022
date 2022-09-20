/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 24/8/2022
 * Hora: 23:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese su nombre:");
			
			string name = Console.ReadLine();
			
			Console.WriteLine("Ingrese apellido:");
			string lastName = Console.ReadLine();
			
			Console.WriteLine("¡Hola! ¿Como estas " + name + " " + lastName + "?");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}