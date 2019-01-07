/*
 * 3.2.5.3) Calcula el perímetro, área y diagonal de un rectángulo,
 * a partir de su ancho y alto (perímetro = suma de los cuatro lados;
 *  área = base x altura; diagonal, usando el teorema de Pitágoras).
 *  Muestra todos ellos con una cifra decimal.
 */
 using System;
 
 public class Ejercicio_3_2_5_3
 {
	 public static void Main()
	 {
		 float alto;
		 float ancho;
		 float perimetro;
		 float area;
		 float diagonal;
		 
		 Console.Write("Escriba el alto: ");
		 alto = Convert.ToSingle(Console.ReadLine());
		 
		 Console.Write("Escriba el alto: ");
		 ancho = Convert.ToSingle(Console.ReadLine());
		 
		 perimetro = 2 * alto + 2 * ancho;
		 
		 area = ancho * alto;
		 
		 diagonal = (float) Math.Sqrt((ancho * ancho) + (alto * alto));
		 
		 Console.WriteLine("El perimetro del rectangulo es {0}",
		  perimetro.ToString("N1"));
		  
		 Console.WriteLine("El area del rectangulo es {0}",
		  area.ToString("N1"));
		  
		 Console.WriteLine("La diagonal del rectangulo es {0}",
		  diagonal.ToString("N1"));
		 
	 }
 }
