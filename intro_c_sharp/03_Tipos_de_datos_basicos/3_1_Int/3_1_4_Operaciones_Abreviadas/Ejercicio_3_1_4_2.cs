/*
 * (3.1.4.2) ¿Cuál sería el resultado de las siguientes operaciones?
 *  a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;
 *  Crea un programa que te lo muestre.
 */
 using System;
 
 public class Ejercicio_3_1_4_2
 {
	 public static void Main()
	 {
		byte a;
		byte b; 
		sbyte c = 0;
		
		a = 5;
		
		b = Convert.ToByte( a + 2);
		
		Console.WriteLine("b = {0}", b);
		Console.WriteLine("----------------");
		
		b -= 3;
		
		Console.WriteLine("b = {0}", b);
		Console.WriteLine("----------------");
		
		c -= 3;
		
		Console.WriteLine("c = {0}", c);
		Console.WriteLine("----------------");
		
		c *= 2;
		
		Console.WriteLine("c = {0}", c);
		Console.WriteLine("----------------");
		
		++c;
		
		Console.WriteLine("c = {0}", c);
		Console.WriteLine("----------------");
		
		a *= b;
		
		Console.WriteLine("a = {0}", a);
		Console.WriteLine("----------------");		 
	 } 
	 
 }
