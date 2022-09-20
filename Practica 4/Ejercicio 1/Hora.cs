/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 14/9/2022
 * Hora: 22:26
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Ejercicio_1
{
	/// <summary>
	/// Description of Hora.
	/// </summary>
	public class Hora
	{
		int hour, minutes, seconds;
		
//		Constructor ejercicio 1
		public Hora(int h, int m, int s){
			this.hour = h;
			this.minutes = m;
			this.seconds = s;
		}
		
//		Constructor ejercicio 2
		public Hora(string h){
			string [] partes;
			partes = h.Split(new char [] {':'});
			this.hour = int.Parse(partes[0]);
			this.minutes = int.Parse(partes[1]);
			this.seconds = int.Parse(partes[2]);
		}
		
		public void imprimir(){
			Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS", hour, minutes, seconds);
		}
		
	}
}
