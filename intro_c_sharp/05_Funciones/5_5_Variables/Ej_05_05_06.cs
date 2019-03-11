/*(5.5.6) Crea una función "Triángulo" que reciba una letra y un número,
 * y escriba un "triángulo" formado por esa letra,
 * que tenga como anchura inicial la que se ha indicado.
 * Por ejemplo, si la letra es * y la anchura es 4,
 * debería escribir:
 *  ****
 *  ***
 *  **
 *  *
 */
 using System;
 
 public class Ejercicio_5_5_6
 {
	 public static void Triangulo(char letraUsuario, int anchura)
	 {
		 int i;
		 int cantidadLetras = 0;
		 
		 Console.WriteLine();
		 for(i = anchura; i > 0; i--)
		 {
			 for(cantidadLetras = 0; cantidadLetras < i; cantidadLetras++)
			 {
				Console.Write("{0}", letraUsuario);
		     }
		     
		     Console.WriteLine();
		 }
	 }
	 
	 public static void Main()
	 {
		 char letra;
		 int anchura;
		 
		 Console.Write("Indique la anchura: ");
		 anchura = Convert.ToInt32(Console.ReadLine());
		 Console.Write("Indique la letra: ");
		 letra = Convert.ToChar(Console.ReadLine());
		 
		 Triangulo(letra, anchura);
	 }
	 
 }

	 
	 
	 
	 

