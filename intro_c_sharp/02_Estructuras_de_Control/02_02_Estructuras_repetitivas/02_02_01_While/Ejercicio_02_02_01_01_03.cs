/*
Crea un programa que pida de forma repetitiva pares de números al usuario.
Tras introducir cada par de números,
responderá si el primero es múltiplo del segundo.
*/

using System;

public class Ejercicio_02_02_01_01_03
{
    public static void Main()
    {
	int numeroUno;
	int numeroDos;

	Console.Write("Escriba un numero (0 para salir): ");
	numeroUno= Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba otro numero: ");
	numeroDos= Convert.ToInt32(Console.ReadLine());

	if(numeroUno % numeroDos == 0)
	{
	    Console.WriteLine("El primer numero es multiplo del segundo.");
	}

	while(numeroUno!=0)
	{
  	    Console.Write("Escriba un numero (0 para salir): ");
	    numeroUno= Convert.ToInt32(Console.ReadLine());

	    Console.Write("Escriba otro numero: ");
	    numeroDos= Convert.ToInt32(Console.ReadLine());

	    if(numeroUno % numeroDos == 0)
	    {
	    	Console.WriteLine("El primer numero es multiplo del segundo.");
	    }
	
	}
    }

}