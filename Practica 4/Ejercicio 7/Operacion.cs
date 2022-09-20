/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 18/9/2022
 * Hora: 18:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_7
{
	/// <summary>
	/// Description of Operacion.
	/// </summary>
	public class Operacion
	{
		/*Atributos*/
		private double operando1, operando2;
		private string operador;
		
		
		/*Constructor*/
		public Operacion(double op1, double op2, string operador)
		{
			this.operando1 = op1;
			this.operando2 = op2;
			this.operador = operador;
		}
		
		
		/*Metodos*/
		public double evaluar()
		{
			double resultado; /* Creamos una variable para guardar el resultado de la operación. */
			
			switch(operador)
			{
				case "+": 
					resultado = operando1 + operando2;
					return resultado;
				case "-":
					resultado = operando1 - operando2;
					return resultado;
				case "*":
					resultado = operando1 * operando2;
					return resultado;
				case "/":
					resultado = operando1 / operando2;
					return resultado;
				default:
					return 0;
			}
			
			
			/* Intento con IF Fallido!!! xD */
//			if(operador == "+"){
//				resultado = operando1 + operando2;
//				return resultado; 
//			}
//			if(operador == "-"){
//				resultado = operando1 - operando2;
//				return resultado;
//			}
//			if(operador == "*"){
//				resultado = operando1 * operando2;
//				return resultado;
//			}
//			if(operador == "/"){
//				resultado = operando1 / operando2;
//				return resultado;
//			}
		}
		
	}
}
