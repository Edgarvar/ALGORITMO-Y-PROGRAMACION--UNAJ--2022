/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 18/9/2022
 * Hora: 18:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			Operacion op = new Operacion(10, 2, "*");
			
			Console.WriteLine(op.evaluar());
			
			Console.ReadKey(true);
		}
	}
}