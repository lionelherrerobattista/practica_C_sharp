/*
 * 
 * (3.1.3.2) ¿Cuál sería el resultado de las siguientes operaciones?
 *  a=5; b=++a; c=a++; b=b*5; a=a*2;
 *  Calcúlalo a mano y luego crea un programa que lo resuelva,
 *  para ver si habías hallado la solución correcta.
 */
 using System;
 
 public class Ejercicio_3_1_3_2
 {
	 public static void Main()
	 {
		 byte a = 5;
		 byte b = ++a; //preincremento
		 byte c = a++; //postincremento
		 
		 Console.WriteLine("a= {0}", a);
		 Console.WriteLine("b= {0}", b);
		 Console.WriteLine("c= {0}", c);
		 
		 //Tengo que convertir al multiplicar
		 //Si multiplico ambos byte el resultado queda en int
		 b = Convert.ToByte(b*5); 
		 a = Convert.ToByte(a*2);
		 
		 Console.WriteLine("------------");
		 Console.WriteLine("b= {0}", b);
		 Console.WriteLine("a= {0}", a);
		  
	 }
	 	 	 
 }
