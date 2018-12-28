/*
(2.2.11.1) Crea un programa que escriba los números del 20 al 10,
descendiendo, excepto el 13, usando "continue".
*/
using System;

public class Ejercicio_02_02_11_01
{
    public static void Main()
    {
	int numero;

	for(numero = 20; numero >= 10; numero--)
	{
	    if(numero == 13)
	    {
		continue; //Pasa a la siguiente iteración sin imprimir por consola
	    }

	    Console.Write("{0} ", numero);
	}
    }
}