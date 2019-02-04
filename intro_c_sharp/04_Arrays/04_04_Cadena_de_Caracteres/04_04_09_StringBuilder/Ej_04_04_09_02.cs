/*(4.4.9.2) Un programa que pida una cadena al usuario y la modifique,
 * de modo que las letras de las posiciones impares (primera, tercera,
 * etc.) estén en minúsculas y las de las posiciones pares estén
 * en mayúsculas, mostrando el resultado en pantalla. Por ejemplo,
 * a partir de un nombre como "Nacho", la cadena resultante
 * sería "nAcHo".
 */
 using System;
 using System.Text;
 
 public class Ejercicio_4_4_9_2
 {
	 public static void Main()
	 {
		 StringBuilder cadenaModificable;
		 string cadenaNormal;
		 int i;
		 
		 Console.WriteLine("Escriba un texto: ");
		 cadenaModificable = new StringBuilder(Console.ReadLine());
		 
		 //Paso a mayus o minus si según es par o impar
		 for(i = 0; i < cadenaModificable.Length; i++)
		 {
			 if(i % 2 == 0) //si es un indice par
			 {
				 //Conviero el carácter en Mayus
				 cadenaModificable[i] =
				  Char.ToUpper(cadenaModificable[i]);
			 }
			 else// si es impar en minus
			 {
				 cadenaModificable[i] =
				  Char.ToLower(cadenaModificable[i]);
			 }
		 }
		 
		 cadenaNormal = cadenaModificable.ToString();
		 
		 Console.WriteLine("Nueva cadena: {0}", cadenaNormal);
		 
	 }
	 
 }
 
