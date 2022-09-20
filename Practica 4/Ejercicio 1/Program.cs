/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 14/9/2022
 * Hora: 22:24
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora h = new Hora(23, 30, 15);
			Hora h2 = new Hora("14:25:47");
			h.imprimir();
			h2.imprimir();
			
			Console.ReadKey(true);
		}
	}
}