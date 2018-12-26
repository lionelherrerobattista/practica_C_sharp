/*
(2.2.3.4) Crea un programa que muestre
la tabla de multiplicar del 9.
*/

using System;

public class Ejercicio_02_02_03_04
{
    public static void Main()
    {
	int numero;
	int resultado;

	for(numero=1; numero<=10; numero++)
	{
	    resultado = 9 * numero; 
	    Console.WriteLine("9 * {0} = {1}", numero, resultado);

	}

    }


}