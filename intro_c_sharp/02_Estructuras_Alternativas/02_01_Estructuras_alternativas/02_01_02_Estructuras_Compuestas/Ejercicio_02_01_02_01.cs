/*
Crea un programa que pida al usuario un n�mero entero. Si es m�ltiplo de 10,
informar� al usuario y pedir� un segundo n�mero,
para decir a continuaci�n si este segundo n�mero tambi�n es m�ltiplo de 10.
*/

using System;

public class Ejercicio_02_01_02_01
{
    public static void Main() //Escritura indentada = 4 espacios
    {
        int numeroUno;
        int numeroDos;

        Console.Write("Ingrese un numero entero: ");
	numeroUno = Convert.ToInt32(Console.ReadLine());

	if(numeroUno % 10 == 0)
	{

	    Console.WriteLine("Es multiplo de 10.");
	    Console.Write("Ingrese otro numero entero: ");
	    numeroDos = Convert.ToInt32(Console.ReadLine());

	    if(numeroDos % 10 == 0)
	    {
	        Console.WriteLine("Es multiplo de 10.");
	    }			

	}

    }
			
}