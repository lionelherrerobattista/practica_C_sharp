/*
 * (3.2.3.3) Halla las soluciones de una ecuación de segundo grado
 *  del tipo y = Ax2 + Bx + C.
 *  Pista: la raíz cuadrada de un número x
 *  se calcula con Math.Sqrt(x)
 */
 
using System;

public class Ejercicio_3_2_3_3
{
	public static void Main()
	{
		double ySuma; // -b + raiz
		double yResta; // -b - raiz
		double a;
		double b;
		double c;
		
		Console.WriteLine("Ingrese los datos para resolver" +
		 " una ecuación del tipo y = Ax2 + Bx + C");
		Console.WriteLine("-------------------------------------------");
		
		Console.Write("Ingrese A: ");
		a = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("Ingrese B: ");
		b = Convert.ToSingle(Console.ReadLine());
		
		Console.Write("Ingrese C: ");
		c = Convert.ToSingle(Console.ReadLine());
		
		//Utilizo la formula cuadrática
		ySuma = ((-b) + Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
		yResta = ((-b) - Math.Sqrt((b * b) - (4 * a * c))) / (2 * a);
		
		Console.WriteLine("El resultado es {0} y {1}", ySuma, yResta);
		
		
	}
	
}
