/*
2.2.1.2.2) Crea un programa que escriba en pantalla los números pares
del 26 al 10 (descendiendo), usando "while".
*/

using System;

public class Ejercicio_02_02_01_02_02
{
    public static void Main()
    {
        int numerosPares=26;

	while(numerosPares>=10)
	{
	    if(numerosPares % 2 == 0)
	    {
	        Console.WriteLine(numerosPares);
	    }

	    numerosPares-=1;
	}

    }
}