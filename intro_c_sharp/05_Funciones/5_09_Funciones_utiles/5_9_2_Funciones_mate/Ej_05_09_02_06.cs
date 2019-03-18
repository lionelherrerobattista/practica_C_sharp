/*(5.9.2.6) Crea una función "Distancia", que calcule la distancia
 * entre dos puntos (x1,y1) y (x2,y2), usando la expresión
 * d = raíz [ (x1-x2)2 + (y1-y2)2 ].
 */
 using System;
 
 public class Ejercicio_5_9_2_6
 {
	 public static double Distancia( float x1, float y1, float x2, float y2)
	 {
		 double distancia;
		 
		 distancia = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));
		 
		 return distancia;		 
	 }
	 public static void Main()
	 {
		 double distancia;
		 float x1;		 
		 float x2;
		 float y1;
		 float y2;
		 
		 //Pido las coordenadas al usuario
		 Console.WriteLine("Escriba las coordenadas de los puntos" +
		  " para calcular la distancia entre ellos.");
		  
		 //Punto 1
		 Console.WriteLine("Punto 1:");
		 Console.Write("x1: ");
		 x1 = Convert.ToSingle(Console.ReadLine());
		 Console.Write("y1: ");
		 y1 = Convert.ToSingle(Console.ReadLine());
		 
		 //Punto 2
		 Console.WriteLine("Punto 2:");
		 Console.Write("x2: ");
		 x2 = Convert.ToSingle(Console.ReadLine());
		 Console.Write("y2: ");
		 y2 = Convert.ToSingle(Console.ReadLine());
		 
		 //Calculo la distancia
		 distancia = Distancia(x1, y1, x2, y2);
		 
		 //Muestro
		 Console.WriteLine();
		 Console.WriteLine("Distancia entre los puntos: {0}", distancia);
	 }
 }
