/*
Crea un programa que pida al usuario
 dos números enteros y diga si uno y sólo uno es par.
*/
using System;

public class Ejercicio_02_01_05_07
{
    public static void Main()
    {
	    int numeroUno;
	    int numeroDos;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());


	    Console.Write("Escriba otro numero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());
	
	    if(numeroUno % 2 == 0 && numeroDos % 2 != 0)
	    {
	        Console.WriteLine("El primer numero es par");	
	    }
	    else
	    {
		if(numeroUno % 2 != 0 && numeroDos % 2 == 0)
		{
		    Console.WriteLine("El segundo numero es par");
		}
	    }
    }

}