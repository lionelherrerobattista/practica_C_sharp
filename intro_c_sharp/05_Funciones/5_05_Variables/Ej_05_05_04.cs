/*(5.5.4) Crea una función "ContarLetra", que reciba una cadena
 * y una letra, y devuelva la cantidad de veces que dicha letra
 * aparece en la cadena. Por ejemplo, si la cadena es "Barcelona"
 * y la letra es 'a', debería devolver 2
 * (porque la "a" aparece 2 veces).
 */
 using System;
 
 public class Ejercicio_5_5_4
 {
	 //Función que cuenta la cantidad de veces que se repite una letra
	 //determinada en una palabra
	 public static int ContarLetra(string palabra, char letraUsuario)
	 {
		 int contadorLetra = 0;//contador de repeticiones
		 
		 
		 foreach(char letra in palabra)
		 {
			 //Comparo cada letra (Paso las dos a minúsculas)
			 if(Char.ToLower(letra) == Char.ToLower(letraUsuario))
			 {
				 contadorLetra++;			 
			 }
		 }
		 
		 return contadorLetra;
	 }
	 
	 public static void Main()
	 {
		 char letraUsuario;
		 string palabraUsuario;
		 int cantidadRepeticiones;
		 
		 //Pido la palabra y la letra
		 Console.WriteLine("Ingrese una palabra y una letra para saber"
		  + " cuántas veces aparece en la palabra.");
		  
		 Console.Write("Ingrese la palabra: ");
		 palabraUsuario = Console.ReadLine();
		 
		 Console.Write("Ingrese la letra: ");
		 letraUsuario = Convert.ToChar(Console.ReadLine());
		 
		 //Cuento:
		 cantidadRepeticiones = ContarLetra(palabraUsuario, letraUsuario);
		 
		 //Muestro el resultado:
		 Console.WriteLine("La letra \"{0}\" aparece {1} veces en \"{2}\"",
		  letraUsuario, cantidadRepeticiones, palabraUsuario);
		 
	 }
 }
