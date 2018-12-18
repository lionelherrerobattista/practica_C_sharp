/*
Crea un programa que calcule la división de dos números introducidos por el usuario,
 así como el resto de esa división
*/
public class Ejercicio_1_9_2
{
	public static void Main()
	{
		int dividendo;
		int divisor;
		int resultado;
		int resto;

		System.Console.WriteLine("Escriba el dividendo:");
		dividendo = System.Convert.ToInt32(System.Console.ReadLine());
		
		System.Console.WriteLine("Escriba el divisor:");
		divisor = System.Convert.ToInt32(System.Console.ReadLine());
		
		resultado = dividendo / divisor;
		resto = dividendo % divisor;

		System.Console.WriteLine("El resultado de la division entre {0} y {1} es {2} y el resto {3}",
		dividendo, divisor, resultado, resto);
	}
}		