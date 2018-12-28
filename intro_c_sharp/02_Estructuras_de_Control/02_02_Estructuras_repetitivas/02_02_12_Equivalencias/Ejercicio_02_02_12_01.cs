/*
(2.2.12.1) Crea un programa que escriba los números del 100 al 200,
separados por un espacio, sin avanzar de línea, usando "for".
En la siguiente línea, vuelve a escribirlos usando "while".
*/
using System;

public class Ejercicio_02_02_12_01
{
    public static void Main()
    {
	int numero;
	
	Console.Write("Usando for: ");
	for(numero = 100; numero <= 200; numero++)
	{
	    Console.Write("{0} ", numero);

	}

	Console.WriteLine();
	Console.Write("Usando while: ");
	
	numero=100; //Tengo que volver el numero a 100 para que entre en el while
	while(numero <= 200)
	{
	    Console.Write("{0} ", numero);
	    numero++;
	}
    }
}