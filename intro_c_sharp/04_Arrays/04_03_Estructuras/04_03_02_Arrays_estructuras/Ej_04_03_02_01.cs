/* (4.3.2.1) Amplia el programa del ejercicio 4.3.1.1,
 * para que almacene datos de hasta 100 canciones.
 * Deberá tener un menú que permita las opciones:
 * añadir una nueva canción, mostrar el título de todas las canciones,
 * buscar la canción que contenga un cierto texto (en el artista
 * o en el título).
 */
 using System;

 public class Ejercicio_4_3_1_1
 {
	 //Creo la estructura afuera del main
	 struct sCancion
	 {
		 //Los datos son "public", de acceso para todo el programa
		 public string artista;
		 public string titulo;
		 public int duracion; //segundos
		 public int tamFichero; //KB		  
	 }
	 
	 public static void Main()
	 {
		 //Creo un dato del tipo estructura
		 sCancion[] canciones = new sCancion[100];
		 byte opcion = 0;
		 int i;
		 int ocupado=0;//Va apuntar al próximo libre
		 string textoBusqueda;
		 bool encontroResultado = false;
		 
		 do
		 {
			 
			 
			 //Menú de opciones:
			 Console.WriteLine("-------------------------------------"+
			  "----");
			 Console.WriteLine("1-Agreagar nueva canción.");
			 Console.WriteLine("2-Mostrar el título de todas" +
			  " las canciones.");
			 Console.WriteLine("3-Buscar texto.");
			 Console.WriteLine("4-Salir");
			 Console.WriteLine("-------------------------------------" + 
			 "----");
			 Console.Write("Opción: ");
			 opcion = Convert.ToByte(Console.ReadLine());
			 Console.WriteLine("--------------------------------------"+
			 "---");
			 
			 switch(opcion)
			 {
				 case 1://Agregar nueva canción			 
					 Console.WriteLine("Ingrese los datos de la canción:");
					 //Ingreso los datos utilizando el operador "."
					 Console.Write("Artista: ");
					 canciones[ocupado].artista = Console.ReadLine();
					 
					 Console.Write("Título: ");
					 canciones[ocupado].titulo = Console.ReadLine();
					 
					 Console.Write("Duración (seg.): ");
					 canciones[ocupado].duracion =
					  Convert.ToInt32(Console.ReadLine());
					 
					 Console.Write("Tamaño (KB): ");
					 canciones[ocupado].tamFichero = 
					  Convert.ToInt32(Console.ReadLine());
					 //Sumo uno a ocupado
					 ocupado++;
					 break;
					 
			     case 2: //Mostrar el título de todas las canciones
					 Console.WriteLine("Títulos: ");
				     for(i = 0; i < ocupado; i++)
				     {
						 if(canciones[i].titulo != "")
						 {
							 Console.WriteLine("-{0}",
							  canciones[i].titulo);
						 }					 
						 
					 }
					 break;
					 
				 case 3: //Buscar texto en artista o titulo
				     Console.Write("Escriba el texto a buscar: ");
				     textoBusqueda = Console.ReadLine();
				     
				     for(i = 0; i < ocupado; i++)
				     {
						 //Uso el método String.Compare()
						 if(string.Compare(canciones[i].artista,
						  textoBusqueda) == 0 ||
						   string.Compare(canciones[i].titulo,
						    textoBusqueda) == 0)
						 {
							 Console.WriteLine("--------------------" +
							  "---------------------");
							 Console.WriteLine("Artista: {0}",
							  canciones[i].artista);
							 Console.WriteLine("Título: {0}",
							  canciones[i].titulo);
							 Console.WriteLine("Duración (seg.): {0}",
							  canciones[i].duracion);
							 Console.WriteLine("Tamaño (KB): {0}",
							  canciones[i].tamFichero);
							  
							  encontroResultado = true;
						 }
					 }
					 
					 if(encontroResultado == false)
					 {
						 Console.WriteLine("No se encontraron" +
						  "coincidencias");
					 }
					 break;

			  }
		  }while(opcion != 4);
		 		 
	 }
	
	
 }

