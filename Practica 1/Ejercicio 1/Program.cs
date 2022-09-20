/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 24/8/2022
 * Hora: 02:09
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
// 1) Para cada una de las siguientes líneas de código verifique cuáles son permitidas por el compilador y en tal caso en
//qué estado quedan las variables involucradas en la declaración al ejecutarse: 
using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// 1) Para cada una de las siguientes líneas de código verifique cuáles son permitidas por el compilador y en tal caso en
			//qué estado quedan las variables involucradas en la declaración al ejecutarse: 
//			int a, b, c; Permitida
//			int a; int b; int c; Permitida
//			int a=1; int b=2; int c=3; Permitida
//			int b; int c; int a=b=c=1; Permitida
//			int c; int a, b = c = 1; Permitida
//			int c; int a=2, b = c = 1; Permitida
//			int a=2, b, c, d = 2*a; Permitida
//			int a=2, int b=3, int c=4; NO Permitida
//			int a=2; b=3; c=4; No Permitida
//			int a; int c=a; Hay que asignarle valor a la variable 'a'
//			char c='A', string st="Hola"; No Permitida
//			char c='A'; string st="Hol"; Permitida
//			char c='A', st="Hola"; No Permitida
			
			Console.WriteLine(st);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}