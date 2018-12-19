public class Ejercicio_1_9_1
{
	public static void Main()
	{
		int primerNumero;
		int segundoNumero;
		int resultado;

		System.Console.WriteLine("Escriba un numero: ");
		primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
		System.Console.WriteLine("Escriba otro numero: ");
		segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());

		resultado = primerNumero * segundoNumero;

		System.Console.WriteLine("El producto entre {0} y {1} es {2}",
		 primerNumero, segundoNumero, resultado);
	}
}
