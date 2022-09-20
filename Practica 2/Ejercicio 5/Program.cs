/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 30/8/2022
 * Hora: 19:27
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			string operacion = "i";
			double num1 = 0, num2 = 0;
			
			while (operacion != "") {
				Console.WriteLine("Elija la operacion que quieras hacer: ");
				Console.WriteLine("suma");
				Console.WriteLine("resta");
				Console.WriteLine("multiplicar");
				Console.WriteLine("dividir");
				Console.WriteLine("nada (para terminar con la ejecucion)");				
				operacion = Console.ReadLine();
				
				if(operacion != ""){
					
					calculadora(operacion, num1, num2);
				
				}
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void calculadora(string op, double num1, double num2) {
			double cuenta = 0;
			
			Console.WriteLine("Ingrese el primer numero: ");
			num1 = Double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese el siguiente numero: ");
			num2 = Double.Parse(Console.ReadLine());
			
			switch (op){
				case "suma": cuenta = sumar(num1, num2); break;
				case "resta": cuenta = resta(num1, num2); break;
				case "dividir": cuenta = dividir(num1, num2); break;
				case "multiplicar": cuenta = multiplicar(num1, num2); break;
			}
			
			Console.WriteLine("El resultado es: " + cuenta);
		}
		static double sumar(double num1, double num2){
			return num1 + num2;
		}
		static double resta(double num1, double num2){
			return num1 - num2;
		}
		static double multiplicar(double num1, double num2) {
			return num1 * num2;
		} 
		static double dividir(double num1, double num2) {
			return num1 / num2;
		}
	}
}