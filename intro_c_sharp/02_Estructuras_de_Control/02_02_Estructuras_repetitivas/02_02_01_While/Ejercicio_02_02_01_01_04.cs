/*
Crea una versi�n mejorada del programa anterior, que,
tras introducir cada par de n�meros,
responder� si el primero es m�ltiplo del segundo,
o el segundo es m�ltiplo del primero, o ninguno de ellos es m�ltiplo del otro.
*/

using System;

public class Ejercicio_02_02_01_01_04
{
    public static void Main()
    {
	int numeroUno;
	int numeroDos;

	Console.Write("Escriba un numero (0 para salir): ");
	numeroUno= Convert.ToInt32(Console.ReadLine());

	Console.Write("Escriba otro numero: ");
	numeroDos= Convert.ToInt32(Console.ReadLine());

	if(numeroUno % numeroDos == 0)
	{
	    Console.WriteLine("El primer numero, {0}, es multiplo del segundo, {1}.", numeroUno, numeroDos);
	}
	else
	{
	    if(numeroDos % numeroUno == 0)
	    {
		Console.WriteLine("El segundo numero, {0}, es multiplo del primero, {1}.", numeroDos, numeroUno);
	    }
	    else
	    {
		Console.WriteLine("Ninguno de ellos es multiplo del otro.");
	    }
	}

	while(numeroUno!=0)
	{
  	    Console.Write("Escriba un numero (0 para salir): ");
	    numeroUno= Convert.ToInt32(Console.ReadLine());

	    Console.Write("Escriba otro numero: ");
	    numeroDos= Convert.ToInt32(Console.ReadLine());

	    if(numeroUno % numeroDos == 0)
	    {
	        Console.WriteLine("El primer numero, {0}, es multiplo del segundo, {1}.", numeroUno, numeroDos);
	    }
	    else
	    {
	        if(numeroDos % numeroUno == 0)
	        {
		    Console.WriteLine("El segundo numero, {0} es multiplo del primero, {1}", numeroDos, numeroUno);
	        }
	        else
	        {
		    Console.WriteLine("Ninguno de ellos es multiplo del otro.");
	        }
	    }	
	}
    }

}