/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 14/9/2022
 * Hora: 23:47
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_3
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona
	{
		//Atributos
		
		private string nombre;
		private int edad, dni;
		private DateTime fechaNacimiento;
		
		
		//Constructores
		
		public Persona(string nombre, int edad, int dni)
		{
			this.nombre = nombre;
			this.edad = edad;
			this.dni = dni;
		}	
		
		public Persona(string nombre, DateTime fecNac, int dni)
		{
			System.TimeSpan fecha;
			
			this.nombre = nombre;
			this.dni = dni;
			
			this.fechaNacimiento = fecNac;
			DateTime fechaActual = DateTime.Now;
			fecha = fechaActual - fechaNacimiento;
			var result = fecha.TotalDays;
			this.edad = (int)result/365;
		}
		
		
		//Propiedades
		
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}
		
		
		//Metodos
				
		public string imprimir()
		{
			return(nombre + " (" + edad + ") " + dni);
		}
		
		public bool esMayorQue(Persona p){
			if(this.edad > p.edad){
				return true;
			} else {
				return false;
			}
		}
		
	}
}
