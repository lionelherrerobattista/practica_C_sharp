/*
(2.2.6.1) Crea un programa que escriba 4 líneas de texto,
cada una de las cuales estará formada por los números del 1 al 5.
*/

using System;

public class Ejercicio_02_02_06_01
{
    public static void Main()
    {
	int linea;
	int numero;

	for(linea=1; linea<=4; linea++)
	{
	    for(numero=1; numero<=5; numero++)
	    {
		Console.Write(numero);
	    }

	    Console.WriteLine();

	}

    }



}