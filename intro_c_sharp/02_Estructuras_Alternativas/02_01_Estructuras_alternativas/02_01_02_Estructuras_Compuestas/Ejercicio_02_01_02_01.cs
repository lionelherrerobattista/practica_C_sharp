/*
Crea un programa que pida al usuario un número entero. Si es múltiplo de 10,
informará al usuario y pedirá un segundo número,
para decir a continuación si este segundo número también es múltiplo de 10.
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