/*------calcula el producto de dos números introducidos por el usuario (1.9.1),
empleando "using System"-----*/

using System; //No hace falta usar System en el resto del programa

public class Ejercicio_1_10_1
{
	public static void Main()
	{
		int primerNumero;
		int segundoNumero;
		int resultado;

		Console.WriteLine("Escriba un numero:");
		primerNumero = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Escribe otro numero:");
		segundoNumero = Convert.ToInt32(Console.ReadLine());

		resultado = primerNumero * segundoNumero;

		Console.WriteLine("El resultado del producto entre {0} y {1} es {2}",
		primerNumero, segundoNumero, resultado);
	}
}
		