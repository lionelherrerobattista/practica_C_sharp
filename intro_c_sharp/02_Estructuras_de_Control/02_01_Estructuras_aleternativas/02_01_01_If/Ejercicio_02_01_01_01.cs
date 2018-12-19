//Crea un programa que pida al usuario
// un número entero y diga si es par

using System;

public class Ejercicio_02_01_01_01
{
	public static void Main()
	{
		int numeroUsuario;
		
		Console.Write("Escriba un numero para saber si es par: ");
		numeroUsuario = Convert.ToInt32(Console.ReadLine()); //Paso de string a int

		if(numeroUsuario % 2 == 0) //Si es par, x%2 == 0
		{
			Console.WriteLine("Es par.");
		}
	}
}