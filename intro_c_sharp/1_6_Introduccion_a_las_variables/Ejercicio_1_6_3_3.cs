public class Ejercicio_1_6_3_3
{
	public static void Main()
	{
		int dividendo;
		int divisor;
		int resto;

		dividendo = 3784;
		divisor = 16;
		
		resto = dividendo % divisor;

		System.Console.WriteLine("El resto de dividir {0} entre {1} es {2}", dividendo, divisor, resto);
	}
}