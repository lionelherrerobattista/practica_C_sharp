/*(4.6.9) Ampliar la base de datos de ficheros (ejemplo 04_06a)
 * para que se permita ordenar los datos por nombre. Para ello,
 * deberás buscar información sobre algún método de ordenación sencillo,
 * como el "método de burbuja" (en el siguiente apartado
 * tienes algunos), y aplicarlo a este caso concreto.
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
		tipoFicha auxiliarFicha;//para ordenar
		int numeroFichas=0; // Número de fichas que ya tenemos
		int i;// Para bucles
		int j;
		int opcion; // La opcion del menu que elija el usuario
		int opcionSubMenu;
		string textoBuscar = ""; // Para cuando preguntemos al usuario
		
		
		//auxiliares
		string textoAuxiliar;
		string tamanyoAuxiliar;
		int indiceModificar;
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
			 Console.WriteLine("6.- Borrar dato");
			 Console.WriteLine("7.- Modificar dato");
			 Console.WriteLine("8.- Ordenar ficheros por nombre");
			 Console.WriteLine("9.- Salir");
			 
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
					respuesta = Convert.ToChar(Console.ReadLine().ToLower());
					
				}while(respuesta == 's');
				
				//Vuelvo a dejar el texto vacío
				textoBuscar = "";
				break;
				
				case 6://Borrar dato
					if(numeroFichas > 0)
					{
						//Muestro todos los ficheros
						for (i=0; i<numeroFichas; i++)
						{
							Console.WriteLine("{0}- Nombre: {1}; Tamaño: {2} KB", i+1,
							fichas[i].nombreFich, fichas[i].tamanyo);
						}
						//Pido el numero de indice a borrar
						do
						{
							Console.WriteLine("Ingrese el numero de dato que desea borrar:");
							indiceModificar = Convert.ToInt32(Console.ReadLine())-1;
							
							if(indiceModificar > numeroFichas || indiceModificar < 0)
							{
								Console.WriteLine("Error. El número de dato no es válido.");
							}
							
						}while(indiceModificar > numeroFichas || indiceModificar < 0);
						
						//Pido confirmación
						Console.WriteLine("¿Está seguro que desea borrar la ficha? (s/n)");
						respuesta = Convert.ToChar(Console.ReadLine().ToLower());
						
						if(respuesta == 's')
						{
							//Muevo todas las fichas para atrás
							for(i = indiceModificar; i < numeroFichas-1; i++)
							{
								fichas[i] = fichas[i+1];		
							}
							
							numeroFichas--;	
							
							Console.WriteLine("Se borró la ficha.");
						}
					}
					else
					{
						Console.WriteLine("No se ingresó ninguna ficha.");						
					}
					break;
				case 7:
					if(numeroFichas > 0)
					{
						//Muestro todos los ficheros
						for (i=0; i<numeroFichas; i++)
						{
							Console.WriteLine("{0}- Nombre: {1}; Tamaño: {2} KB", i+1,
							fichas[i].nombreFich, fichas[i].tamanyo);
						}
						//Pido el numero de indice a modificar
						do
						{
							Console.WriteLine("Ingrese el numero de dato que desea modificar:");
							indiceModificar = Convert.ToInt32(Console.ReadLine())-1;
							
							if(indiceModificar > numeroFichas || indiceModificar < 0)
							{
								Console.WriteLine("Error. El número de dato no es válido.");
							}
							
						}while(indiceModificar > numeroFichas || indiceModificar < 0);
						
						//Pido confirmación
						Console.WriteLine("¿Está seguro que desea modificar la ficha? (s/n)");
						respuesta = Convert.ToChar(Console.ReadLine().ToLower());
						
						if(respuesta == 's')
						{
							//Sub menú para modificar datos individualmente
							do
							{
								Console.WriteLine("1-Modificar nombre.");
								Console.WriteLine("2-Modificar numero.");
								Console.WriteLine("3-Salir.");
								Console.Write("Opción: ");
								opcionSubMenu = Convert.ToInt32(Console.ReadLine());
								
								switch(opcionSubMenu)
								{
									case 1://Modificar nombre
										Console.WriteLine("Introduce el nombre del fichero: ");
										textoAuxiliar = Console.ReadLine();
										if(textoAuxiliar == "")
										{
												break;
										}
										fichas[indiceModificar].nombreFich = textoAuxiliar;
										Console.WriteLine("Se modificó la ficha.");
										break;
									case 2://Modificar tamaño
									
										//Valido que el tamaño no sea negativo:
										do
										{
											Console.WriteLine("Introduce el tamaño en KB: ");
											tamanyoAuxiliar = Console.ReadLine();
											
											if(tamanyoAuxiliar == "")
											{
												break;
											}
											
											fichas[indiceModificar].tamanyo = Convert.ToInt32(tamanyoAuxiliar);
											
											if(fichas[indiceModificar].tamanyo < 0)
											{
												Console.WriteLine("Error. Tamaño invalido.");
											}
											
										}while(fichas[indiceModificar].tamanyo < 0);
										Console.WriteLine("Se modificó la ficha.");
										break;
								}
									
							}while(opcionSubMenu != 3);
						}
					}
					else
					{
						Console.WriteLine("No se ingresó ninguna ficha.");						
					}
					break;
				case 8: //Ordeno por nombre
					for(i = 0; i < numeroFichas-1; i++)//ficha a la izquierda, termino una antes
					{
						for(j = 1; j < numeroFichas; j++)//fichas a la derecha
						{
							//comparo
							if(string.Compare(fichas[i].nombreFich, fichas[j].nombreFich)>0) //si la izquierda es mayor
							{
								//ordeno
								auxiliarFicha = fichas[i];
								fichas[i] = fichas[j];
								fichas[j] = auxiliarFicha;																								
							}
						}
					}
					Console.WriteLine("Fichas ordenadas.");
					break;
				case 9: // Salir: avisamos de que salimos */
				Console.WriteLine("Fin del programa");
				break;
				
				default: // Otra opcion: no válida
				Console.WriteLine("Opción desconocida!");
				break;
			}
		} while (opcion != 9); // Si la opcion es 5, terminamos
	}
}
