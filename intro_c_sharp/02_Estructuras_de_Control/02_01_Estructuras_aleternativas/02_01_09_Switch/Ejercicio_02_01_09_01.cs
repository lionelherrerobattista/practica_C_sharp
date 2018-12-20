/*
Crea un programa que pida un número del 1 al 5 al usuario,
y escriba el nombre de ese número, usando "switch"
(por ejemplo, si introduce "1", el programa escribirá "uno").
*/

using System;

public class Ejercicio_02_01_09_01
{
    public static void Main()
    {
	int numeroUsuario;

	Console.Write("Escriba un numero del 1 al 5: ");
	numeroUsuario = Convert.ToInt32(Console.ReadLine());

	switch(numeroUsuario)
	{
	    case 1:
	        Console.WriteLine("Uno");
		break;
	    case 2:
	        Console.WriteLine("Dos");
		break;
	    case 3:
	        Console.WriteLine("Tres");
		break;
	    case 4:
	        Console.WriteLine("Cuatro");
		break;
	    case 5:
	        Console.WriteLine("Cinco");
		break;
	}

    }


}