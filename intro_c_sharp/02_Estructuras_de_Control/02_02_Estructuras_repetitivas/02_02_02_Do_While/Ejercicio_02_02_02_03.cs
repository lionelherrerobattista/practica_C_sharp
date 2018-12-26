/*
(2.2.2.3) Crea un programa que escriba en pantalla los números pares
 del 26 al 10 (descendiendo),
 usando "do..while".
*/

using System;

public class Ejercicio_02_02_02_03
{
    public static void Main()
    {
        int numerosPares=26;

	do
	{
	    if(numerosPares % 2 == 0)
	    {
	        Console.WriteLine(numerosPares);
	    }

	    numerosPares-=1;
	}while(numerosPares>=10);

    }
}