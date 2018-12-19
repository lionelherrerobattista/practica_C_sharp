//------Suma tres números tecleados por usuario------
public class Ejercicio_1_9_3
{
	public static void Main()
	{
		int primerNumero;
		int segundoNumero;
		int tercerNumero;
		int resultado;

		System.Console.WriteLine("Escriba un numero:");
		primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
		
		System.Console.WriteLine("Escriba otro numero:");
		segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());

		System.Console.WriteLine("Escriba otro numero:");
		tercerNumero = System.Convert.ToInt32(System.Console.ReadLine());

		resultado = primerNumero + segundoNumero + tercerNumero;

		System.Console.WriteLine("El resultado de la suma entre {0}, {1} y {2} es {3}",
		primerNumero, segundoNumero, tercerNumero, resultado);
	}
}