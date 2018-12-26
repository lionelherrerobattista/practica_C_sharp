/*
(2.2.3.1.3) Crea un programa que muestre los números
del 100 al 200 (ambos incluidos)
que sean divisibles entre 7 y a la vez entre 3.
*/

using System;

public class Ejercicio_02_02_03_03
{
    public static void Main()
    {
	int numero;

	for(numero=100; numero<=200; numero++)
	{
	    if((numero % 3 == 0) && (numero % 7 == 0))
	    {
	        Console.Write("{0}-", numero);
	    }

	}

    }


}