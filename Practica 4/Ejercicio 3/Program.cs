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
	class Program
	{
		/* En este Ejercicio abarcaremos los ejercios 3, 4, 5 y 6. */
		public static void Main(string[] args)
		{
			
			char opcion;
			Persona persona;
			ArrayList listadoPersonas = new ArrayList();
			Persona personaMayor = null;
			
			/*Menu de opciones*/
			Console.WriteLine("Eliga una opción:");
			Console.WriteLine("a. Agregar persona por NOMBRE DNI EDAD");
			Console.WriteLine("b. Agregar persona por NOMBRE DNI FechaDeNacimiento");
			Console.WriteLine("s. Para salir");
			
			opcion = char.Parse(Console.ReadLine()); /*Lectura de opción*/
			Console.Clear(); /*Limpiamos consola */
			
			while(opcion != 's'){ /* Si la opcion seleccionada es 's', se sale del bucle */
				
				string p, nombre;
				int edad, dni;
				
				switch(opcion){
						case 'a': {
							Console.WriteLine("Ingrese los datos de la siguiente manera => Roman 34343434 28");
							p = Console.ReadLine(); /* Lectura de datos */
							string [] datos = p.Split(new char[]{' '}); /* Separamos los datos y los guardamos en un array de string */
							/*Guardamos cada datos en la variable correspondiente */
							nombre = datos[0];
							dni = int.Parse(datos[1]);
							edad = int.Parse(datos[2]);
							
							persona = new Persona(nombre, edad, dni); /*Usamos el constructor*/
							
							listadoPersonas.Add(persona); /*Lo agregamos al ArrayList listadosPersonas */
							
							Console.WriteLine("Registro exitoso!");
							Console.WriteLine("*************************");
							break;
						}
						case 'b': {
							int dia, mes, anio;
							Console.WriteLine("Ingrese los datos de la siguiente manera => Roman 31313131 9/12/2018");
							p = Console.ReadLine(); /* Lectura de datos */
							string [] datos = p.Split(new char[]{' '}); /* Separamos los datos y los guardamos en un array de string */
							/*Guardamos los datos en las variables correspondiente */
							nombre = datos[0];
							dni = int.Parse(datos[1]);
							string [] fecha = datos[2].Split(new char[]{'/'}); /*Separamos cada dato de la fecha de nacimiento  y los guardamos en variables*/
							anio = int.Parse(fecha[2]);
							mes = int.Parse(fecha[1]);
							dia = int.Parse(fecha[0]);
							DateTime fechaNacimiento = new DateTime(anio, mes, dia); /* Hacemos uso del DateTime */
							                          
							persona = new Persona(nombre, fechaNacimiento, dni); /* Usamos el segundo tipo de constructor de la clase Persona */
							listadoPersonas.Add(persona); /* Agregamos a la persona al ArrayList listadoPersonas */
							Console.WriteLine("Registro exitoso!");
							Console.WriteLine("*************************");
							break;
						}
				}
				
				
				
				/*Menu de opciones*/
				Console.WriteLine("Eliga una opción:");
				Console.WriteLine("a. Agregar persona por NOMBRE DNI EDAD");
				Console.WriteLine("b. Agregar persona por NOMBRE DNI FechaDeNacimiento");
				Console.WriteLine("s. Para salir");
				
				opcion = char.Parse(Console.ReadLine());
				
				Console.Clear(); /* Limpiamos consola */
			}
			
			listado(listadoPersonas); /* llamamos a la función estatica listado para imprimir la lista de personas inscriptas */
			
			Console.WriteLine("****************************");
			
			if(listadoPersonas.Count > 0){
				personaMayor = (Persona)listadoPersonas[0];
				
				foreach(Persona per in listadoPersonas){
					if(per.esMayorQue(personaMayor)){
						personaMayor = per;
					}
				}
			}
			
			Console.WriteLine("La persona mayor es: {0}", personaMayor.Nombre);
			Console.ReadKey(true);
		}
		
		static void listado(ArrayList lista){
			for(int i=0; i < lista.Count; i++){
				Persona personaImprimir = (Persona)lista[i];
				string strImprimir = (i+1) + ") " + personaImprimir.imprimir();
				Console.WriteLine(strImprimir);
			}
		}
		
	}
}