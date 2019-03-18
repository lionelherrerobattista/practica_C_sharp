/* (5.4.6) Crea una función "MostrarPerimSuperfCuadrado"
 * que reciba un número entero y calcule y muestre en pantalla
 * el valor del perímetro y de la superficie de un cuadrado
 * que tenga como lado el número que se ha indicado como parámetro.
 */
 using System;
 
 public class Ejercicio_5_4_6
 {
	 public static void MostrarPerimSuperfCuadrado(int lado)
	 {
		 int perimetro;
		 int superficie;
		 
		 perimetro = 4 * lado;
		 
		 superficie = lado * lado;
		 
		 Console.WriteLine("Perímetro: {0}", perimetro);
		 Console.WriteLine("Superficie: {0}", superficie);
	 }
	 
	 public static void Main()
	 {
		 int lado;
		 
		 Console.WriteLine("Escriba el valor del lado del cuadrado " +
		  "para calcular su perímetro y superficie:");
		 lado = Convert.ToInt32(Console.ReadLine());
		 
		 MostrarPerimSuperfCuadrado(lado);
	 }
 }
