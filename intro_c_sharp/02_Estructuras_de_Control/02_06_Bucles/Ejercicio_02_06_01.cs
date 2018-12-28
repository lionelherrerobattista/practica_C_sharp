/*
(2.6.1) Crear un programa que dé al usuario la oportunidad de adivinar
un número del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos.
En cada pasada deberá avisar de si se ha pasado o se ha quedado corto.
*/
using System;

public class Ejercicio_02_06_01
{
    public static void Main()
    {
	int numeroUsuario;
	int numeroSecreto = 35; //Numero a adivinar
	int intentos = 6;

	do
	{
   	    Console.Write("Adivine el numero (del 1 al 100): ");
	    numeroUsuario = Convert.ToInt32(Console.ReadLine());

	    if(numeroUsuario == numeroSecreto) //Ganó
	    {
		Console.WriteLine();
  	        Console.WriteLine("*******************************");
	        Console.Write("Ha ganado!");
	        break; //Salgo del do...while
	    }
	    else
	    {
	        if(numeroUsuario < numeroSecreto)
	        {
		    Console.WriteLine("Se ha quedado corto.");
	        }
	        else
	        {
		    Console.WriteLine("Se ha pasado.");
	        }
	    }

    	    intentos--; //No acertó, resto un intento	
            Console.WriteLine("Intentelo nuevamente. Intentos: {0}", intentos);
  	    Console.WriteLine("*******************************");


	}while(intentos > 0); //Cuando se queda sin intentos termina el juego

	if(intentos == 0) //Si se quedó sin intentos
	{
	    Console.WriteLine();
	    Console.WriteLine("**************");	 
  	    Console.WriteLine("Ha perdido :(");
	    Console.WriteLine("**************");
	}
	else
	{
	    Console.WriteLine(" Felicitaciones :)");
  	    Console.WriteLine("*******************************");
	}


    }
}