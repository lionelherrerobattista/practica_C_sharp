/*
(2.2.3.2) Crea un programa que escriba en pantalla los n�meros del 1 al 50
que sean m�ltiplos de 3 (pista: habr� que recorrer todos esos n�meros
y ver si el resto de la divisi�n entre 3 resulta 0).
*/

using System;

public class Ejercicio_02_02_03_02
{
    public static void Main()
    {
	int numero;

	for(numero=1; numero<=50; numero++)
	{
	    if(numero % 3 == 0)
	    {
	        Console.Write("{0}-", numero);
	    }

	}

    }


}