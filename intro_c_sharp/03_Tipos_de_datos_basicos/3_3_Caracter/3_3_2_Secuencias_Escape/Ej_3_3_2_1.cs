/*
 * (3.3.2.1) Crea un programa que pida al usuario que teclee
 *  cuatro letras y las muestre en pantalla juntas,
 *  pero en orden inverso, y entre comillas dobles.
 *  Por ejemplo si las letras que se teclean son a, l, o, h,
 *  escribiría "hola".
 */
 using System;
 
 public class Ejercicio_3_3_2_1
 {
	 public static void Main()
	 {
		 char letraUno;
		 char letraDos;
		 char letraTres;
		 char letraCuatro;
		 
		 Console.WriteLine("Escriba 4 letras para mostrarlas"+
		 " en sentido inverso:");
		 
		 Console.Write("Escriba la primera letra: ");
		 letraUno = Convert.ToChar(Console.ReadLine());
		 
		 Console.Write("Escriba la segunda letra: ");
		 letraDos = Convert.ToChar(Console.ReadLine());
		 
		 Console.Write("Escriba la tercera letra: ");
		 letraTres = Convert.ToChar(Console.ReadLine());
		 
		 Console.Write("Escriba la cuarta letra: ");
		 letraCuatro = Convert.ToChar(Console.ReadLine());
		 
		 //Muestro las letras en el orden inverso
		 // uso '\' para poder escribir las comillas dobles
		 Console.WriteLine("\"{0}{1}{2}{3}\"",letraCuatro, letraTres,
		  letraDos, letraUno);
	 }
	 
 }
