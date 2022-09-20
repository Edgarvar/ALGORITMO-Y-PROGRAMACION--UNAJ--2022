/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 24/8/2022
 * Hora: 23:57
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Ingrese dos numeros que deseé sumar: ");
			
			double num1 = Double.Parse(Console.ReadLine());
			double num2 = Double.Parse(Console.ReadLine());
			
			double suma = num1 + num2;
			
			Console.WriteLine("La suma es: " + suma);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}