/*(4.4.9.3) Crea un juego del ahorcado, en el que un primer usuario
 * introduzca la palabra a adivinar, se muestre ésta oculta con guiones
 * (-----) y el programa acepte las letras que introduzca el segundo
 * usuario, cambiando los guiones por letras correctas cada vez que
 * acierte (por ejemplo, a---a-t-). La partida terminará
 * cuando se acierte la palabra por completo
 * o el usuario agote sus 8 intentos.
 */
 using System;
 using System.Text;
 
 public class Ejercicio_4_4_9_3
 {
	 public static void Main()
	 {
		 StringBuilder cadenaModificable;
		 string palabra; //la palabra a adivinar
		 char caracter; //el carácter que ingresa el usuario
		 string cadenaFinal;
		 int i;
		 int intentos = 8;
		 bool error = true;
		 
		 //Pido al usuario la palabra a adivinar
		 Console.Write("Escribí la palabra a adivinar: ");
		 //Cambio el color de la fuente para ocultar el texto
		 Console.ForegroundColor = ConsoleColor.Black;
		 palabra = Console.ReadLine();
		 //Vuelvo a cambiar l color de la fuente
		 Console.ForegroundColor = ConsoleColor.White;
		 
		 //Asigno espacio en memoria para la cadena modificable
		 cadenaModificable = new StringBuilder(palabra);
		 
		 //Oculto lo que ingresó el primer usuario
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
				 if(palabra[i] == caracter)
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
				 Console.WriteLine("¡¡Ganaste!! =)");
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
		 }
		 
		 
	 }
 }
