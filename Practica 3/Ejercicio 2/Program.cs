/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 7/9/2022
 * Hora: 12:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			char opcion = 'n';
			ArrayList inscriptos = new ArrayList();
			
			while(opcion != 's'){
				Console.WriteLine("Seleccione una opción:");
				Console.WriteLine("a. Inscribir un alumno.");
				Console.WriteLine("b. Borrar un alumno.");
				Console.WriteLine("c. Indicar total de alumnos inscriptos.");
				Console.WriteLine("d. Indicar total de escuelas que al menos tienen un alumno inscripto.");
				Console.WriteLine("e. Imprimir el listado de las escuelas," +
"				                  ordenado alfabeticamente, sin repeticiones.");
				Console.WriteLine("s. Salir.");
				
				opcion = Char.Parse(Console.ReadLine());
				
				switch(opcion){
						case 'a': inscribirAlumno(ref inscriptos); break;
						case 'b': eliminar(ref inscriptos); break;
						case 'c': listadoInscriptos(inscriptos); break;
				};
				
				Console.WriteLine("***********************************");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void inscribirAlumno (ref ArrayList bd)
		{
			char op = 's';
			
			
			while(op != 'n'){
				
				string [] alumno = new string[2];
				string nombre, colegio;
				
				Console.Write("Ingrese nombre: ");
				nombre = Console.ReadLine();
				alumno[0] = nombre;
				
				Console.Write("Ingrese colegio: ");
				colegio = Console.ReadLine();
				alumno[1] = colegio;
				
				bd.Add(alumno);
				
				Console.Write("Inscribir otro alumno? s/n - ");
				op = Char.Parse(Console.ReadLine());
				
				Console.WriteLine("********************************");				
			}
		}
		
		static void eliminar (ref ArrayList db) {
			Console.Write("Ingrese nombre del alumno a eliminar: ");
			string nombre = Console.ReadLine();
			
			for(int i = 0; i < db.Count; i++){
				string [] alum = new string[2];
				alum = (string [])db[i];
				string nomAlum = (string)alum[0];
				if(nombre == nomAlum){
					db.RemoveAt(i);
				}
			}
			Console.WriteLine("********************************");
		}
		
		static void listadoInscriptos(ArrayList bd){
			string [] alum = new string[2];
			
			for(int i = 0; i < bd.Count; i++){	
				alum = (string [])bd[i];	
				Console.WriteLine("Nombre: " + ((string)alum[0]) + ". Colegio: " + ((string)alum[1]));				
			}
			
			Console.WriteLine("Cantidad de alumnos inscriptos: " + bd.Count);
			
			Console.WriteLine("********************************");
		}
	}
}