/*(5.10.6) Crea un programa que emplee recursividad
 * para dar la vuelta a una cadena de caracteres
 * (por ejemplo, a partir de "Hola" devolvería "aloH").
 * La función recursiva se llamará "Invertir(cadena)".
 * Como siempre, analiza cuál será el caso base
 * (qué longitud debería tener una cadena para que sea trivial
 *  darle la vuelta) y cómo pasar del caso "n-1" al caso "n"
 * (por ejemplo, si ya has invertido las 5 primeras letras,
 * que ocurriría con la de la sexta posición).
 */
 using System;
 
 public class Ejercicio_5_10_6
 {
	 public static string Invertir(string cadena)
	 {

		 if(cadena.Length > 0)
		 {
			 return cadena;
		 }
		 else
		 {
			 return cadena[cadena.Length - 1] + Invertir(cadena.Substring(0, cadena.Length - 1));	 
		 }
	 }
	 public static void Main()
	 {
		 string cadena = "Hola";
		 
		 Console.WriteLine(Invertir(cadena));		 
	 }
 }
