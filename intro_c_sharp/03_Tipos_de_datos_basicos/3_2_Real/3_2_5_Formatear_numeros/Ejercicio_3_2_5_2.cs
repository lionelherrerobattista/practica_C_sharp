/*
 * (3.2.5.2) Crea un programa que use tres variables x,y,z.
 * Las tres serán números reales, y nos bastará
 *  con dos cifras decimales. Se deberá pedir al usuario los valores
 *  para las tres variables y mostrar en pantalla
 *  el valor de x^2 + y - z (con exactamente dos cifras decimales).
 */
 using System;
 
 public class Ejercicio_3_2_5_2
 {
	 public static void Main()
	 {
		 float x;
		 float y;
		 float z;
		 float resultado;
		 
		 
		 Console.Write("Escriba el valor de x: ");
		 x = Convert.ToSingle(Console.ReadLine());
		 
		 Console.Write("Escriba el valor de y: ");
		 y = Convert.ToSingle(Console.ReadLine());
		 
		 
		 Console.Write("Escriba el valor de z: ");
		 z = Convert.ToSingle(Console.ReadLine());
		 
		 resultado = (x*x) + y - z;
		 
		 Console.WriteLine("El resultado es {0}",
		  resultado.ToString("N2"));
	 }
	 
 }
