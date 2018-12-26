/*
(2.2.2.2) Crea un programa que escriba en pantalla
los números del 1 al 10,
usando "do..while".
*/
using System;

public class Ejercicio_02_02_02_02
{
    public static void Main()
    {
	int numero=1;

	do
	{
	    Console.WriteLine(numero);
	    numero+=1;
	}while(numero<11);
    }



}