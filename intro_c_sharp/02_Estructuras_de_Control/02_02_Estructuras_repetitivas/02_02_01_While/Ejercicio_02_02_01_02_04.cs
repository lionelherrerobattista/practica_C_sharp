/*
(2.2.1.2.4) Crea el diagrama de flujo y la versión
 en C# de un programa que dé al usuario tres oportunidades
 para adivinar un número del 1 al 10.
*/

using System;

public class Ejercicio_02_02_01_02_04
{
    public static void Main()
    {
	int intentos = 3; //Cantidad de veces que el usuario puede intentar adivinar
	int numeroUsuario; //numero que escribe el usuario
	int numeroSecreto=5; //numero a adivinar

	while(intentos > 0)
	{
	    Console.WriteLine("Intentos: {0}", intentos);
	    Console.Write("Adivine el numero secreto (del 1 al 10): ");
	    numeroUsuario = Convert.ToInt32(Console.ReadLine());

	    if(numeroUsuario == numeroSecreto)
	    {
		Console.WriteLine("Felicitaciones, ha acertado.");
		break;
	    }
	    else
	    {
	        Console.WriteLine("No es el numero.");
	    }

	    intentos -= 1;

	}

    }



}