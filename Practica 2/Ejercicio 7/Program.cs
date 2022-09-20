/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 1/9/2022
 * Hora: 14:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [,] matriz = new int[,] {{1,2,3,4,5},{6,7,8,9,10}};
			int suma = 0;
			
			sumaMatriz(matriz, ref suma);
			
			Console.WriteLine("La suma de todos los elementos de la matriz es: " + suma);
			Console.ReadKey(true);
		}
		
		static void sumaMatriz (int [,]matriz, ref int suma){
			for(int i = 0; i < matriz.GetLength(0); i++){
				for(int j = 0; j < matriz.GetLength(1); j++){
					suma = suma + matriz[i,j];
				}
			}	
		}
	}
}