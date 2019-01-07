/*
 * (3.2.6.2) Crea un programa que pida al usuario la cantidad de rojo
 *  (por ejemplo, 255), verde (por ejemplo, 160) y azul (por ejemplo, 0)
 *  que tiene un color, y que muestre ese color RGB
 *  en notación hexadecimal (por ejemplo, FFA000).
 */
 using System;
 
 public class Ejercicio_3_2_6_2
 {
	 public static void Main()
	 {
		int colorRojo; //byte de 0 a 255
		int colorVerde;
		int colorAzul;
		
		string azul;
		string verde;
		string rojo;
		
		Console.Write("Escriba la cantidad de rojo (0-255): ");
		colorRojo = Convert.ToInt32(Console.ReadLine()); 
		
		Console.Write("Escriba la cantidad de verde (0-255): ");
		colorVerde = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("Escriba la cantidad de azul (0-255): ");
		colorAzul = Convert.ToInt32(Console.ReadLine());
		
		//Para que me muestre los 0: X (mayuscula), x (minusucula)
		//https://stackoverflow.com/questions/15919979/convert-int-to-hex-with-leading-zeros
		rojo = colorRojo.ToString("X");
		verde = colorVerde.ToString("X");
		azul =  colorAzul.ToString("X");
		
		Console.WriteLine("El color en RGB es: {0}{1}{2}",
		 rojo, verde, azul);

	 }
 }
