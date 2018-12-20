/*
Crea un programa 
que pida al usuario tres números
y muestre cuál es el mayor de los tres.
*/
using System;

public class Ejercicio_02_01_05_09
{
    public static void Main()
    {
	    int numeroUno;
	    int numeroDos;
	    int numeroTres;

	    Console.Write("Escriba un numero: ");
	    numeroUno = Convert.ToInt32(Console.ReadLine());

	    Console.Write("Escriba otro numero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());

    	    Console.Write("Escriba otro numero: ");
	    numeroTres = Convert.ToInt32(Console.ReadLine());  
	
	    if(numeroUno > numeroDos && numeroUno > numeroTres)
	    {
	        Console.WriteLine("El primer numero {0} es el mayor", numeroUno);	
	    }
	    else
	    {
		if(numeroDos > numeroUno && numeroDos > numeroTres) //Alguno no es positivo
		{
		    Console.WriteLine("El segundo numero {0} es el mayor", numeroDos);
		}
		else
		{
		    if(numeroTres > numeroUno && numeroTres > numeroDos)
		    {
		    	Console.WriteLine("El tercer numero {0} es el mayor", numeroTres);
		    }
		}
	    }
    }

}