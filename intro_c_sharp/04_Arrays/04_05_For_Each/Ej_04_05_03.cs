/*(4.5.3) Un programa que pida al usuario varios números separados
 * por espacios y muestre su suma (como el del ejercicio 4.4.7.2),
 * pero empleando "foreach".
 */
 using System;
 
 public class Ejercicio_4_5_3
 {
	 public static void Main()
	 {
		 string numeroSuma;
		 string [] numeros;
		 char delimitador;
		 int resultado = 0;
		 
		 //Establezco el delimitador
		 delimitador = ' ';
		 
		 //Pido la cadena de números separados por un espacio
		 Console.WriteLine("Escriba numeros separados para sumarlos:");
		 numeroSuma = Console.ReadLine();
		 
		 //Divido a la cadena según el delimitador
		 numeros = numeroSuma.Split(delimitador);
		 
		 //Tomo cada numero y los sumo al total
		 foreach(string numero in numeros)
		 {
			 resultado += Convert.ToInt32(numero);			 
		 }
		 
		 //Imprimo el resultado en pantalla
		 Console.WriteLine("El resultado es {0}", resultado);
		 
	 }
 }
