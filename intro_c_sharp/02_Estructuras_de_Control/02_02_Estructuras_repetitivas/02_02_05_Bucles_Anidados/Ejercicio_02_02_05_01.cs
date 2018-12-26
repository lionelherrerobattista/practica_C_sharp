/*
(2.2.5.1) Crea un programa escriba 4 veces los números del 1 al 5,
en una misma línea, usando "for": 12345123451234512345.
*/

using System;

public class Ejercicio_02_02_05_01
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

	}


    }


}