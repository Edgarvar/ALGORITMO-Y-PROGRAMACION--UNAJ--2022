/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 30/8/2022
 * Hora: 02:37
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
			string pal1, pal2;
			bool sonPali;
			int lon, pos;
			
			Console.WriteLine("Ingrese dos palabras para verificar si son semipalindromas: ");
			pal1 = Console.ReadLine();
			pal2 = Console.ReadLine();
			
			if (pal1.Length == pal2.Length) {
				sonPali = true;
				lon = pal1.Length;
				pos = lon - 1;
				
				for (int i = 0; i<lon; i++) {
					if(pal1[i] != pal2[pos]){
						sonPali = false;
						break;
					} else {
						pos--;
					}
					
				}
			} else {
				sonPali=false;
			}
			
			if(sonPali){
				Console.WriteLine("Si son semipalindromas.");
			} else {
				Console.WriteLine("No son semipalindromas.");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}