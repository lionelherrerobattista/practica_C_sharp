/*
(2.2.11.2) Crea un programa que escriba los n�meros pares del 2 al 106,
excepto los que sean m�ltiplos de 10, usando "continue".
*/

using System;

public class Ejercicio_02_02_11_02
{
    public static void Main()
    {
	int numero;

	for(numero=2; numero <= 106; numero += 2) //Solo los numeros pares (+2)
	{
	    if(numero % 10 == 0)
	    {
		continue; //Paso a la siguiente iteraci�n
	    }

	    Console.Write("{0} ", numero);

	}
    }
}