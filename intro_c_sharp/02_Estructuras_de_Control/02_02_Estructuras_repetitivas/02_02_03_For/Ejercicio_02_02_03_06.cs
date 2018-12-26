/*
(2.2.3.6) Crea un programa que muestre los números del 15 al 5,
 descendiendo (pista: en cada pasada habrá que descontar 1,
 por ejemplo haciendo i=i-1, que se puede abreviar i--).
*/

using System;

public class Ejercicio_02_02_03_06
{
    public static void Main()
    {
	int numero;

	for(numero=15; numero>=5; numero--)
	{
	    Console.Write("{0}, ", numero);
	}
    }

}