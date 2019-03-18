/* (5.9.1.3) Mejora el programa del ahorcado (4.4.9.3),
 * para que la palabra a adivinar no sea tecleada
 * por un segundo usuario, sino que se escoja al azar de un "array"
 * de palabras prefijadas (por ejemplo, nombres de ciudades).
 */
 using System;
 using System.Text;
 
 public class Ejercicio_5_9_1_3
 {
	 public static void Main()
	 {
		 StringBuilder cadenaModificable;
		 Random indice = new Random();
		 
		 string palabra; //la palabra a adivinar
		 string[] ciudades = {"Roma", "Paris", "Londres", "Montevideo",
			 "Berlin", "Moscu", "Madrid", "Tokio", "Helsinki", "Oslo"};//guardo 10 ciudades
		 char caracter; //el carácter que ingresa el usuario
		 string cadenaFinal;
		 int indiceAleatorio;
		 int i;
		 int intentos = 8;
		 bool error = true;
		 
		 //Creo un numero de indice aleatorio
		 indiceAleatorio = indice.Next(0, 11);
		 
		 palabra = ciudades[indiceAleatorio];
		 
		 //Asigno espacio en memoria para la cadena modificable
		 cadenaModificable = new StringBuilder(palabra);
		 
		 //Oculto la palabra
		 for(i = 0; i < cadenaModificable.Length; i++)
		 {
			 cadenaModificable[i] = '-';
		 }
		 
		 cadenaFinal = cadenaModificable.ToString(); 
		 
		 //Comienza el juego
		 do
		 {
			 Console.WriteLine();			 
			 Console.WriteLine("{0}", cadenaFinal);
			 
			 Console.WriteLine("Intentos: {0}", intentos);
			 
			 Console.Write("Ingresá la letra: ");
			 caracter = Convert.ToChar(Console.ReadLine());
			 
			 //Compruebo si está la misma letra
			 for(i = 0; i < cadenaModificable.Length; i++)
			 {
				 if(Char.ToLower(palabra[i]) == Char.ToLower(caracter))
				 {
					 cadenaModificable[i] = palabra[i];
					 error = false;
				 }
			 }
			 
			 cadenaFinal = cadenaModificable.ToString(); 
			 
			 //Compruebo si acertó la palabra
			 if(String.Compare(cadenaFinal, palabra) == 0)
			 {
				 Console.WriteLine();
				 Console.WriteLine("¡¡Ganaste!! =) Palabra: {0}", cadenaFinal);
				 break;
			 }
			 
			 if(error)
			 {
				intentos--; 
			 }
			 else
			 {
				 error = true;
			 }
			  	 
		 }while(intentos > 0);
		 
		 //Si utilizó todos los intentos
		 if(intentos == 0)
		 {
			 Console.WriteLine();
			 Console.WriteLine("Perdiste :(");
			 Console.WriteLine("La palabra era {0}", palabra);
		 }
		 
		 
	 }
 }
