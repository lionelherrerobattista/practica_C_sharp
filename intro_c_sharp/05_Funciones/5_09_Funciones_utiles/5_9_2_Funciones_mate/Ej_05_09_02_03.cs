/*(5.9.2.3) Haz un programa que resuelva ecuaciones de segundo grado,
 * del tipo ax2 + bx + c = 0. El usuario deberá introducir los valores
 * de a, b y c. Se deberá crear una función
 * "CalcularRaicesSegundoGrado", que recibirá como parámetros
 * los coeficientes a, b y c (por valor), así como las soluciones x1
 * y x2 (por referencia). Deberá devolver los valores
 * de las dos soluciones x1 y x2. Si alguna solución no existe,
 * se devolverá como valor 100.000 para esa solución.
 * Pista: la solución se calcula con x = -b  raíz (b2 – 4·a·c) / (2·a)
 */
 using System;

public class Ejercicio_5_9_2_3
{
	public static void CalcularRaciesSegundoGrado(int a, int b, int c, out double x1, out double x2)
	{
		x1 = ((-1 * b) - Math.Sqrt(Math.Pow(b, 2) - (4 * a * c) )) / (2*a);	//menos
		x2 = ((-1 * b) + Math.Sqrt(Math.Pow(b, 2) - (4 * a * c) )) / (2*a);//más
	}
	public static void Main()
	{
		int a;
		int b;
		int c;
		double x1 = 0;
		double x2 = 0;
		char respuesta;
		
		do
		{
			Console.WriteLine("Ingrese los valores de la ecuación" +
			 " de segundo grado: ");
			 
			Console.Write("a: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.Write("b: ");
			b = Convert.ToInt32(Console.ReadLine());
			Console.Write("c: ");
			c = Convert.ToInt32(Console.ReadLine());
			
			CalcularRaciesSegundoGrado(a, b, c, out x1, out x2);
			
			Console.WriteLine();
			Console.WriteLine("Los resultados son: ");
			
			if(!Double.IsNaN(x1))
			{
				Console.WriteLine("x1 = {0}", x1);			
			}
			else
			{
				Console.WriteLine("x1 no tiene solución en los reales.");
			}
			
			if(!Double.IsNaN(x2))
			{
				Console.WriteLine("x2 = {0}", x2);			
			}
			else
			{
				Console.WriteLine("x2 no tiene solución en los reales.");
			}
			
			Console.WriteLine();
			Console.WriteLine("¿Desea seguir calculando ecuaciones? (s/n)");
			Console.Write("Respuesta: ");
			respuesta = Convert.ToChar(Console.ReadLine());
			
			
		}while(respuesta == 's');
		
		Console.WriteLine();
		Console.WriteLine("FIN DEL PROGRAMA");
		
		
	}
}
