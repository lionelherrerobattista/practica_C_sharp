/*(4.3.1.1) Crea un "struct" que almacene datos de una canción
 * en formato MP3: Artista, Título, Duración (en segundos),
 * Tamaño del fichero (en KB). Un programa debe pedir los datos
 * de una canción al usuario, almacenarlos en dicho "struct"
 * y después mostrarlos en pantalla.
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
		 sCancion cancionUsuario;
		 
		 Console.WriteLine("Ingrese los datos de la canción:");
		 //Ingreso los datos utilizando el operador "."
		 Console.Write("Artista: ");
		 cancionUsuario.artista = Console.ReadLine();
		 
		 Console.Write("Título: ");
		 cancionUsuario.titulo = Console.ReadLine();
		 
		 Console.Write("Duración (seg.): ");
		 cancionUsuario.duracion = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Tamaño (KB): ");
		 cancionUsuario.tamFichero = Convert.ToInt32(Console.ReadLine());
		 
		 //Muestro los datos
		 Console.WriteLine("-----------------------------------------");
		 Console.WriteLine("Artista: {0}", cancionUsuario.artista);
		 Console.WriteLine("Título: {0}", cancionUsuario.titulo);
		 Console.WriteLine("Duración (seg.): {0}",
		  cancionUsuario.duracion);
		 Console.WriteLine("Tamaño (KB): {0}",
		  cancionUsuario.tamFichero);
		 		 
	 }
	
	
 }
