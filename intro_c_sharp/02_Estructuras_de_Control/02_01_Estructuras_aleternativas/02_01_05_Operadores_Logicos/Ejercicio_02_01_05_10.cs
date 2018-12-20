/*
Crea un programa 
que pida al usuario tres números
y muestre cuál es el mayor de los tres.
*/
using System;

public class Ejercicio_02_01_05_10
{
    public static void Main()
    {
	    int numeroUno;
	    int numeroDos;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());

	    Console.Write("Escriba otro numero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());
	
	    if(numeroUno == numeroDos)
	    {
	        Console.WriteLine("Ambos numeros son iguales");	
	    }
	    else
	    {
		if(numeroDos > numeroUno)
		{
		    Console.WriteLine("El segundo numero {0} es el mayor", numeroDos);
		}
		else
		{
		    if(numeroUno > numeroDos)
		    {
		    	Console.WriteLine("El primer numero {0} es el mayor", numeroUno);
		    }
		}
	    }
    }

}