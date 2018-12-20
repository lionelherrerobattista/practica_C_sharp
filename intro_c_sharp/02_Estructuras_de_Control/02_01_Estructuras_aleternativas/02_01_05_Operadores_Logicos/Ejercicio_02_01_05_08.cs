/*
Crea un programa que pida al usuario dos números enteros
y diga "Uno de los números es positivo", "Los dos números son positivos"
o bien "Ninguno de los números es positivo", según corresponda.
*/
using System;

public class Ejercicio_02_01_05_08
{
    public static void Main()
    {
	    int numeroUno;
	    int numeroDos;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());


	    Console.Write("Escriba otro numero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());
	
	    if(numeroUno > 0 && numeroDos > 0)
	    {
	        Console.WriteLine("Los dos numeros son positivos.");	
	    }
	    else
	    {
		if(numeroUno > 0 || numeroDos > 0) //Alguno no es positivo
		{
		    Console.WriteLine("Uno de los numeros es positivo.");
		}
		else
		{
		    Console.WriteLine("Ninguno de los numeros es positivo.");
		}
	    }
    }

}