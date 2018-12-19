//Crea un programa que pida al usuario dos números enteros
// y diga cuál es el mayor de ellos

using System;

public class Ejercicio_02_01_01_02
{
	public static void Main()
	{
		int numeroUno;
		int numeroDos;
		
		Console.WriteLine("Escriba dos numeros para saber cual es mayor.");
		Console.Write("Escriba el primer numero: ");
		numeroUno = Convert.ToInt32(Console.ReadLine());

		Console.Write("Escriba el segundo numero: ");
		numeroDos = Convert.ToInt32(Console.ReadLine());

		if(numeroUno > numeroDos)
		{
			Console.WriteLine("El primer numero, {0}, es mayor.", numeroUno);

		}
		else if (numeroDos > numeroUno)
		{

			Console.WriteLine("El segundo numero, {0}, es mayor.", numeroDos);

		}
	}
}