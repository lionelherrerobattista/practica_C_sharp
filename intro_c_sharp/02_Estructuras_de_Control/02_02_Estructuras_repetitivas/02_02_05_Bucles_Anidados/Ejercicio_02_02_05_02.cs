/*
(2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5,
en una misma línea, usando "while": 12345123451234512345.
*/

using System;

public class Ejercicio_02_02_05_02
{
    public static void Main()
    {
	int linea=1;
	int numero;


	do
	{

	    numero=1;

	    do
	    {
		Console.Write(numero);
		numero++;

	    }while(numero<=5);

	    linea++;	

	}while(linea<=4);
    }


}