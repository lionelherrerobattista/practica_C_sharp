/*
(2.2.5.3) Crea un programa que, para los números
entre el 10 y el 20 (ambos incluidos) diga si son divisibles entre 5,
si son divisibles entre 6 y si son divisibles entre 7.
*/

using System;

public class Ejercicio_02_02_05_03
{
    public static void Main()
    {
	int numero;

	for(numero=10; numero<=20; numero++)
	{
	    Console.Write("{0} es divisible por: ",numero);
	    
	    if(numero % 5 == 0)
	    {
		Console.Write("5, ");
	    }

	    if(numero % 6 == 0)
	    {
		Console.Write("6, ");
	    }

	    if(numero % 7 == 0)
	    {
		Console.Write("7. ");
	    }

	    Console.WriteLine();
	}

    }


}