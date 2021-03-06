/*(4.6.6) Ampliar el ejercicio anterior (4.6.5) para que la búsqueda
 * sea incremental: el usuario irá indicando letra a letra el texto
 * que quiere buscar, y se mostrará todos los datos que lo contienen
 * (por ejemplo, primero los que contienen "j", luego "ju",
 * después "jua" y finalmente "juan").
 */
using System;

public class Ejemplo_04_06a
{

	struct tipoFicha
	{ 
		public string nombreFich; // Nombre del fichero
		public long tamanyo;// El tamaño en KB
	};
	
	public static void Main()
	{ 
		tipoFicha[] fichas // Los datos en si
		 = new tipoFicha[1000];
		int numeroFichas=0; // Número de fichas que ya tenemos
		int i;// Para bucles
		int opcion; // La opcion del menu que elija el usuario
		string textoBuscar = ""; // Para cuando preguntemos al usuario
		string textoAuxiliar;
		//int largoCadena;
		char respuesta;
		bool primeraIteracion = true;
		long tamanyoBuscar; // Para buscar por tamaño

		do
		{
			 // Menu principal, repetitivo
			 Console.WriteLine();
			 Console.WriteLine("Escoja una opción:");
			 Console.WriteLine("1.- Añadir datos de un nuevo fichero");
			 Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
			 Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
			 Console.WriteLine("4.- Ver datos de un fichero");
			 Console.WriteLine("5.- Busqueda parcial");
			 Console.WriteLine("6.- Salir");
			 
			opcion = Convert.ToInt32( Console.ReadLine() );
			
			// Hacemos una cosa u otra según la opción escogida
			switch(opcion)
			{
				case 1: // Añadir un dato nuevo
				if (numeroFichas < 1000)
				{ // Si queda hueco

					//Valido que el nombre no esté vacío:
					do
					{
						Console.WriteLine("Introduce el nombre del fichero: ");
						fichas[numeroFichas].nombreFich = Console.ReadLine();
						if(fichas[numeroFichas].nombreFich == "")
						{
							Console.WriteLine("Error. Nombre vacío");
						}
					}while(fichas[numeroFichas].nombreFich == "");

					//Valido que el tamaño no sea negativo:
					do
					{
						Console.WriteLine("Introduce el tamaño en KB: ");
						fichas[numeroFichas].tamanyo = Convert.ToInt32( Console.ReadLine() );
						if(fichas[numeroFichas].tamanyo < 0)
						{
							Console.WriteLine("Error. Tamaño invalido.");
						}
					}while(fichas[numeroFichas].tamanyo < 0);
					
					// Y ya tenemos una ficha más
					numeroFichas++;
				} else // Si no hay hueco para más fichas, avisamos
				Console.WriteLine("Máximo de fichas alcanzado (1000)!");
				break;
				
				case 2: // Mostrar todos
				for (i=0; i<numeroFichas; i++)
				 Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
				  fichas[i].nombreFich, fichas[i].tamanyo);
				break;
				
				case 3: // Mostrar según el tamaño			
				//Valido:
				do
				{
					Console.WriteLine("¿A partir de que tamaño quieres ver?");
					tamanyoBuscar = Convert.ToInt64( Console.ReadLine() );
					
					if(tamanyoBuscar < 0)
					{
							Console.WriteLine("Error. Tamaño invalido.");
					}
					
				}while(tamanyoBuscar < 0);
				
				for (i=0; i<numeroFichas; i++)
				 if (fichas[i].tamanyo >= tamanyoBuscar)
				  Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
					fichas[i].nombreFich, fichas[i].tamanyo);
				 break;
				 
				case 4: // Ver todos los datos (pocos) de un fichero
				//Valido
				do
				{
					Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
					textoBuscar = Console.ReadLine();
					if(textoBuscar == "")
					{
							Console.WriteLine("Error. Nombre vacío");
					}
				}while(textoBuscar == "");
				
				
				for (i=0; i<numeroFichas; i++)
				 if ( fichas[i].nombreFich == textoBuscar )
				  Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
				   fichas[i].nombreFich, fichas[i].tamanyo);
				break;
				
				case 5://Busqueda parcial
				//Validación:
				do
				{
					Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
					Console.Write("Ingrese una letra: ");
					
					textoAuxiliar = Console.ReadLine().ToLower();
					
					if(primeraIteracion == true)
					{
						textoBuscar = textoAuxiliar;
						primeraIteracion = false;
					}
					else
					{
						//Inserto las letras al final con cada iteración
						textoBuscar = textoBuscar.Insert(textoBuscar.Length, textoAuxiliar);
					}
					
					// Muestro los resultados:
					Console.WriteLine();
					Console.WriteLine("Resultados para \"{0}\":",textoBuscar);
					//Busco
					for (i=0; i<numeroFichas; i++)
					{
						//Paso todo a minúscula
						if ( fichas[i].nombreFich.ToLower().Contains(textoBuscar) )//Si está devuelve true
						{
							Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
							fichas[i].nombreFich, fichas[i].tamanyo);
						}
					}
					
					Console.WriteLine("¿Desea seguir buscando? (s/n)");
					respuesta = Convert.ToChar(Console.ReadLine());
					
				}while(respuesta == 's');
				
				//Vuelvo a dejar el texto vacío
				textoBuscar = "";
				break;
				
				case 6: // Salir: avisamos de que salimos */
				Console.WriteLine("Fin del programa");
				break;
				
				default: // Otra opcion: no válida
				Console.WriteLine("Opción desconocida!");
				break;
			}
		} while (opcion != 6); // Si la opcion es 5, terminamos
	}
}



