/* (4.1.4.5) Crea un programa que prepare espacio para un máximo
 * de 10 nombres.
 * Deberá mostrar al usuario un menú que le permita realizar
 * las siguientes operaciones:
 * 
 * - Añadir un dato al final de los ya existentes.
 * 
 * - Insertar un dato en una cierta posición (como ya se ha comentado,
 * 	los que quedén detrás deberán desplazarse "a la derecha"
 * 	para dejarle hueco; por ejemplo, si el array contiene "hola",
 * 	"adios" y se pide insertar "bien" en la segunda posición,
 * 	el array pasará a contener "hola", "bien", "adios".
 * 
 * - Borrar el dato que hay en una cierta posición
 * 	(como se ha visto, lo que estaban detrás deberán desplazarse
 * 	"a la izquierda" para que no haya huecos; por ejemplo,
 *  si el array contiene "hola", "bien", "adios"
 *  y se pide borrar el dato de la segunda posición,
 *  el array pasará a contener "hola", "adios"
 * 
 * - Mostrar los datos que contiene el array.
 * 
 * - Salir del programa.
 */
 using System;
 
 public class Ejercicio_4_1_4_5
 {
	 public static void Main()
	 {
		 string[] nombres = new string[10];
		 byte opcion;
		 byte posicion;
		 byte capacidad=10;
		 byte cantidad=0;
		 byte i;
		 string datoUsuario;
		 
		 do
		 {
			 Console.WriteLine("-------------------------------");
			 Console.WriteLine("1.Añadir nombre al final.");
			 Console.WriteLine("2.Insertar nombre en posición.");
			 Console.WriteLine("3.Borrar nombre.");
			 Console.WriteLine("4.Mostrar nombres.");
			 Console.WriteLine("5.Salir.");
			 Console.WriteLine("-------------------------------");
			 Console.Write("Opción: ");
			 opcion = Convert.ToByte(Console.ReadLine());
			 Console.WriteLine("-------------------------------");
			 
			 switch(opcion)
			 {
				 case 1:
				    if(cantidad < capacidad)
				    {
						 Console.Write("Ingrese el nombre que desea agregar: ");
						 datoUsuario = Console.ReadLine();
						 
						 //Agrego el nombre al array
						 //cantidad siempre me da la posición siguiente libre
						 nombres[cantidad] = datoUsuario;
						 
						 cantidad++;
						 
						 Console.WriteLine("-------------------------------");
						 Console.WriteLine("Nombre agregado.");
					}
					break;
				case 2:
					if(cantidad < capacidad)
				     {
						 Console.Write("Ingrese el nombre que desea agreagar: ");
						 datoUsuario = Console.ReadLine();

						 Console.Write("Ingrese la posición: ");
						 posicion = Convert.ToByte(Console.ReadLine());
						 
						 //Empizo desde atras y corro el dato a la derecha
						 for(i = cantidad; i > posicion-1; i--)
						 {
							 //Duplico los datos
							 //Cantidad apunta a la posición libre
							nombres[i] = nombres[i-1];
						 }	
						 
						 //Agrego el nombre al array
						 //posición es = indice + 1 entonces le resto 1
						 nombres[posicion-1] = datoUsuario;					 

						 cantidad++;
						 
						 Console.WriteLine("-------------------------------");
						 Console.WriteLine("Nombre agregado.");
					 }
				    break;
				case 3:
				    Console.Write("Ingrese la posición del nombre que desea borrar: ");
					posicion = Convert.ToByte(Console.ReadLine());
					
					for(i = posicion; i < cantidad; i++)
					{
						//Piso los datos
						//i apunta a la posición del dato siguiente
						nombres[i-1] = nombres[i];
					}
					cantidad--;
					Console.WriteLine("-------------------------------");
				    Console.WriteLine("Nombre borrado.");					
				    break;
				
				case 4:
				    for(i = 0; i < cantidad; i++)
				    {
						Console.WriteLine("{0}: {1}", i+1, nombres[i]);
					}
					break;
				 
				 
				 
				 
			 }
			 
		 }while(opcion != 5);
		 
	 }
 }
