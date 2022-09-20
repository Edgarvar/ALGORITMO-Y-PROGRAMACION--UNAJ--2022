/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 30/8/2022
 * Hora: 02:35
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
			int sum=0; int i=1;
			
//			instruccion erronea en el while( ';' ).
			while (i<=10); 
			{
			sum += i++;
			}

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}