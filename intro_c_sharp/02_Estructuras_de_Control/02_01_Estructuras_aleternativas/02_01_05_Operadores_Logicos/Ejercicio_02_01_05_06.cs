/*
Crea un programa que pida al usuario
 dos números enteros y diga si (al menos) uno es par.
*/
using System;

public class Ejercicio_02_01_05_06
{
    public static void Main()
    {
	    int numeroUno;
	    int numeroDos;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());


	    Console.Write("Escriba otro numero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());
	
	    if(numeroUno % 2 == 0 || numeroDos % 2 == 0)
	    {
	        Console.WriteLine("Al menos uno de los numeros es par");	
	    }
    }

}