/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 30/8/2022
 * Hora: 02:10
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
//			ERROR! tenemos una variable redeclarada. En este caso la variable i.
			int i=0;
			for(int i=1;i<10;){ 
				Console.WriteLine(i++);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}