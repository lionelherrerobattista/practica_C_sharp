/*
(2.2.12.2) Crea un programa que escriba los números pares del 20 al 10,
descendiendo, excepto el 14, primero con "for" y luego con "while".
*/
using System;

public class Ejercicio_02_02_12_02
{
    public static void Main()
    {
	int numero;

	for(numero = 20; numero >= 10; numero -= 2)
	{

	    if(numero == 14)
	    {
		continue; //Paso a la próxima iteración sin escribir
	    }

	    Console.Write("{0} ", numero);
	}

	Console.WriteLine();
	numero = 20;

	while(numero >= 10)
	{
	    if(numero == 14)
	    {
	        numero -= 2;//Si no resto uno primero siempre queda en 14
		continue;
	    }
	    Console.Write("{0} ", numero);
	    numero -= 2;

	}

    }



}