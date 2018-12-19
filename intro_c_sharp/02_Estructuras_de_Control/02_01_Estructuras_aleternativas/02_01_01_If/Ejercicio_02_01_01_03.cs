//Crea un programa que pida al usuario dos números enteros
// y diga si el primero es múltiplo del segundo

using System;

public class Ejercicio_02_01_01_03
{
	public static void Main()
	{
		int numeroUno;
		int numeroDos;
		
		Console.WriteLine("Escriba dos numeros para saber si el primero es multiplo del segundo");
		Console.Write("Primer numero: ");
		numeroUno = Convert.ToInt32(Console.ReadLine());

		Console.Write("Segundo numero: ");
		numeroDos = Convert.ToInt32(Console.ReadLine());
		
		if(numeroUno % numeroDos == 0)
		{
			Console.WriteLine("{0} es multiplo de {1}", numeroUno, numeroDos);
		}
		
	}



}