/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 25/8/2022
 * Hora: 00:18
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
			for(int i=40; i<=352; i++){
				if(i % 4 == 0){
					Console.WriteLine(i);
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}