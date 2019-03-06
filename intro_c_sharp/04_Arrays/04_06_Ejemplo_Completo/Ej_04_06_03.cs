/*Un programa que sea capaz de almacenar los datos de 50 personas:
 * nombre, dirección, teléfono, edad (usando una tabla de structs).
 * Deberá ir pidiendo los datos uno por uno, hasta que un nombre
 * se introduzca vacío (se pulse Intro sin teclear nada).
 * Entonces deberá aparecer un menú que permita:
 * - Mostrar la lista de todos los nombres.
 * - Mostrar las personas de una cierta edad.
 * - Mostrar las personas cuya inicial sea la que el usuario indique.
 * - Salir del programa.
 *(lógicamente, este menú debe repetirse
 * hasta que se escoja la opción de "salir").
 */
 using System;
 
 public class Ejercicio_4_6_3
 {
	 //Creo la estructura
	 struct S_Persona
	 {
		 public string nombre;
		 public string direccion;
		 public string telefono;
		 public byte edad;
	 }
	 
	 public static void Main()
	 {
		 int i; //índice
		 byte edadAuxiliar;
		 char inicialAuxiliar;
		 string stringAuxiliar;
		 byte opcion;
		 
		 //Asigno memoria a la variable
		 S_Persona[] personas = new S_Persona [50];
		 
		 //Pido los datos

		 for(i = 0; i < 50; i++)
		 {
			 Console.WriteLine("Persona {0}", i+1);
			 
			 Console.Write("Nombre: ");
			 personas[i].nombre = Console.ReadLine();
			 
			 //Si el usuario presiona enter, se sale del bucle for
			 if(personas[i].nombre == "")
			 {
				 break;
			 }
			 else
			 {
				 //Paso la primera letra a mayúscula
				 stringAuxiliar = personas[i].nombre.Substring(0,1).ToUpper()
				  + personas[i].nombre.Substring(1);
			  
				 personas[i].nombre = stringAuxiliar;
			 }
			 
			 Console.Write("Dirección: ");
			 personas[i].direccion = Console.ReadLine();
			 
			 if(personas[i].direccion != "")
			 { 
				 //Paso la primera letra a mayúscula
				 stringAuxiliar = personas[i].direccion.Substring(0,1).ToUpper()
				  + personas[i].direccion.Substring(1);
			  
				 personas[i].direccion = stringAuxiliar;
			 }
			 
			 Console.Write("Teléfono: ");
			 personas[i].telefono = Console.ReadLine();
			 
			 Console.Write("Edad: ");
			 personas[i].edad = Convert.ToByte(Console.ReadLine());
		 }

		 
		 do
		 {
			 Console.WriteLine("--------------------------------------");
			 Console.WriteLine("1-Mostrar lista de nombres");
			 Console.WriteLine("2-Mostrar personas de cierta edad");
			 Console.WriteLine("3-Mostrar que empiezan con la inicial" +
			  " indicada");
			 Console.WriteLine("4-Salir");
			 Console.WriteLine("--------------------------------------");
			 Console.Write("Opción: ");
			 opcion = Convert.ToByte(Console.ReadLine());
			 Console.WriteLine("--------------------------------------");
			 	
			 switch(opcion)
			 {
				 case 1: //Muestro todos los nombres
					Console.WriteLine("Nombres: ");
					for(i = 0; i < 50; i++)
					{
						if(personas[i].nombre == "")
						{
							break;
						}
						else
						{
							Console.WriteLine(personas[i].nombre);
						}
					}
					break;
				 case 2://Mostrar personas de cierta edad
					//Pido al ususario la edad a buscar
					Console.Write("Ingrese la edad que desea buscar: ");
					edadAuxiliar = Convert.ToByte(Console.ReadLine());
					Console.WriteLine("Personas de {0} años:",
					 edadAuxiliar);
					 
					//busco las personas con esa edad
					for(i = 0; i < 50; i++)
					{
						if(personas[i].edad == edadAuxiliar)
						{
							Console.WriteLine(personas[i].nombre);
						}
					}
					break;
				 case 3://Buscar personas segun inicial
					//Pido al ususario la inicial a buscar
					Console.Write("Ingrese la inicial de las personas" +
					 "que desea buscar: ");
					inicialAuxiliar = Convert.ToChar(Console.ReadLine());
					
					//Paso a mayúsucula
					inicialAuxiliar = Char.ToUpper(inicialAuxiliar);
					
					Console.WriteLine("Personas que empiezan con {0}:",
					 inicialAuxiliar);
					
					//Busco la persona que empieza con la inicial
					for(i = 0; i < 50; i++)
					{
						if(personas[i].nombre == "")
						{
							break;
						}
						
						if(personas[i].nombre[0] == inicialAuxiliar)
						{
							Console.WriteLine(personas[i].nombre);
						}
					}
				 
					break;
				 
			 }
			 
		 }while(opcion != 4);
		 
	 }
 }
