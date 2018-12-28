/*
Crea un programa que muestre
las letras de la Z (mayúscula) a la A (mayúscula, descendiendo).
*/
using System;

public class Ejercicio_02_02_07_01
{
    public static void Main()
    {
	char letra;

	for(letra='Z'; letra>='A'; letra--)
	{
	    Console.Write("{0}, ", letra);
	}
    }
}