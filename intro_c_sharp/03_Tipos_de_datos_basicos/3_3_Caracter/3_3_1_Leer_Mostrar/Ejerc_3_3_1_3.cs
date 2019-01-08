/*
 * (3.3.1.3) Crea un programa que pida al usuario el ancho
 *  (por ejemplo, 4) y el alto (por ejemplo, 3) y una letra
 *  (por ejemplo, X) y escriba un rectángulo formado por esa cantidad
 *  de letras: 
 * XXXX 
 * XXXX 
 * XXXX
 */
 using System;
 
 public class Ejercicio_3_3_1_3
 {
	 public static void Main()
	 {
		 int ancho;
		 int largo;
		 char letra;
		 
		 int contadorAncho;
		 int contadorLargo;
		 
		 Console.Write("Escriba el ancho del rectangulo: ");
		 ancho = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Escriba el largo del rectangulo: ");
		 largo = Convert.ToInt32(Console.ReadLine());
		 
		 Console.Write("Escriba una letra: ");
		 letra = Convert.ToChar(Console.ReadLine());
		 
		 for(contadorLargo = 1; contadorLargo <= largo; contadorLargo++)
		 {
			 for(contadorAncho = 1; contadorAncho <= ancho; contadorAncho++)
			 {
				 Console.Write("{0}", letra);
			 }
			 
			 Console.WriteLine();
		 }
	 }
	 
 }
